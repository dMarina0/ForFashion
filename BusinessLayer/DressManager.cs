using Abstracts;
using Abstracts.IManagers;
using DataLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using BusinessObjects.Dtos;

namespace BusinessLayer
{
    public class DressManager : IDressManager
    {
        private Repository<Dress> _repository;

        public DressManager( )
        {
            _repository = new Repository<Dress>() ;
        }

        public IEnumerable<DressDto> GetAll()
        {
            var result = _repository.GetAll().ToDressDtos();
            return result;  
        }
           
    }
}
