using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Board
    {
        private string[] b = new string[9];

        public Board()
        {
            for(int x = 0; x < 9; x++)
            {
                b[x] = " ";
            }
         
        }

        public Board(string c)
        {
            for (int x = 0; x < 9; x++)
            {
                b[x] = c;
            }

        }


        public void printBoard()
        {

            Console.Clear();
            Console.WriteLine(b[0] + "|" + b[1] + "|" + b[2]);
            Console.WriteLine(b[3] + "|" + b[4] + "|" + b[5]);
            Console.WriteLine(b[6] + "|" + b[7] + "|" + b[8]);


        }


        public Boolean addX(int x)
        {
            b[x] = "X";
            return true;
        }



    }
}
