using ChatRoomServer.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomServer.Repository
{
    public interface IChatRoomRepository
    {
        IEnumerable<ChatRoomDto> GetAllMessages();
    }
}
