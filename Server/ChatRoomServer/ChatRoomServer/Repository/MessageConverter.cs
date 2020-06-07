using ChatRoomServer.Context;
using ChatRoomServer.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomServer.Repository
{
    public class MessageConverter
    {
        public static ChatRoomDto ConvertToMessage(ChatRoomPoco poco)
        {
            return new ChatRoomDto
            {
                UserName = poco.UserName,
                Date = poco.Date,
                Content = poco.Content
            };
        }
    }
}
