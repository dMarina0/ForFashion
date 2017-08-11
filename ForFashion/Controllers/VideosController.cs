using Abstracts.IManagers;
using BusinessObjects.Dtos;
using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForFashion.Controllers
{
    public class VideosController : ApiController
    {
        private IVideosManager _videosManager;
        public VideosController()
        {
            _videosManager = DIContainer.Instance.Resolve<IVideosManager>();
        }
        // GET api/LiveStream
        /// <summary>
        /// Returns the list of videos
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VideosDto> Get()
        {
            var result = _videosManager.GetAll();
            return result;
         }

        // GET api/Videos/{id}
        /// <summary>
        /// Returns the list of videos for a specific collection
        /// </summary>
        /// <returns></returns>
        public IEnumerable<VideosDto> GetById(int id)
        {
            var result = _videosManager.GetById(id);
            return result;
        }
    }
}
