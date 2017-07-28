using Abstracts.IManagers;
using BusinessObjects.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForFashion.Controllers
{
    public class FashionHouseController : ApiController
    {
        private IFashionHouseManager _fashionhouseManager;
        public FashionHouseController()
        {
            
            _fashionhouseManager = DIContainer.Instance.Resolve<IFashionHouseManager>();

        }
        // GET api/FashionHouse
        /// <summary>
        /// Returns the list of fashion houses
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FashionHouseDto> Get()
        {
            var result = _fashionhouseManager.GetAll();
            return result;
        }
    }
}

