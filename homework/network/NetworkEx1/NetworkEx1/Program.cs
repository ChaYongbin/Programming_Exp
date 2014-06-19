using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Network Lesson
using System.Net;
using System.Net.Sockets;

namespace NetworkEx1
{
    class Program
    {
        byte[] buf = new byte[1024];

        static void Main(string[] args)
        {
            byte[] buf = new byte[1024];

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Socket client;
            
            int port;
            Console.Write("port : ");
            port = int.Parse(Console.ReadLine());
            
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, port);
            s.Bind(ip);

            s.Listen(15);
            Console.WriteLine("서버 시작, 주소 : {0}", ip.ToString());

            while (true)
            {
                client = s.Accept();
                Console.WriteLine("클라이언트 접속 : {0}", client.RemoteEndPoint.ToString());
                NetworkStream ns = new NetworkStream(client);

                int len;
                string msg;

                while ((len = ns.Read(buf, 0, buf.Length)) != 0)
                {
                    msg = Encoding.UTF8.GetString(buf, 0, len);
                    Console.WriteLine("수신: {0}", msg);
                    ns.Write(buf, 0, len);
                }
                Console.WriteLine("클라이언트 {0} 접속종료 되었습니다.", client.RemoteEndPoint.ToString());
                ns.Close();
                client.Close();
            }
        }
    }
}
