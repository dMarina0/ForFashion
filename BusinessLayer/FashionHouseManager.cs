using Abstracts.IManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using Abstracts;

namespace BusinessLayer
{
    class FashionHouseManager : IFashionHouseManager
    {
        private IRepository<FashionHouse> _repository;
        public FashionHouseManager(IRepository<FashionHouse> repository)
        {
            _repository = repository;
        }
        public void AddFashionHouse(string id)
        {
            var fashionHouse = _repository.GetById(id);
            fashionHouse = new FashionHouse();
            _repository.Save();
        }

        public FashionHouse GetFashionHouse(string id)
        {
            var fashionHouse = _repository.GetById(id);
            return fashionHouse;
        }
    }
}
