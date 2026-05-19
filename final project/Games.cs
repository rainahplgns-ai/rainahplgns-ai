using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_project
{
    public partial class Games : Form
    {

        public Games()
        {
            InitializeComponent();
        	credits_frame.Visible = false;
            settings_frame.Visible = false;
            about_frame.Visible = false;

            
        }

        void PictureBox1Click(object sender, EventArgs e)
        {
            game1 g1 = new game1();
            g1.Show();
            this.Hide();
        }
        
        void PictureBox2Click(object sender, EventArgs e)
        {
            game2 g2 = new game2();
            g2.Show();
            this.Hide();
        }
        
        void PictureBox3Click(object sender, EventArgs e)
        {
            game3 g3 = new game3();
            g3.Show();
            this.Hide();
        }
        
        void PictureBox4Click(object sender, EventArgs e)
        {
            game3 g3 = new game3();
            g3.Show();
            this.Hide();
        }
        
        void PictureBox5Click(object sender, EventArgs e)
        {
        	MainForm mf = new MainForm();
        	mf.Show();
        	this.Hide();
        }
		

		
		void Panel1Click(object sender, EventArgs e)
		{
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			panel1.Visible = false;
			settings_frame.Visible = true;
		}
		
		void Panel6Click(object sender, EventArgs e)
		{
			settings_frame.Visible = false;
			pictureBox1.Visible = true;
			pictureBox2.Visible = true;
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox5.Visible = true;
			panel1.Visible = true;
		}
		
		void Panel4Click(object sender, EventArgs e)
		{
			credits_frame.Visible = true;
		}
		
		void PictureBox6Click(object sender, EventArgs e)
		{
			about_frame.Visible = false;
		}
		
		void Panel3Click(object sender, EventArgs e)
		{
			about_frame.Visible = true;
			
			settings_frame.Visible = false;
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			panel1.Visible = false;
		}
    }
}
