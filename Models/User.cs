using Microsoft.AspNetCore.SignalR;
using System;

namespace Models
{
    public class User
    {
        public string ConnectionId { get; set; }
        public HubCallerContext Context { get; set; }
        public DateTime ConnectedOn { get; set; }

        public string FullName { get; set; }
    }
}
