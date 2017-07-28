using Abstracts.IManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using Abstracts;
using BusinessObjects.Dtos;
using BusinessObjects;
using DataLayer;

namespace BusinessLayer
{
    public class FashionHouseManager : IFashionHouseManager
    {
        private IRepository<FashionHouse> _repository;
        public FashionHouseManager()
        {
            _repository = new Repository<FashionHouse>();
        }


        public IEnumerable<FashionHouseDto> GetAll()
        {
            var result = _repository.GetAll().ToFashionHouseDtos();
            return result;
        }

    }
}
