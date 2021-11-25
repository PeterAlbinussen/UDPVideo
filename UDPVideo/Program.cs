using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using UDPVideo.Models;

namespace UDPVideo
{
    class Program
    {
        static void Main(string[] args)
        {

        private static Int32 _nextId = 1;

        UdpClient updserver = new UdpClient(9999);

        public void RecieverData()
        {


            IPAddress ip = IPAddress.Parse("192.168.104.200");

            IPEndPoint remoteIpEndPoint = new IPEndPoint(ip, 9999);

            try
            {
                Video video = new Video();




                Byte[] receivedBytes = updserver.Receive(ref remoteIpEndPoint);
                Console.WriteLine("received");

                string receivedData = Encoding.ASCII.GetString(receivedBytes);

                string[] data = receivedData.Split(" ");
                

                video.DateTime = data[0];

                video.Id = data[1];



                video.DateTime = Int32.Parse(data[0]);


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    



}
}


