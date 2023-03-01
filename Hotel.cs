using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Hotel
    {

        public string Name { get; set; }
        public int NumFloors { get; set; }
        public int[] NumRoomsPerFloor { get; set; }
        public List<Floor> Floors { get; set; }


        public Hotel(string name, int numFloors, int[] numRoomsPerFloor, int[] numSubRooms)
        {
            Name = name;
            NumFloors = numFloors;
            NumRoomsPerFloor = numRoomsPerFloor;    
            Floors = new List<Floor>();
            for(int i = 0; i < numFloors; i++)
            {
                Floors.Add(new Floor(i + 1, NumRoomsPerFloor[i], numSubRooms[i]));  
            } 
        }

        public override string ToString()
        {
            return $"Hotel {Name} has {NumFloors} floors!";
        }
    }
}
