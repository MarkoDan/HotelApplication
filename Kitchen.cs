using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Kitchen
    {
        public string SubRoomType { get; set; }

        public Kitchen()
        {
            SubRoomType = "Kitchen";
        }

        public override string ToString()
        {
            return $"I am {SubRoomType}";
        }


    }
}
