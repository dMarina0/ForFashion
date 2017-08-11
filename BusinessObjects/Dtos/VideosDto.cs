using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Dtos
{
    public class VideosDto
    {
        public int Id { get; set; }
        public string VideoUrl { get; set; }
        public virtual Collection Collection { get; set; } 
    }
}
