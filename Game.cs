using System;

namespace ConsoleGame
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(string keyPressed, out int x, out int y)
        {
            x = 0;
            y = 0;
            switch (keyPressed)
            {
                case "LeftArrow":
                case "A":
                    x--;
                    break;

                case "RightArrow":
                case "D":
                    x++;
                    break;

                case "UpArrow":
                case "W":
                    y--;
                    break;

                case "DownArrow":
                case "S":
                    y++;
                    break;

                default:
                    break;
            }
        }

        public new static char UpdateCursor(string keyPressed)
        {
            char symbol = ' ';

            switch (keyPressed)
            {
                case "LeftArrow":
                case "A":
                    symbol = '<';
                    break;

                case "RightArrow":
                case "D":
                    symbol = '>';
                    break;

                case "UpArrow":
                case "W":
                    symbol = '^';
                    break;

                case "DownArrow":
                case "S":
                    symbol = 'v';
                    break;

                default:
                    break;
            }
            return symbol;
        }

        public new static int KeepInBounds(int first, int second)
        {
            if (first < 0)
            {
                return second - 1;
            }
            else if (first >= second)
            {
                return 1;
            }
            else
            {
                return first;
            }
        }

        public new static bool DidScore(int x, int y, int xF, int yF)
        {
            if (x == xF && y == yF)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}