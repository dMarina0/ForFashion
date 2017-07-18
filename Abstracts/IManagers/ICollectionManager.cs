using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.IManagers
{
    public interface ICollectionManager
    {
        Collection GetCollection(int id);
        void AddCollection(int id);
       
    }
}
