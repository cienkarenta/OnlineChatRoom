using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatRoomServer.Context;
using ChatRoomServer.HostedService;
using ChatRoomServer.Hubs;
using ChatRoomServer.Repository;
using ChatRoomServer.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ChatRoomServer
{
    public class Startup
    {
        private const string CorsConfigurationKey = "_allowOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors(options => options.AddPolicy(CorsConfigurationKey, builder =>
            {
                builder
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed(_ => true)
                    .AllowCredentials();
            }));
            services.AddSignalR();
            services.AddDbContext<ChatRoomContext>(option => option.UseSqlServer(Configuration.GetConnectionString("MessagesConnection")), ServiceLifetime.Transient);
            services.AddTransient<IChatRoomRepository, ChatRoomRepository>();
            services.AddTransient<IChatRoomService, ChatRoomService>();
            services.AddHostedService<ChatRoomHostedService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(CorsConfigurationKey);


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<ChatRoomHub>("/ChatRoom");
            });
        }
    }
}
