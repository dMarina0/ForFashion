using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities
{
   public  class UserDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
             public int Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
          [Required]
         public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
