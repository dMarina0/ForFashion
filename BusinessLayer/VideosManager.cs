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
  public class VideosManager:IVideosManager
    {
        private IRepository<Videos> _repository;
        public VideosManager()
        {
            _repository = new Repository<Videos>();
        }
        public IEnumerable<VideosDto> GetAll()
        {
            var result = _repository.GetAll().ToVideosDtos();
            return result;
        }
        public IEnumerable<VideosDto> GetById(int id)
        {
            var result = _repository.GetAll().Where(it => it.Collection_Id == id).ToVideosDtos();
            return result;
        }
    }
}
