using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatRoomServer.Context
{
    public class ChatRoomContext : DbContext
    {
        public ChatRoomContext(DbContextOptions<ChatRoomContext> option) : base(option)
        {

        }
        public DbSet<ChatRoomPoco> Message { get; set; }
    }
}
