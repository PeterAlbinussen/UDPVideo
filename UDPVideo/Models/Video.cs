using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UDPVideo.Models
{
    class Video
    {
        public DateTime DateTime {get; set; }
        public int Id { get; set; }
        public string Message { get; set; }
        
        



        public override string ToString()
        {
            return "Dato og tid: " + DateTime + Message + ": message Recieved";
        }

    }
}
