using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ci253
{
    public class HandlingInput
    {
        private Parser parser = new Parser();

        public void play()
        {
            Boolean finished = false;
            while (!finished)
            {
                Console.Write("Command: ");
                Command command = parser.getCommand();
                finished = processCommand(command);
            }
        }

        private Boolean processCommand(Command c)
        {
            if (c.IsUnkown)
            {
                Console.WriteLine("I don't understand the command, Chief!");
                return false;
            }
            else
            {
                //first word
                switch (c.CommandWord)
                {
                    //quitting
                    case "QUIT":
                        Console.WriteLine("Quitting");
                        return true;
                    //helping
                    case "HELP":
                        Console.WriteLine("Helping");
                        CommandWords.help();
                        break;
                    //report
                    case "REPORT":
                        Console.WriteLine("report");
                        break;
                    //refuel
                    case "REFUEL":
                        Console.WriteLine("refuel");
                        break;
                    //Go to room
                    case "GOTO":
                        //second word for "goto"
                        switch (c.SecondWord){
                            case "ROOM":
                                //goto room number
                                if (isInt(c.SecondWord))
                                {
                                    int roomNum;
                                    int.TryParse(c.SecondWord, out roomNum);
                                    CommandWords.gotoRoom(roomNum);
                                } else {
                                    return false;
                                }
                                break;
                            default: return false;
                        }
                        break;
                }
                return false;
            }

        }

        public Boolean isInt(String tWord)
        {
            int roomNum;
            try
            {
                int.TryParse(tWord, out roomNum);
                CommandWords.gotoRoom(roomNum);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

