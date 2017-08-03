using Abstracts;
using Abstracts.IManagers;
using BusinessObjects;
using BusinessObjects.Dtos;
using BusinessObjects.Entities;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public class LiveStreamManager:ILiveStreamManager
    {
        private IRepository<LiveStream> _repository;
        public LiveStreamManager()
        {
            _repository = new Repository<LiveStream>();
        }
        public IEnumerable<LiveStreamDto> GetAll()
        {
            var result = _repository.GetAll().ToLiveStreamDtos();
            return result;
        }
    }
}
