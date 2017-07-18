using Abstracts.IManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Dtos;
using Abstracts;
using BusinessObjects.Entities;
using DataLayer;
using BusinessObjects;

namespace BusinessLayer
{
    public class DressManager : IDressManager
    {
        IRepository<Dress> _repository;

        public DressManager() {
            _repository = new Repository<Dress>();
        }

        public IEnumerable<DressDto> GetAll()
        {
            var result = _repository.GetAll().ToDressDtos();
            return result;
        }
        public void Insert(Dress obj)
        {
            _repository.Insert(obj);

        }
        public Dress ByName(long Name)
        {
           
            var result = _repository.GetByName(Name);
            return result;
        }
        
    }
}
