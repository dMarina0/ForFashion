using Abstracts.IManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Dtos;
using Abstracts;
using BusinessObjects.Entities;
using DataLayer;
using BusinessObjects;

namespace BusinessLayer
{
    public class DressManager : IDressManager
    {
        IRepository<Dress> _repository;

        public DressManager()
        {
            _repository = new Repository<Dress>();
        }

        public IEnumerable<DressDto> GetAll()
        {
            var result = _repository.GetAll().ToDressDtos();
            return result;
        }

        public void Insert(DressDto dressDto)
        {
            var dressEntity = Mappers.ToDressEntity(dressDto);
            _repository.Insert(dressEntity);
            _repository.Save();
        }

        public IEnumerable<Dress> ByName(string name)
        {
            var result = _repository.GetAll().Where(it => it.Name.Contains(name));
            return result;
        }

        public void DeleteById(int id)
        {
            _repository.Delete(id);
        }

    }
}
