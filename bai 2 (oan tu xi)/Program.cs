using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace bai_2__oan_tu_xi_
{
    class Program
    {
        static void Main(string[] args)
        {
            int recv;
            byte[] data = new byte[1024];
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 3456);
            Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Dgram, ProtocolType.Udp);
            server.Bind(ipep);
            Console.WriteLine("Waiting for a client...");            
            EndPoint Remote = ipep;            
            byte[] ketqua;
            while (true)
            {
                data = new byte[1024];
                server.ReceiveFrom(data, ref Remote);
                int Result = Convert.ToInt32(Encoding.ASCII.GetString(data));
                Random r = new Random();
                int serverResult = r.Next(0, 3);
                
                if((Result==0 && serverResult==0)|| (Result==1 &&serverResult==1)||(Result==2&&serverResult==2))
                {
                    ketqua = Encoding.ASCII.GetBytes("Hoa");
                    server.SendTo(ketqua, Remote);

                }else if((Result == 0 && serverResult == 1) || (Result == 1 && serverResult == 2) || (Result == 2 && serverResult == 0))
                { 
                    ketqua = Encoding.ASCII.GetBytes("Thang");
                    server.SendTo(ketqua, Remote);
                }else {
                    ketqua = Encoding.ASCII.GetBytes("Thua");
                    server.SendTo(ketqua, Remote);
                }
            }
            Console.WriteLine("Stopping client");
            server.Close();
        }
    }
}
