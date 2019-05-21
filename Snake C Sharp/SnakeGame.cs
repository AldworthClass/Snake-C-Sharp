﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://www.techotopia.com/index.php/Using_Bitmaps_for_Persistent_Graphics_in_C_Sharp

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
            snakeWindow = this.CreateGraphics();
            this.ClientSize = new Size(600, 600);//Sets size of game window
			snakeWindow = this.CreateGraphics();
            snake = new Snake(snakeWindow, new Point(20, 20), new Size(40, 40), new Size(15, 15));
            snake.grow();
            snake.grow();
        }

        private void SnakeGame_Paint(object sender, PaintEventArgs e)
		{
            snakeWindow.Clear(Color.Black);
            snake.draw();
            
        }

		private void GameLoop_Tick(object sender, EventArgs e)
		{
            snake.move();
            this.Invalidate();
		}

        private void SnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                snake.directionRight();
            else if (e.KeyCode == Keys.A)
                snake.directionLeft();
            else if (e.KeyCode == Keys.W)
                snake.directionUp();
            else if (e.KeyCode == Keys.S)
                snake.directionDown();
        }
    }
}
