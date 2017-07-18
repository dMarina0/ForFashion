using Abstracts;
using Abstracts.IManagers;
using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Dtos;
using BusinessObjects.Entities;
using BusinessObjects;

namespace BusinessLayer
{
     public class DressManager:IDressManager
    {
        private IRepository<Dress> _repository;
        public DressManager()
        {
            _repository = new Repository<Dress>();
        }
        public IEnumerable<DressDto> GetAll()
        {
            var result = _repository.GetAll().ToDressDtos();
            return result;
        }

  
    }
}
