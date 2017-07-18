using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.IManagers
{
    public interface IFashionHouseManager
    {
        FashionHouse GetFashionHouse(string id);
        void AddFashionHouse(string id);
    }
}
