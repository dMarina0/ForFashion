using BusinessObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Dtos
{
    public class ChatDto
    {
        public int Id { get; set; }
        public string ConnectionId { get; set; }
        public string UserName { get; set; }
        public string Messages { get; set; }
      

    }
}
