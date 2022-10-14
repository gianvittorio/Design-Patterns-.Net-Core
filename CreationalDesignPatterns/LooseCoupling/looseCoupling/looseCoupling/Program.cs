﻿using System;

namespace looseCoupling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.PlayArea(1);

            Console.ReadKey();
        }
    }
}