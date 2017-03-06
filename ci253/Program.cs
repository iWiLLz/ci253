using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//How to commit changes in Visual Studios after downloading the project from Git:

//Once you have downloaded the project, open it and connect to your local repo
//I found that deleting your old LOCAL repo helps Visual Studios find the correct one
//Don't worry, it will be up on Github so you haven't lost any work
//Using Team Explorer (View, Team Explorer) select the correct local repo
//Once you have done this, any changes can be commited by right clicking the project under Solution Explorer, and clicking "Commit"
//Once you have committed, just sync the projects, and you are ready to go!

namespace ci253
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("I get back down, and i get down again");
            Console.WriteLine("I get back down, and i get down again");
            Console.WriteLine("I get down up, and i get up down up down left right left right start select again");
        }
    }
}
