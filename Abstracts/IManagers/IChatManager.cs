﻿using BusinessObjects.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts.IManagers
{
    public interface IChatManager
    {
        IEnumerable<ChatDto> GetAll();
        void Insert(ChatDto obj);
    }
}
