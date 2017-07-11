using Abstracts;
using BusinessObjects;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ShirtManager : IShirtManager
    {
        private IRepository<Shirt> _repository;
        public ShirtManager()
        {
            _repository = new Repository<Shirt>();
        }

        public IEnumerable<ShirtDto> GetAll()
        {
            var result = _repository.GetAll().ToShirtDtos();
            return result;
        }
    }
}
