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
    public class LiveStreamController : ApiController
    {
        private ILiveStreamManager _liveStreamManager;
        public LiveStreamController()
        {
            _liveStreamManager = DIContainer.Instance.Resolve<ILiveStreamManager>();
        }
        // GET api/LiveStream
        /// <summary>
        /// Returns the list of videos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LiveStreamDto> Get()
        {
            var result = _liveStreamManager.GetAll();
            return result;
         }
    }
}
