using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities
{
    public class Collection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int year { get; set; }
        public int FashionHouse_Id { get; set; }
        [Required]
        [ForeignKey("FashionHouse_Id")]
        public FashionHouse FashionHouse { get; set; }
        public ICollection<Videos> Video { get; set; }


    }
}
