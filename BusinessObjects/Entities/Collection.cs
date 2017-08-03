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
        [Required]
        public virtual FashionHouse FashionHouse { get; set; }
        public virtual IEnumerable<LiveStream> LiveStreams { get; set; }
        
    }
}
