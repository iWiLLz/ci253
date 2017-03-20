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

        List<Room> Rooms;
        int roomAmount = 15;

        public void createRooms()
        {
            Random srand = new Random();
            int r = srand.Next(0, roomAmount);
            for (int x = 0; x < roomAmount; x++)
            {
                Rooms.Add(new Room(x.ToString()));
                if (x == r)
                {
                    Rooms[x].heatingUp = true;
                }
            }
        }

        public void checkFires()
        {

        }
            
    }
}