
using Models;
using System.Threading.Tasks;

namespace Services.ChatHub
{
    /// <summary>
    /// Strongly Typed Client
    /// Define which methods ther server hub can call on the clients
    /// </summary>
    public interface IChatHubUser
    {
        Task NewMessageFromUser(ChatMessage message);
    }
}
