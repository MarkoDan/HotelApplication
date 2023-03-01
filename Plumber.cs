using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelApplication
{
    public class Plumber
    {
        public Bathroom bathroom { get; set; }
        public int RoomNumber { get; set; }


        public Plumber(int roomNumber)
        {
            RoomNumber = roomNumber;
            bathroom = new Bathroom();
        }

        public void FixToilet()
        {
            if (bathroom.IsToiletBroken)
            {
                bathroom.IsToiletBroken = false;
            }
            else
            {
                bathroom.IsToiletBroken = true;
                
            }
            Console.WriteLine("The plumber is on his way");
            Thread.Sleep(3000);
            Console.WriteLine($"Toilet has been fixed at room number {RoomNumber}.");


        }

    }
}
