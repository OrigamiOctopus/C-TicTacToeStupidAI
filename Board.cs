using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmandaTustincit134_lab3_csharp_basicprogramming
{
    class Board 
    {
        private int square1;
        private int square2;
        private int square3;
        private int square4;
        private int square5;
        private int square6;
        private int square7;
        private int square8;
        private int square9;

        public void SetSquare(int squareNum, int squareStatus)
        {
            if (squareNum == 1)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square1 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
            else if (squareNum == 2)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square2 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
            else if (squareNum == 3)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square3 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
            else if (squareNum == 4)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square4 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
            else if (squareNum == 5)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square5 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
            else if (squareNum == 6)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square6 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
            else if (squareNum == 7)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square7 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
            else if (squareNum == 8)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square8 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
            else if (squareNum == 9)
            {
                if (squareStatus == 0 || squareStatus == 1 || squareStatus == 2)
                {
                    square9 = squareStatus;
                }
                else
                {
                    Console.WriteLine("Invalid Entry.");
                }
            }
        }
        public int GetSquare(int squareNum)
        {
            if (squareNum == 1)
            {
                return square1;
            }
            else if (squareNum == 2)
            {
                return square2;
            }
            else if (squareNum == 3)
            {
                return square3;
            }
            else if (squareNum == 4)
            {
                return square4;
            }
            else if (squareNum == 5)
            {
                return square5;
            }
            else if (squareNum == 6)
            {
                return square6;
            }
            else if (squareNum == 7)
            {
                return square7;
            }
            else if (squareNum == 8)
            {
                return square8;
            }
            else 
            {
                return square9;
            }
        }


        public void DrawBoard()
        {
            if (square1 == 0)
            {
                Console.Write("-");
            }
            else if (square1 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            if (square2 == 0)
            {
                Console.Write("-");
            }
            else if (square2 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            if (square3 == 0)
            {
                Console.WriteLine("-");
            }
            else if (square3 == 1)
            {
                Console.WriteLine("X");
            }
            else
            {
                Console.WriteLine("O");
            }
            if (square4 == 0)
            {
                Console.Write("-");
            }
            else if (square4 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            if (square5 == 0)
            {
                Console.Write("-");
            }
            else if (square5 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            if (square6 == 0)
            {
                Console.WriteLine("-");
            }
            else if (square6 == 1)
            {
                Console.WriteLine("X");
            }
            else
            {
                Console.WriteLine("O");
            }
            if (square7 == 0)
            {
                Console.Write("-");
            }
            else if (square7 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            if (square8 == 0)
            {
                Console.Write("-");
            }
            else if (square8 == 1)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("O");
            }
            if (square9 == 0)
            {
                Console.WriteLine("-");
            }
            else if (square9 == 1)
            {
                Console.WriteLine("X");
            }
            else
            {
                Console.WriteLine("O");
            }
        }
    }
 
}

