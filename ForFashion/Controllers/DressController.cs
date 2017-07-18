using Abstracts.IManagers;
using BusinessObjects.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForFashion.Controllers
{
    public class DressController : ApiController
    {
        private IDressManager _dressManager;
        public DressController()
        {
            var cont = DIContainer.Instance;
            _dressManager = cont.Resolve<IDressManager>();
        }
        //Get api/dresses
        /// <summary>
        /// Returns the list of dresses
        /// </summary>
        /// <returns></returns>
       public IEnumerable<DressDto> Get()
        {
            var result = _dressManager.GetAll();
            return result;
        }
    }
}
