using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        #region server variables
        public string clientVersion = "1.0";
        public string adminVersion = "admin_1.0";
        public bool connectionsOpen = true;
        private byte[] g_buffer = new byte[1024];
        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Users> userList = new List<Users>();
        List<Admins> adminList = new List<Admins>();
        #endregion
    }
}
