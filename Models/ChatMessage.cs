using Newtonsoft.Json;
using System;

namespace Models
{
    public class ChatMessage
    {
        [JsonConverter(typeof(DateTimeSignalRConverter))]
        public DateTime Timestamp { get; set; }

        public string SenderUserFullName { get; set; }
        public string ReceiverUserFullName { get; set; }

        public string Content { get; set; }
    }
}
