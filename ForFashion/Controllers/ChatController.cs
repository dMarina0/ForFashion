using Abstracts.IManagers;
using BusinessObjects.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ForFashion.Controllers
{
    public class ChatController : ApiController
    {
        private IChatManager _chatManager;
        public ChatController()
        {
            _chatManager = DIContainer.Instance.Resolve<IChatManager>();
        }
        //Get/api/Chat
        /// <summary>
        /// Returns the list of chats
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ChatDto> Get()
        {
            var result = _chatManager.GetAll();
            return result;
        }
    }
}
