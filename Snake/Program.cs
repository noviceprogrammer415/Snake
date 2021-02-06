﻿using System;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			var upLine = new HorizontalLine(0, 78, 0, '+');
			var downLine = new HorizontalLine(0, 78, 24, '+');
			var leftLine = new VerticalLine(0, 24, 0, '+');
			var rightLine = new VerticalLine(0, 24, 78, '+');
			upLine.Draw();
			downLine.Draw();
			leftLine.Draw();
			rightLine.Draw();

			var point = new Point(4, 5, '*');
			var snake = new Snake(point, 4, Direction.RIGHT);
			snake.Draw();

			Console.ReadLine();
		}
	}
}
