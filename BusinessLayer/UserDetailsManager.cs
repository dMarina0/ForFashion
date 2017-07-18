using Abstracts;

using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserDetailsManager: IUserDetailsManager
    {
        private IRepository<ApplicationUser> _repository;
        public UserDetailsManager(IRepository<ApplicationUser> repository)
        {
            _repository = repository;
        }

        public void AddUserDetails(string id)
        {
            var applicationUser = _repository.GetById(id);
            applicationUser.UserDetails = new UserDetails();
            _repository.Save();
        }

        public ApplicationUser GetApplicationUser(string id)
        {
            var applicationUser = _repository.GetById(id);
            return applicationUser;
        }
    }
}
