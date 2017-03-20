using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ci253
{
    class Game
    {
        public int refreshRate = (int)GameSpeed.FAST;

        public void TickTock(Object data)
        {
            //Console.WriteLine("Next click of the clock...");
        }

        //List<Room> Rooms;
        Room[] Rooms = new Rooms[5];

        int roomXY;
        public void setUpRooms()
        {
            //Create rooms
            for(int y = 0; y < roomXY; y++)
            {
                for(int x = 0; x < roomXY; x++)
                {
                    Rooms.Add(new Room());
                }
            }
            
        }
    }
}