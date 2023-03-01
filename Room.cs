using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApplication
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public List<SubRoom> subRooms { get; set; }


        public Room(int roomNumber, int numSubRooms/*, ISubRoom subRoom*/)
        {
            RoomNumber = roomNumber;
            subRooms = new List<SubRoom>();
            for (int i = 1; i <= numSubRooms; i++)
            {
                if (i == 1)
                {
                    subRooms.Add(new SubRoom(i/*, subRoom.SubRoomType*/));
                }
                else if (i == 2)
                {
                    subRooms.Add(new SubRoom(i/*, subRoom.SubRoomType*/));
                }
                else
                {
                    subRooms.Add(new SubRoom(i/*, subRoom.SubRoomType*/));
                }
            }
        }
    }
}
