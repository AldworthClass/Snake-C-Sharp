using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_C_Sharp
{
	public partial class SnakeGame : Form
	{
		Graphics snakeWindow;
		Snake snake;

		public SnakeGame()
		{
			InitializeComponent();
		}

		private void SnakeGame_Load(object sender, EventArgs e)
		{
			this.ClientSize = new Size(600, 600);
			snakeWindow = this.CreateGraphics();
			snake = new Snake(snakeWindow, new Point(20, 20), new Size(40, 40), new Size(15, 15));

			
		}

		private void SnakeGame_Paint(object sender, PaintEventArgs e)
		{
			
			Rectangle myRectangle;
			SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
			
			//Paints the grid background
			for (int i = 0; i < 40; i++)
				for (int j = 0; j < 40; j++)
				{
					myRectangle = new Rectangle(i * 15, j * 15, 14, 14);
					snakeWindow.FillRectangle(myBrush, myRectangle);
				}
			snake.draw();
					
			
			//Pen myPen = new Pen(System.Drawing.Color.Red, 0);
			
		}

		private void GameLoop_Tick(object sender, EventArgs e)
		{
			snake.move();
			this.Refresh();
		}
	}
}
