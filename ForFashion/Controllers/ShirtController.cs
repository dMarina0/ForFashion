using Abstracts;
using BusinessLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Microsoft.Practices.Unity;
using ForFashion.Controllers;

namespace ForFashion.Controllers
{
    public class ShirtController : ApiController 
    {
        private IShirtManager _shirtManager;
        public ShirtController()
        {
            // DIContainer cont = new DIContainer();
            var cont = DIContainer.Instance;
            _shirtManager = cont.Container.Resolve<IShirtManager>();
            
        }
        // GET api/shirts
        /// <summary>
        /// Returns the list of shirts
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ShirtDto> Get()
        {
            var result = _shirtManager.GetAll();
            return result;
        }
    }
}
