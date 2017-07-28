using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Dtos
{
    public class CollectionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int year { get; set; }
        [Required]
        public virtual FashionHouse FashionHouse { get; set; }
    }
}
