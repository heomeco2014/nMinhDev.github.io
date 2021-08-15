using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MultiServer
{
    class Client
    {
        //Info
        public string username;
        //Socket
        public const int BUFFER_SIZE = 2048;
        public byte[] buffer = new byte[BUFFER_SIZE];
        public Socket socket;
    }
    class Info
    {
        public string username;
        public string password;
        public string date;
        public string fullName;
        public string note;
        public int point;
    }
}
