using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ci253
{
    class CommandWords
    {                                           //need to add valid commands as we come across them
        private static string[] validCommands = { "quit", "help", "..." };
        public string[] ValidCommands { get { return validCommands; } }

        public static Boolean isCommand(string command)
        {
            if (validCommands.Contains(command))
                return true;
            return false;
        }
    }
}
