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
using Abstracts.IManagers;
using BusinessObjects.Dtos;

namespace ForFashion.Hubs
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    { 
        public ChatHub()
        {
            _chatManager = DIContainer.Instance.Resolve<IChatManager>();
        }
        public  List<ChatDto> ConnectedUsers = new List<ChatDto>();
        
        

        private IChatManager _chatManager;
        public void Send(string name, string message)
        {
            var id = Context.ConnectionId;
            _chatManager.Insert(new ChatDto
            {
                UserName = name,
                ConnectionId = id,
                Messages = message,
                
            });
            
            

            Clients.All.broadcastMessage(name, message);

        }
        public void Connected()
        {

            //IEnumerable<ChatDto> m = _chatManager.GetAll();

             // var p = m.Select(c => new Chat { UserName = c.UserName, ConnectionId=c.ConnectionId , Id=c.Id ,Messages=c.Messages});

              
            Clients.Caller.onConnected(JsonConvert.SerializeObject(_chatManager.GetAll()));
            
            
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