using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using UDPVideo.Models;

namespace UDPVideo
{
    class UDP
    {
        private static int _nextId = 1;

        UdpClient updserver = new UdpClient(9999);

        public void ReceiverData()
        {
            
            IPAddress ip = IPAddress.Any;

            IPEndPoint remoteIpEndPoint = new IPEndPoint(ip, 9999);

            try
            {
                Video video = new Video();

                Byte[] receivedBytes = updserver.Receive(ref remoteIpEndPoint);
                Console.WriteLine("received");

                string receivedData = Encoding.ASCII.GetString(receivedBytes);

                string[] data = receivedData.Split(" ");

                //video.DateTime = data[0];

                //video.Id = data[1];

                video.DateTime = DateTime.Parse(data[0]);
                video.Id = Int32.Parse(data[1]);

                Console.WriteLine(video.DateTime + " " + video.Id + " ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }
    }
}
