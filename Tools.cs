using System;
using System.Collections.Generic;
using System.Text;

namespace warofheros
{
     static class Tools
    {
        public static void Colorfulwriting(string text , ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
            
        }
       


    }

}
