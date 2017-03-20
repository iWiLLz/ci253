using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ci253
{
    public class Room
    {
        String roomNumber;
        int temperature { get; set; }

        public bool heatingUp { get; set; }

        public Room(String tRoomNumber){
            roomNumber = tRoomNumber;
            heatingUp = false;
        }

        public void addTemp(int tTemp)
        {
            temperature += tTemp;
        }

        public string getStatus()
        {
            if (temperature >= 700)
            {
                return "BURNEDOUT";
            }
            else if(temperature >= 600)
            {
                return "FIRE";
            }
            else if (temperature >= 300)
            {
                return "SMOULDER";
            }
            else if (temperature >= 150)
            {
                return "DANGER";
            }
            else if (temperature >= 0)
            {
                return "SAFE";
            } else
            {
                return "UNKNOWN";
            }
        }
    }
}
