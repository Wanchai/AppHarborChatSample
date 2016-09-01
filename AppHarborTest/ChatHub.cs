using System;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Collections.Generic;

namespace AppHarborTest
{
    public class ChatHub : Hub
    {

        static List<string> users = new List<string>();

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }

        public void AddUser(string name)
        {
            users.Add(name);
            Clients.All.refreshUser(users);
        }
        public void DeleteUser(string name)
        {
            users.Remove(name);
        }

        public string[] GetUsers()
        {
            
            return users.ToArray();
        }

        /*
    public string[] GetClients()
    {
        Clients.All
        return
    }
    */

    }

    class Users
    {
        public string name;
    }
}