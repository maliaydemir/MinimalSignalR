using Microsoft.AspNetCore.SignalR;

namespace MinimalSignalR.Hubs;

public class ChatHub:Hub
{
    public async Task SendMessage(string senderName, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", senderName, message);
    }
}