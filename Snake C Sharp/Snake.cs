using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_C_Sharp
{
	
	class Snake
	{
		private Graphics snakeWindow;	//Drawing surface
		private List<Point> snake;		//Snake tiles
		private int width;				//width of snake tile
		private int height;				//height of snake tile
		private Size boardSize;			//board size
		private String direction;

		public Snake(Graphics board, Point start, Size boardSize, Size snakeSize)
		{
			direction = "u";
			snake = new List<Point>();
			this.boardSize = boardSize;
			width = snakeSize.Width;
			height = snakeSize.Height;
			snakeWindow = board;
			snake.Add(start);
		}
		public void grow()
		{
			if (direction == "u")
				snake.Add(new Point(snake[snake.Count - 1].X, snake[snake.Count - 1].Y + 1));
			else if (direction == "d")
				snake.Add(new Point(snake[snake.Count - 1].X, snake[snake.Count - 1].Y - 1));
			else if (direction == "l")
				snake.Add(new Point(snake[snake.Count - 1].X + 1, snake[snake.Count - 1].Y));
			else
				snake.Add(new Point(snake[snake.Count - 1].X - 1, snake[snake.Count - 1].Y));
		}
		public void move()
		{
			//Starts with last item
			for(int i = snake.Count - 1; i >=0; i--)
			{
				if (i > 0)
					snake[i] = snake[i - 1];
				else
					if (direction == "u")
						snake[0] = (new Point(snake[0].X, snake[0].Y - 1));
					else if (direction == "d")
						snake[0]=(new Point(snake[0].X, snake[0].Y + 1));
					else if (direction == "l")
						snake[0]=(new Point(snake[0].X - 1, snake[0].Y));
					else
						snake[0]=(new Point(snake[0].X + 1, snake[0].Y));

			}

		}

		public void draw()
		{
			SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
			for (int i = 0; i < snake.Count; i++)
				snakeWindow.FillEllipse(myBrush, new Rectangle(snake[i].X * width, snake[i].Y * height, width, height));
		}

		public void directionUp()
		{
			direction = "u";
		}
		public void directionDown()
		{
			direction = "d";
		}
		public void directionLeft()
		{
			direction = "l";
		}
		public void directionRight()
		{
			direction = "r";
		}
	}
}
