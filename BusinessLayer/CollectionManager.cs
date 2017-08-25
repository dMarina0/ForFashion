 using Abstracts.IManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using Abstracts;
using DataLayer;
using BusinessObjects.Dtos;
using BusinessObjects;

namespace BusinessLayer
{
    public class CollectionManager : ICollectionManager
    {
        private IRepository<Collection> _repository;

        public CollectionManager ()
        {
            _repository = new Repository<Collection>();
        }

        /*public void AddCollection(int id)
        {
            throw new NotImplementedException();
        }*/

        public IEnumerable<CollectionDto> GetAll()
        {
            var result = _repository.GetAll().ToCollectionDtos();
            return result;
        }

        public IEnumerable<CollectionDto> GetByFashionHouseId(int fashionId)
        {
            var result = _repository.GetAll().Where(it => it.FashionHouse_Id == fashionId).ToCollectionDtos();
            return result;
        }

        public CollectionDto GetById(int id)
        {
            var result = _repository.GetById(id).ToCollectionDto();
            return result;
        }
    }
}
