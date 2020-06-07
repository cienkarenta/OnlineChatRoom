using ChatRoomServer.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomServer.Service
{
    public interface IChatRoomService
    {
        public Task<IEnumerable<ChatRoomDto>> GetAllMessages();
    }
}
