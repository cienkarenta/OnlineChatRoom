using ChatRoomServer.Context;
using ChatRoomServer.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ChatRoomServer.Repository
{
    public class ChatRoomRepository : IChatRoomRepository
    {
        private readonly IServiceScopeFactory scopeFactory;

        public ChatRoomRepository(IServiceScopeFactory scopeFactory)
        {
                this.scopeFactory = scopeFactory;
        }
        public IEnumerable<ChatRoomDto> GetAllMessages()
        {
            var items = new List<ChatRoomPoco>();
            using (var scope = this.scopeFactory.CreateScope())
            {
                var Tablecontext = scope.ServiceProvider.GetRequiredService<ChatRoomContext>();
                items.AddRange(Tablecontext.Message.ToList());
            }
            return items.Select(MessageConverter.ConvertToMessage);
        }
    }
}
