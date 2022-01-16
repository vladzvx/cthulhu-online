using Cthulhu.CoreLib.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cthulhu.CoreLib.Services
{
    public partial class DataHub 
    {
        public class Server : Hub
        {
            public async Task SendMessage(Message message)
            {
                await this.Clients.All.SendAsync("SendMessage", message);
            }
        }
    }
}
