using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ChatRoomServer.Converters
{
    public class ChatRoomDto
    {
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }
}
