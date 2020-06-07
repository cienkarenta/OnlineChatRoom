using ChatRoomServer.Hubs;
using ChatRoomServer.Repository;
using ChatRoomServer.Service;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ChatRoomServer.HostedService
{
    public class ChatRoomHostedService : BackgroundService
    {
        private readonly IHubContext<ChatRoomHub> hubContext;
        private readonly IChatRoomService service;

        public ChatRoomHostedService(IHubContext<ChatRoomHub> hubContext, IChatRoomService service)
        {
            this.service = service;
            this.hubContext = hubContext;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Run(async () =>
                {
                    var message = service.GetAllMessages();
                    await hubContext.Clients.All.SendAsync("UpdateChat", message,
                                    stoppingToken);
                }, stoppingToken);
                await Task.Delay(5000);
            }
        }
    }
}
