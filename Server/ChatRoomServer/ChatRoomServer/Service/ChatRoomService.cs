using ChatRoomServer.Converters;
using ChatRoomServer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomServer.Service
{
    public class ChatRoomService : IChatRoomService
    {
        private readonly IChatRoomRepository repository;
        public ChatRoomService(IChatRoomRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<ChatRoomDto>> GetAllMessages()
        {
            var data = repository.GetAllMessages();
            return data;
        }
    }
}
