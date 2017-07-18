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
       // [RoutePrefix("api/Dress")]
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
        /* public void Insert(DressDto obj)
         {
             _dressManager.Add(obj);
         }
         */
        void AddObj(Dress obj)
        {
            _dressManager.Insert(obj);
        }
       
        public Dress GetObjByName(long Name)
        {
           var result= _dressManager.ByName(Name);
            return result;
        }
    }
 }
    

