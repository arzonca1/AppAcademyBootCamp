using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Ship
    {
        public int length;
        public bool vertical;
        public bool alive;
        int hits;

        public Ship(int len, bool vert)
        {
            length = len;
            alive = true;
            vertical = vert;
            hits = 0;
        }

        public void hit()
        {
            hits++;
            if (hits >= length) alive = false;
        }

    }


    class Square
    {
        public bool playerBoard;
        public bool containsShip;
        public bool hit;
        public Ship shipPresent; //if any, null otherwise


        public Square(bool pb)
        {
            playerBoard = pb;
            containsShip = false;
            hit = false;
            shipPresent = null;
        }
        public bool fireAt()
        {
            hit = true;
            if (shipPresent != null)
            {
                shipPresent.hit();
                return true;
            }
            return false;
        }
        public ConsoleColor getStateColor()
        {
            if (playerBoard && containsShip && !hit) return ConsoleColor.Green;
            if (!containsShip && hit) return ConsoleColor.Gray;
            if (containsShip && hit) return ConsoleColor.Red;
            return ConsoleColor.Blue;
        }

        public void addShip(Ship s)
        {
            containsShip = true;
            shipPresent = s;
        }
    }


    class Board
    {
        Ship[] fleet;
        Square[,] grid;
        bool playerBoard;

        public Board(bool pb)
        {
            playerBoard = pb;
            grid = new Square[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++) grid[i, j] = new Square(pb);
            }


        }




        public void draw()
        {
            Console.WriteLine();
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
            for (int a = 0; a < 10; a++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{(char)(a + 'A')} ");
                for (int b = 0; b < 10; b++)
                {
                    Console.ForegroundColor = grid[a, b].getStateColor();
                    Console.Write("██");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void autoPopulate()
        {
            fleet = new Ship[7];
            Random rn = new Random();
            int[] sizes = { 5, 4, 3, 2, 2, 1, 1 };
            for (int i = 0; i < fleet.Length; i++)
            {
                fleet[i] = new Ship(sizes[i], rn.Next(1, 100) <= 50);
            }
            for (int i = 0; i < fleet.Length; i++)

            {
                int shortPosition;
                int longPosition;
                while (true)
                {
                    fleet[i].vertical = rn.Next(1, 100) <= 50;
                    shortPosition = rn.Next(0, 10);
                    longPosition = rn.Next(0, 11 - fleet[i].length);
                    if (!testOverlap(fleet[i], shortPosition, longPosition)) continue;
                    addShip(fleet[i], shortPosition, longPosition);
                    break;

                }
            }
        }

        public Square getSquare(int x, int y)
        {
            return grid[y, x];
        }



        private bool testOverlap(Ship ship, int sr, int lr)
        {
            if (ship.vertical)
            {
                for (int i = lr; i < lr + ship.length; i++)
                {
                    if (grid[i, sr].containsShip) return false;
                }
            }
            if (!ship.vertical)
            {
                for (int i = lr; i < lr + ship.length; i++)
                {
                    if (grid[sr, i].containsShip) return false;
                }
            }
            return true;
        }

        private void addShip(Ship s, int sr, int lr)
        {
            if (s.vertical) for (int i = lr; i < lr + s.length; i++) grid[i, sr].addShip(s);

            else for (int i = lr; i < lr + s.length; i++) grid[sr, i].addShip(s);
        }

        public bool hit(int x, int y)
        {
            return grid[y, x].fireAt();
        }

        public bool isFleetAlive()
        {
            foreach (Ship ship in fleet) if (ship.alive) return true;
            return false;
        }

        public void manualPopulate()
        {
            fleet = new Ship[7];
            int[] sizes = { 5, 4, 3, 2, 2, 1, 1 };
            for (int i = 0; i < fleet.Length; i++)
            {
                char input = Console.ReadKey().KeyChar;
                while (true)
                {

                }
            }

                }
            }


    class GameAI
    {

        bool randomSearch;
        Board targetBoard;
        int direction; //top, right, down, left ... 
        int x, y;
        int atteptsAroundPoint; 


        public GameAI(Board playerBoard)
        {
            randomSearch = true;
            targetBoard = playerBoard;
            int direction = 0;
        }

        public void play()
        {
            Random rn = new Random();
            if (randomSearch)
            {
                while (true)
                {
                    x = rn.Next(0, 10);
                    y = rn.Next(0,10);
                    if(targetBoard.getSquare(x,y).getStateColor() == ConsoleColor.Green ||
                        (targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Blue))
                    {
                        targetBoard.hit(x, y);
                        randomSearch = false;
                        return;
                    }

                }
            }
            else
            {
                switch (direction % 4)
                {
                    case 0: //up
                        while (true) { 
                            if (y == 0 || targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Gray) direction++;
                            else if (targetBoard.getSquare(x,y).getStateColor() == ConsoleColor.Blue || 
                                targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Green)
                            {
                                targetBoard.hit(x, y);
                                return;
                            }
                            else if (targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Red) y--;
                        }
                        break;
                    case 1: //right
                        while (true)
                        {
                            if (x == 0 || targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Gray) direction++;
                            else if (targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Blue ||
                                targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Green)
                            {
                                targetBoard.hit(x, y);
                                return;
                            }
                            else if (targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Red) x++;
                        }
                        break;
                    case 2: //down
                        while (true)
                        {
                            if (y == 9 || targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Gray) direction++;
                            else if (targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Blue ||
                                targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Green)
                            {
                                targetBoard.hit(x, y);
                                return;
                            }
                            else if (targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Red) y++;
                        }
                        break;
                    case 3:
                        while (true)
                        {
                            if (x == 0 || targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Gray)
                            {
                                direction = 0;
                                randomSearch = true;
                                break;
                            }
                            else if (targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Blue ||
                                targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Green)
                            {
                                targetBoard.hit(x, y);
                                return;
                            }
                            else if (targetBoard.getSquare(x, y).getStateColor() == ConsoleColor.Red) x--;
                        }
                        break;
                }
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Please pick a game mode:\n1. 25 random guesses.\n2. VS AI\n3.Load game.");
            char input = '\0';
            while (input > '2' || input < '1') input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '1':
                    Game1();
                    break;
                case '2':
                    Game2();
                    break;
            }


        }

        static void Game1()
        {
            int wronggusses = 0;
            Board enemyBoard = new Board(false);
            enemyBoard.autoPopulate();
            while (true)
            {
                Console.Clear();
                Console.Write($"Guesses remaining: {25 - wronggusses}");
                enemyBoard.draw();
                string input;
                while (true)
                {
                    input = Console.ReadLine();
                    if (input.Length < 2) continue;
                    char yaxis;
                    int xaxis;
                    if (char.ToUpper(input[0]) < 'A' || char.ToUpper(input[0]) > 'J') continue;
                    yaxis = input[0];
                    try
                    {
                        xaxis = int.Parse(input.Substring(1));
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                    if (xaxis > 10) continue;
                    if (enemyBoard.getSquare(xaxis - 1, char.ToUpper(yaxis) - 'A').getStateColor() != ConsoleColor.Blue) continue;
                    if (!enemyBoard.hit(xaxis - 1, char.ToUpper(yaxis) - 'A')) wronggusses++;
                    break;
                }
                if (wronggusses > 250000)
                {
                    Console.WriteLine("You lose");
                    break;
                }
                if (!enemyBoard.isFleetAlive())
                {
                    Console.WriteLine("You win!");
                    break;
                }
            }
            Console.ReadKey();
        }

        static void Game2()
        {
            Board enemyBoard = new Board(false);
            enemyBoard.autoPopulate();
            Board playerBoard = new Board(true);
            playerBoard.autoPopulate();
            while (true)
            {
                enemyBoard.draw();
                Console.Write("\n\n\n");
                playerBoard.draw();
                Console.ReadKey();
            }
        }
        //            if (newGame) playerBoard.playerPopulate(); 
    }
}



