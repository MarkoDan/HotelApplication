using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Floor
    {

        public int FloorNumber { get; set; }
        public List<Room> Rooms { get; set; }

        public Floor(int floorNumber, int numRooms, int numSubRooms)
        {
            FloorNumber = floorNumber;
            Rooms = new List<Room>();
            for(int i = 1; i <= numRooms; i++)
            {
                Rooms.Add(new Room(i, numSubRooms));
            }
        }


        public override string ToString()
        {
            return $"Floor {FloorNumber} has {Rooms.Count} rooms, each with {Rooms[0].subRooms.Count} sub-rooms.";
        }
    }
}
