using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;
using BusinessObjects.Entities;
using Newtonsoft.Json;

namespace ForFashion.Hubs
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public static List<Chat> ConnectedUsers = new List<Chat>();
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
        public Task OnConnected(string userName)
         {
            var id = Context.ConnectionId;
            if (!ConnectedUsers.Any(x => x.ConnectionId == id))
            {
                ConnectedUsers.Add(new Chat { ConnectionId = id, UserName = userName });

                Clients.Caller.onConnected(id, userName, JsonConvert.SerializeObject(ConnectedUsers));

                Clients.AllExcept(id).onNewUserConnected(id, userName);
            }
            //ChatHub.ConnectedIds.Add(Context.ConnectionId);
            // Clients.All.usersConnected(ChatHub.ConnectedIds.Count());
            return base.OnConnected();
         }
         //public override Task OnDisconnected(bool stopCalled)
         //{
         //    ChatHub.ConnectedIds.Remove(Context.ConnectionId);
         //    Clients.All.usersConnected(ChatHub.ConnectedIds.Count());
         //    return base.OnDisconnected(stopCalled);
         //}

        /*public void Connect(string userName)
        {

            var id = Context.ConnectionId;
            

            if (ConnectedUsers.Count(x => x.ConnectionId == id) == 0)
            {

                ConnectedUsers.Add(new Chat { ConnectionId = id, UserName = userName });

               
                Clients.Caller.onConnected(id, userName, ConnectedUsers);

                
                Clients.AllExcept(id).onNewUserConnected(id, userName);

            }

        }*/
    }
   
}