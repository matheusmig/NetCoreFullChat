using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Services.ChatHub
{
    public class ChatHub : Hub<IChatHubUser>
    {
        private readonly ILogger _logger;

        public ChatHub(ILogger<ChatHub> logger)
        {
            _logger = logger;
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();

            _logger.LogInformation($"Client connected {Context.ConnectionId}");
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            _logger.LogInformation($"Client disconnected {Context.ConnectionId}");

            await base.OnDisconnectedAsync(exception);
        }
    }
}
