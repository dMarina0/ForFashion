using Abstracts.IManagers;
using BusinessObjects.Dtos;
using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

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
            var result = _fashionhouseManager.GetAll().Take(3);
            return result;
        }

        /// <summary>
        /// Returns a fashion house by a given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FashionHouseDto GetById(int id)
        {
            var result = _fashionhouseManager.GetById(id);
            return result;
        }
    }
}

