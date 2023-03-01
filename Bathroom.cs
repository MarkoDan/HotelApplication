using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Bathroom
    {
        public string SubRoomType { get; set; }
        public bool IsToiletBroken { get; set; }

        public Bathroom()
        {
            IsToiletBroken = true;
            SubRoomType = "Bathroom";
        }

        public override string ToString()
        {
            return "I am Bathroom";
        }

        public void FixToilet()
        {
            if (IsToiletBroken)
            {
                IsToiletBroken = false;
            }
            IsToiletBroken = true;
        }
    }
}
