using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using BusinessObjects.Entities;
using BusinessObjects.Dtos;
using Abstracts;
using System;

namespace BusinessLayer
{
    public class UserDetailsManager : IUserDetailsManager
    {
        private IRepository<ApplicationUser> _repository;
        private IRepository<UserDetails> _UserDetailsRepository;
        public UserDetailsManager(IRepository<ApplicationUser> repository, IRepository<UserDetails> UserDetailsRepository)
        {
            _repository = repository;
            _UserDetailsRepository = UserDetailsRepository;
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
        public void UpdateUserDetails(string id, UserDetailsDto dto)
        {
            var applicationUser = _repository.GetById(id);
            applicationUser.UserDetails.Address = dto.Address;
            applicationUser.UserDetails.City = dto.City;
            applicationUser.UserDetails.FirstName = dto.FirstName;
            applicationUser.UserDetails.LastName = dto.LastName;
            applicationUser.UserDetails.PhoneNumber = dto.PhoneNumber;
            _repository.Save();

        }
        public IEnumerable<UserDetailsDto> GetAll()
        {
            var rezult= _UserDetailsRepository.GetAll().ToUserDetailsDtos();
            return rezult;

        }

        public UserDetailsDto GetByUser(string userId)
        {
         
             var applicationUser = _repository.GetById(userId);
             applicationUser.UserDetails = new UserDetails(); ;
             var result = Mappers.ToUserDetailDto(applicationUser.UserDetails);
             return result;
            
            /*var rezultat = _UserDetailsRepository.GetById(userId);
            var result = Mappers.ToUserDetailDto(rezultat);
            return result;
            */
        }
    }
}