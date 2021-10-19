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
            int y;
            int x;
            
            //Console.SetCursorPosition(y,x);


            Console.WriteLine("game loop");
            bool gameOver = false;


            while (gameOver == false)
            {
                char input;
                ConsoleKeyInfo readKeyInput = Console.ReadKey(true);
                input = readKeyInput.KeyChar;

                Console.WriteLine("user input = " + input);
            }
            Console.WriteLine("game over!");
            Console.ReadKey(true);
        }
    }
}
