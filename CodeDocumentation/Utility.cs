using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocumentation
{
    public static  class Utility
    {


        //print color message
        public static void PrintColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
