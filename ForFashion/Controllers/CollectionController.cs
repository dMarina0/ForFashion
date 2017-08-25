using Abstracts.IManagers;
using BusinessObjects.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ForFashion.Controllers
{
    public class CollectionController : ApiController
    {
        private ICollectionManager _collectionManager;
        public CollectionController()
        {

            _collectionManager = DIContainer.Instance.Resolve<ICollectionManager>();

        }
        // GET api/Collection
        /// <summary>
        /// Returns the list of collections
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CollectionDto> Get()
        {
            var result = _collectionManager.GetAll();
            return result;
        }
        
        public IEnumerable<CollectionDto> GetSomeElements()
        {
            var result = _collectionManager.GetAll().Take(6);
            return result;
        }

        /// <summary>
        /// Returns a collection with the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CollectionDto GetById(int id)
        {
            var result = _collectionManager.GetById(id);
            return result;
        }

        /// <summary>
        /// Returns collections for a specific fashion house
        /// </summary>
        /// <param name="fashionId"></param>
        /// <returns></returns>
        public IEnumerable<CollectionDto> GetByFashionHouseId(int fashionId)
        {
            var result = _collectionManager.GetByFashionHouseId(fashionId);
            return result;
        }
    }
}