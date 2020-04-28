using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmandaTustincit134_lab3_csharp_basicprogramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squareStatus = new Square();
            Player playerOne = new Player();
            Board gameBoard = new Board();

            Console.WriteLine("Displaying Tic Tac Toe Board");
            while (true)
            {
                gameBoard.DrawBoard();

                //set per user input
                Console.WriteLine("Enter a number between 1 and 9 inclusively.");
                playerOne.SetUserEntry(Convert.ToInt32(Console.ReadLine()));

                if (playerOne.GetUserEntry() == 1 && gameBoard.GetSquare(1) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(1, 1);
                }
                else if (playerOne.GetUserEntry() == 2 && gameBoard.GetSquare(2) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(2, 1);
                }
                else if (playerOne.GetUserEntry() == 3 && gameBoard.GetSquare(3) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(3, 1);
                }
                else if (playerOne.GetUserEntry() == 4 && gameBoard.GetSquare(4) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(4, 1);
                }
                else if (playerOne.GetUserEntry() == 5 && gameBoard.GetSquare(5) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(5, 1);
                }
                else if (playerOne.GetUserEntry() == 6 && gameBoard.GetSquare(6) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(6, 1);
                }
                else if (playerOne.GetUserEntry() == 7 && gameBoard.GetSquare(7) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(7, 1);
                }
                else if (playerOne.GetUserEntry() == 8 && gameBoard.GetSquare(8) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(8, 1);
                }
                else if (playerOne.GetUserEntry() == 9 && gameBoard.GetSquare(9) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(9, 1);
                }

                gameBoard.DrawBoard();

                Console.WriteLine("AI moving.");
                //AI
                Random random = new Random();
                int randomSquare = random.Next(1, 10);
                if (randomSquare == 1 && gameBoard.GetSquare(1) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(1, 2);
                }
                else if (randomSquare == 2 && gameBoard.GetSquare(2) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(2, 2);
                }
                else if (randomSquare == 3 && gameBoard.GetSquare(3) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(3, 2);
                }
                else if (randomSquare == 4 && gameBoard.GetSquare(4) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(4, 2);
                }
                else if (randomSquare == 5 && gameBoard.GetSquare(5) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(5, 2);
                }
                else if (randomSquare == 6 && gameBoard.GetSquare(6) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(6, 2);
                }
                else if (randomSquare == 7 && gameBoard.GetSquare(7) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(7, 2);
                }
                else if (randomSquare == 8 && gameBoard.GetSquare(8) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(8, 2);
                }
                else if (randomSquare == 9 && gameBoard.GetSquare(9) == (squareStatus.getEMPTY()))
                {
                    gameBoard.SetSquare(9, 2);
                }

                //Test
                if (
                    (gameBoard.GetSquare(1) == squareStatus.getX() && gameBoard.GetSquare(2) == squareStatus.getX() && gameBoard.GetSquare(3) == squareStatus.getX()) ||
                    (gameBoard.GetSquare(4) == squareStatus.getX() && gameBoard.GetSquare(5) == squareStatus.getX() && gameBoard.GetSquare(6) == squareStatus.getX()) ||
                    (gameBoard.GetSquare(7) == squareStatus.getX() && gameBoard.GetSquare(8) == squareStatus.getX() && gameBoard.GetSquare(9) == squareStatus.getX()) ||
                    (gameBoard.GetSquare(1) == squareStatus.getX() && gameBoard.GetSquare(4) == squareStatus.getX() && gameBoard.GetSquare(7) == squareStatus.getX()) ||
                    (gameBoard.GetSquare(2) == squareStatus.getX() && gameBoard.GetSquare(5) == squareStatus.getX() && gameBoard.GetSquare(8) == squareStatus.getX()) ||
                    (gameBoard.GetSquare(3) == squareStatus.getX() && gameBoard.GetSquare(6) == squareStatus.getX() && gameBoard.GetSquare(9) == squareStatus.getX()) ||
                    (gameBoard.GetSquare(1) == squareStatus.getX() && gameBoard.GetSquare(5) == squareStatus.getX() && gameBoard.GetSquare(9) == squareStatus.getX()) ||
                    (gameBoard.GetSquare(3) == squareStatus.getX() && gameBoard.GetSquare(5) == squareStatus.getX() && gameBoard.GetSquare(7) == squareStatus.getX()))
                {
                    Console.WriteLine("\nPlayer Wins!");

                    gameBoard.DrawBoard();
                    break;
                }

                if (
                (gameBoard.GetSquare(1) == squareStatus.getO() && gameBoard.GetSquare(2) == squareStatus.getO() && gameBoard.GetSquare(3) == squareStatus.getO()) ||
                (gameBoard.GetSquare(4) == squareStatus.getO() && gameBoard.GetSquare(5) == squareStatus.getO() && gameBoard.GetSquare(6) == squareStatus.getO()) ||
                (gameBoard.GetSquare(7) == squareStatus.getO() && gameBoard.GetSquare(8) == squareStatus.getO() && gameBoard.GetSquare(9) == squareStatus.getO()) ||
                (gameBoard.GetSquare(1) == squareStatus.getO() && gameBoard.GetSquare(4) == squareStatus.getO() && gameBoard.GetSquare(7) == squareStatus.getO()) ||
                (gameBoard.GetSquare(2) == squareStatus.getO() && gameBoard.GetSquare(5) == squareStatus.getO() && gameBoard.GetSquare(8) == squareStatus.getO()) ||
                (gameBoard.GetSquare(3) == squareStatus.getO() && gameBoard.GetSquare(6) == squareStatus.getO() && gameBoard.GetSquare(9) == squareStatus.getO()) ||
                (gameBoard.GetSquare(1) == squareStatus.getO() && gameBoard.GetSquare(5) == squareStatus.getO() && gameBoard.GetSquare(9) == squareStatus.getO()) ||
                (gameBoard.GetSquare(3) == squareStatus.getO() && gameBoard.GetSquare(5) == squareStatus.getO() && gameBoard.GetSquare(7) == squareStatus.getO()))
                {
                    Console.WriteLine("\nAI Wins!");
                    
                    gameBoard.DrawBoard();
                    break;
                }


            }

            Console.ReadLine();
        }
    }
}