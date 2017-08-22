using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;
using BusinessObjects.Entities;
using Newtonsoft.Json;
using DataLayer;

namespace ForFashion.Hubs
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {

        public static List<Chat> ConnectedUsers = new List<Chat>();
        public static List<Messages> CurrentMessage = new List<Messages>();
        
        
        public void Send(string name, string message)
        {   
            Clients.All.broadcastMessage(name, message);
            
        }
        public  Task OnConnected()
        {
            var name = Context.User.Identity.Name;
            var id = Context.ConnectionId;
            using (var db = new ApplicationDbContext())
            {
                var user = db.Chats
                    .SingleOrDefault(u => u.UserName == name);

                if (user == null)
                {
                    user = new Chat
                    {
                        UserName = name,
                        ConnectionId = id
                    };
                    db.Chats.Add(user);
                }
            }
            return base.OnConnected();
        }
            
        
        /* var id = Context.ConnectionId;
         nameUser = Context.User.Identity.Name;

         if (!ConnectedUsers.Any(x => x.UserName == nameUser))
         {
             ConnectedUsers.Add(new Chat { ConnectionId = id, UserName = nameUser });

             Chat CurrentUser = ConnectedUsers.Where(u => u.ConnectionId == id).FirstOrDefault();

             Clients.Caller.onConnected(id, CurrentUser.UserName, JsonConvert.SerializeObject(ConnectedUsers));

             Clients.AllExcept(id).onNewUserConnected(nameUser);

         }

         return base.OnConnected();
      }*/



    }
   
}