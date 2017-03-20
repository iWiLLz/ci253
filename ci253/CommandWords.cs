using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ci253
{
    public static class CommandWords
    {                                           //need to add valid commands as we come across them
        private static string[] validCommands = { "QUIT", "HELP", "" };
        public static string[] ValidCommands { get { return validCommands; } }

        public static Boolean isCommand(string command)
        {
            if (validCommands.Contains(command))
                return true;
            return false;
        }

        public static void help()
        {
            Console.WriteLine("Welcome to FireFighter Simulator 2k65 version 2 electric boogaloo!");
            Console.WriteLine("The aim of the game is to use your firefighters to put out the fires around Motel Moors!");
            Console.WriteLine("Controls:");
            Console.WriteLine("Quit: quits the game");
            Console.WriteLine("...");
        }

        public static void gotoRoom(int roomNum)
        {
            Console.WriteLine("Going to room: " + roomNum);
        }
    }
}
