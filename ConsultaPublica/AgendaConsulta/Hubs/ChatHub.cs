using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace AgendaConsulta.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
