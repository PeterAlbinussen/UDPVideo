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
            UDP udp = new UDP();
            Console.WriteLine("UDP server started");

            while(true)
            {
                udp.ReceiverData();
            }

        }
    }
    //
}







