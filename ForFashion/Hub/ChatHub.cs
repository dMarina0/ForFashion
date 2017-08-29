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

            

              
            Clients.Caller.onConnected(JsonConvert.SerializeObject(_chatManager.GetAll()));
            
            
        }


       


    }

}