using BusinessObjects.Dtos;
using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.IManagers
{
    public interface IDressManager
    {
        IEnumerable<DressDto> GetAll();
        void Insert(DressDto obj);
        IEnumerable<Dress> ByName(string name);
        void DeleteById(int id);
    }
}
