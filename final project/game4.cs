/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 4/30/2026
 * Time: 12:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_project
{
	/// <summary>
	/// Description of game4.
	/// </summary>
	public partial class game4 : Form
	{
		public game4()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
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
			ah a = new ah();
			a.Show();
			this.Hide();
		}
		
		void Panel4Click(object sender, EventArgs e)
		{
			game1_ins.Visible = false;
			pictureBox5.Visible = true;
			pictureBox1.Visible = true;
		}
	}
}
