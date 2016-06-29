using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }

        //自定义Method，首字母大小其他小写，客户端全部小写
        public void Sendtest(string name, string value)
        {
            Clients.All.addTest(name, value);
        }
    }
}