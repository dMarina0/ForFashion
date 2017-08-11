using Abstracts;
using BusinessObjects.Dtos;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForFashion.Controllers
{
    [Authorize]
    public class UserDetailsController : ApiController
    {
        private IUserDetailsManager _iuserDetailsManager;

        public UserDetailsController()
        {
            _iuserDetailsManager = DIContainer.Instance.Resolve<IUserDetailsManager>();
        }
        // POST api/UserDetails/Update
        public void Update(UserDetailsDto dto)
        {
            string id = RequestContext.Principal.Identity.GetUserId();
            _iuserDetailsManager.UpdateUserDetails(id, dto);
        }
        // GET api/UserDetails/{id}
        /// <summary>
        /// Returns the list of shirts
        /// </summary>
        /// <returns></returns>
        public UserDetailsDto GetbyUser(string id)
        {
            id = RequestContext.Principal.Identity.GetUserId();
            var result = _iuserDetailsManager.GetByUser(id);
            return result;
        }
    }
}
