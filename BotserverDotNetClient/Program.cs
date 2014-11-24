using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quobject.SocketIoClientDotNet.Client;


namespace BotserverDotNetClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var socket = IO.Socket("https://guebot.herokuapp.com");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                socket.Emit("movement", "data");
                socket.On("movement", (data) =>
                {
                    Console.WriteLine(data);
                });
            });
            Console.ReadLine();
        }
    }
}
