using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Bedroom
    {
        public string SubRoomType { get; set; }

        public Bedroom()
        {
            SubRoomType = "Bedroom";
        }
        public override string ToString()
        {
            return "I am Bedroom";
        }
    }
}
