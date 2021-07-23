using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
                     
            char playerTurn = 'x';
            int emptySpaces = 9;

            InitBoard();
                               
            while (true)
            {
                DisplayBoard();

                Console.WriteLine($"Player {playerTurn}, please choose row:");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Player {playerTurn}, please choose column:");
                int column = Convert.ToInt32(Console.ReadLine());

                if (board[row,column] == ' ')
                {
                    board[row, column] = playerTurn;
                    playerTurn = playerTurn == 'x' ? 'o' : 'x';
                    emptySpaces--;                   
                }

                if (Win() == 'x' || Win() == 'o')
                {
                    DisplayBoard();
                    Console.WriteLine($"Player {Win()} is wins!");
                    break;
                }

                if (emptySpaces == 0 && Win() == 'y')
                {
                    Console.WriteLine("Its a tie...");
                    break;
                }
            }
        }

        private static char Win()
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                return board[0, 2];
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                return board[1, 2];
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                return board[2, 2];
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[2, 2];
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[2, 0];
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                return board[2, 0];
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                return board[2, 1];
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                return board[2, 2];
            }
            else
            {
                return 'y';
            }
        }
        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
