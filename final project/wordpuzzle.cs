/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 4/28/2026
 * Time: 4:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_project
{
	/// <summary>
	/// Description of wordpuzzle.
	/// </summary>
	public partial class wordpuzzle : Form
	{
		public wordpuzzle()
		{
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Art1Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage1;
			
		}
		
		void Art2Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage2;
		}
		
		
		void TextBox1Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage3;
		}
		
		void TextBox21Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage7;
		}
		
		void TextBox33Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage5;
		}
		
		void TextBox9Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage4;
		}
		
		void TextBox24Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabPage6;
		}
		
		void PictureBox5Click(object sender, EventArgs e)
		{
			game1 g1 = new game1();
			g1.Show();
			this.Hide();
		}
	}
}
