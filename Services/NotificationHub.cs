
using Microsoft.AspNetCore.SignalR;

namespace TasksAPI.Services

{
    public class NotificationHub: Hub
    {
        public async Task BroadcastMessage(Object[] messages)
        {
            await this.Clients.All.SendAsync("message_received", messages);
        }

    }
}
