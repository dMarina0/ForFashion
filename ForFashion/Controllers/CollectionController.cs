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
    }
}