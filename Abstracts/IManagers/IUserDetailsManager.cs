using BusinessObjects;
using BusinessObjects.Dtos;
using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public interface IUserDetailsManager
    {
        ApplicationUser GetApplicationUser(string id);
        void AddUserDetails(string id);
        void UpdateUserDetails(string id, UserDetailsDto dto);
        IEnumerable<UserDetailsDto> GetAll();
        UserDetailsDto GetByUser(string userId);
    }
}
