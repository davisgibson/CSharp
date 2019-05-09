using System;
namespace ArrayLoopPractice
{
    public class TicTacToe
    {
        String[][] board = new String[3][];
        bool playing = true;
        bool xturn = true;
        String winner;
        public TicTacToe()
        {
            board[0] = new String[] { " ", " ", " " };
            board[1] = new String[] { " ", " ", " " };
            board[2] = new String[] { " ", " ", " " };

            Console.WriteLine("Welcome to Tic Tac Toe!");
            while (playing)
            {
                printBoard();
                Console.WriteLine("Please enter the coordinates for your next move <column><row>(ie 12 for col1 row2)");
                String mover = Console.ReadLine();
                int move = 0;
                try
                {
                    move = Convert.ToInt32(mover);
                }
                catch
                {
                    if(mover == "exit")
                    {
                        Console.WriteLine("Thanks for playing!");
                        break;
                    }
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int xcoord =(move % 10);
                int ycoord = (move / 10);
                Console.WriteLine("x: " + xcoord + " y: " + ycoord);
                xcoord -= 1;
                ycoord -= 1;
                if (board[xcoord][ycoord] == " ")
                {
                    makeMove(xcoord, ycoord);
                }
                else
                {
                    Console.WriteLine("Not a valid move!");
                    continue;
                }
                isGameOver();

                xturn = !xturn;
            }
            printBoard();
            if(winner != null && winner == "tie")
            {
                Console.WriteLine("It's a tie! Slightly embarassing.");
            }
            else
            {
                Console.WriteLine("The winner is: " + winner);
            }

        }



        public void makeMove(int x, int y)
        {
            if (xturn)
            {
                board[x][y] = "x";
            }
            else
            {
                board[x][y] = "o";
            }
        }



        public void printBoard()
        {
            Console.WriteLine("   1  2  3 ");
            for(int x = 0; x < board.Length; x++)
            { 
                Console.Write((x+1) +" ");
                for(int y = 0; y < board[0].Length; y++)
                {
                    Console.Write("[" + board[x][y] + "]");
                }
                Console.WriteLine();
            }

        }



        public void isGameOver()
        {
            //check all of the rows
            for (int x = 0; x < 3; x++)
            {
                int rowSum = 0;
                for (int y = 0; y < 3; y++)
                {
                    if (board[x][y] == "x")
                    {
                        rowSum++;
                    }
                    else if (board[x][y] == "o")
                    {
                        rowSum--;
                    }
                }
                if (rowSum == 3)
                {
                    playing = false;
                    winner = "x";

                }
                else if (rowSum == -3)
                {
                    playing = false;
                    winner = "o";
                }
            }

            //czech all of the columns
            for (int x = 0; x < 3; x++)
            {
                int colSum = 0;
                for (int y = 0; y < 3; y++)
                {
                    if (board[y][x] == "x")
                    {
                        colSum++;
                    }
                    else if (board[y][x] == "o")
                    {
                        colSum--;
                    }
                }
                if (colSum == 3)
                {
                    playing = false;
                    winner = "x";

                }
                else if (colSum == -3)
                {
                    playing = false;
                    winner = "y";
                }
            }

            //check both diagonals
            if (board[0][0] == "x" && board[1][1] == "x" && board[2][2] == "x")
            {
                playing = false;
                winner = "x";
            }
            else if (board[0][0] == "o" && board[1][1] == "o" && board[2][2] == "o")
            {
                playing = false;
                winner = "x";
            }
            else if (board[2][0] == "x" && board[1][1] == "x" && board[0][2] == "x")
            {
                playing = false;
                winner = "x";
            }
            else if (board[2][0] == "o" && board[1][1] == "o" && board[0][2] == "o")
            {
                playing = false;
                winner = "x";
            }

            //check for a tie game(in this case, none of the above will return true, but the board will be full.
            int playSum = 0;
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[0].Length; j++)
                {
                    if(board[i][j] != " ")
                    {
                        playSum++;
                    }
                }
            }
            if(playSum == 9)
            {
                playing = false;
                winner = "tie";
            }
        }
    }
}
