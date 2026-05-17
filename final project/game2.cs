using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_project
{
	public partial class game2 : Form
	{
		public game2()
		{
			InitializeComponent();
			game1_ins.Visible = false;			

		}
		
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			game1_ins.Visible = true;
			pictureBox5.Visible = false;
			pictureBox1.Visible = false;
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			Games games = new Games();
			games.Show();
			this.Hide();
		}
		
		void Panel3Click(object sender, EventArgs e)
		{
			picturepalette pp = new picturepalette();
			pp.Show();
			this.Hide();
		}
		
		void Panel4Click(object sender, EventArgs e)
		{
			game1_ins.Visible = false;
			pictureBox5.Visible = true;
			pictureBox1.Visible = true;
		}
		
		void Game2Load(object sender, EventArgs e)
		{
			
		}
	}
}
