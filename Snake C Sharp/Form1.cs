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
		public SnakeGame()
		{
			InitializeComponent();
		}

		private void SnakeGame_Load(object sender, EventArgs e)
		{
			this.ClientSize = new Size(600, 600);
			
		}
	}
}
