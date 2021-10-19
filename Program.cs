using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FundamentalsLoopsGame_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int x = 0;

            //Console.SetCursorPosition(y,x);

            Console.SetCursorPosition(y = 0, x = 0);

            Console.WriteLine("game loop");
            bool gameOver = false;


            
            while (gameOver == false)
            {
                char input;
                ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
                input = readKeyInput.KeyChar;

               
                if (input == 's')
                {
                    Console.SetCursorPosition(x,y);
                }
            }
            
           // Console.Readkey("w");
            //ConsoleKeyInfo
           // ConsoleKeyInfo.getChar;
            Console.WriteLine("game over!");
            Console.ReadKey(true);
        }
    }
}
