using Abstracts.IManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entities;
using Abstracts;
using DataLayer;

namespace BusinessLayer
{
    public class CollectionManager : ICollectionManager
    {
        private IRepository<Collection> _repository;

        public CollectionManager (Repository<Collection> repository)
        {
            _repository = repository;
        }

        public void AddCollection(int id)
        {
            throw new NotImplementedException();
        }

        public Collection GetCollection(int id)
        {
            var collection = _repository.GetById(id);
                return collection;
        }
    }
}
