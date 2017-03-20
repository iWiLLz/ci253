using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ci253
{
    class Room
    {
        float temperature;
        List<Room> AdjacentRooms;

        public void addRoom(Room x)
        {
            AdjacentRooms.Add(x);
        }
    }
}
