using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Board
    {

        int Height = 25;
        int Width = 75;
        List<Obstacles> Obstacles = new List<Obstacles>();

        public void DrawBoard()
        {
            Console.Clear();
            for (int i = 1; i<=(Width+2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("=");
            }
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, (Height +2));
                Console.Write("=");
            }
            for (int i = 1; i <= (Height + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("-");
            }
            for (int i = 1; i <= (Height + 1); i++)
            {
                Console.SetCursorPosition((Width+2), i);
                Console.Write("-");
            }
            
        }
        



    }
}
