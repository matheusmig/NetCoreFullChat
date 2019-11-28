using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ChatCache
{
    public interface IChatCache
    {
        User GetConnectedUserByName(string name);
        User GetConnectedUserByConnectionId(string connectionId);
        bool TryAddUser(User user);
        bool RemoveUserByConnectionId(string connectionId);
        bool RemoveUserByName(int name);
    }
}
