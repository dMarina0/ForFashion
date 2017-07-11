using Abstracts;
using BusinessLayer;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForFashion.Controllers
{
    public class ShirtController : ApiController
    {
        private IShirtManager _shirtManager;
        public ShirtController()
        {
            _shirtManager = new ShirtManager();
        }
        // GET api/shirts
        public IEnumerable<ShirtDto> Get()
        {
            var result = _shirtManager.GetAll();
            return result;
        }
    }
}
