using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Dtos
{
    public class LiveStreamDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string VideoUrl { get; set; }
        public string Description { get; set; }
        public virtual Collection Collection { get; set; } 
    }
}
