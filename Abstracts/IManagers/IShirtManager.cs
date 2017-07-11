using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public interface IShirtManager
    {
        IEnumerable<ShirtDto> GetAll();
    }
}
