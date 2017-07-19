using Abstracts.IManagers;
using BusinessObjects.Dtos;
using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessObjects.Entities;
using System.Xml;

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

        //[HttpPost]
        //[Route("api/Dress/post")]
        [System.Web.Http.HttpPost]
        public IHttpActionResult AddObj(DressDto obj)
        {
            _dressManager.Insert(obj);
            return Ok();
        }

        //[HttpGet]
        //[Route("api/Dress/{"name=string")]
        [System.Web.Http.HttpGet]
        public IEnumerable<Dress> GetObjByName(string name)
        {
            var result = _dressManager.ByName(name);
            return result;
        }

        //[HttpDelete]
        //[Route("api/Dress/{id}")]
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteObjById(int id)
        {
            _dressManager.DeleteById(id);
            return Ok();
        }
    }
}
