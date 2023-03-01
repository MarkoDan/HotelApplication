using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class SubRoom
    {
        public int SubRoomNumber { get; set; }
        public string Type { get; set; }

        public SubRoom(int subRoomNumber/*, string type*/)
        {
            SubRoomNumber = subRoomNumber;
            //Type = type;
        }
    }
}
