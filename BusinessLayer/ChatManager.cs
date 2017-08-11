using Abstracts;
using Abstracts.IManagers;
using BusinessObjects;
using BusinessObjects.Dtos;
using BusinessObjects.Entities;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class ChatManager:IChatManager
    {
        private IRepository<Chat> _repository;
        public ChatManager()
        {
            _repository = new Repository<Chat>();
        }
        public IEnumerable<ChatDto> GetAll()
        {
            var result = _repository.GetAll().ToChatDtos();
            return result;
        }
    }
}
