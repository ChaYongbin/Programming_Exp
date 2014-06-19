using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace NetworkClient
{
    public class Client
    {
        private Socket s;
        private NetworkStream ns;
        private byte[] buf = new byte[1024];

        public string Connect(string address, int port)
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(address), port);

            try
            {
                s.Connect(ip);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            ns = new NetworkStream(s);
            return "success";
        }
        public void Close()
        {
            ns.Close();
            s.Close();
        }

        public string Send(string msg)
        {
            byte[] data = Encoding.UTF8.GetBytes(msg);
            ns.Write(data, 0, data.Length);
            int len = ns.Read(buf, 0, buf.Length);
            string ret = Encoding.UTF8.GetString(buf, 0, len);
            return ret;
        }
    }
}
