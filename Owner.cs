using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Owner
    {
        public string Name { get; set; }
        public List<Hotel> Hotels;

        public Owner(string name)
        {
            Name = name;
            Hotels = new List<Hotel>();
        }


    }
}
