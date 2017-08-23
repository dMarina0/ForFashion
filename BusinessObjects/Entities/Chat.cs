using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entities
{
   
   public class Chat
    {
        [Key]
        public int Id { get; set; }
        public string ConnectionId { get; set; }
        public string UserName { get; set; }
        public string Messages{ get; set; }
       

    }
}
