using Abstracts.IManagers;
using BusinessObjects.Dtos;
using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForFashion.Controllers
{
    public class DressController : ApiController
    {
        private IDressManager _dressManager;

        public DressController()
        {
            _dressManager = DIContainer.Instance.Resolve<IDressManager>();
        }
        public IEnumerable<DressDto> Get()
        {
            var res = _dressManager.GetAll();
            return res;
        }

    }
}
