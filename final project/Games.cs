using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_project
{
    public partial class Games : Form
    {
        MainForm orihinalNaMainForm;

        public Games()
        {
            InitializeComponent();
        }

        public Games(MainForm galingSaMainForm)
        {
            InitializeComponent();
            orihinalNaMainForm = galingSaMainForm;
            
            settings_frame.Visible = false;
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
            game4 g4 = new game4();
            g4.Show();
            this.Hide();
        }
        
        // Babalik sa MainForm nang hindi naglo-load ulit ang Progress Bar
        void PictureBox5Click(object sender, EventArgs e)
        {
            if (orihinalNaMainForm != null)
            {
                orihinalNaMainForm.Show();
            }
            this.Close();
        }
		

		
		void Panel1Click(object sender, EventArgs e)
		{
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			panel1.Visible = false;
			panel2.Visible = false;
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
			panel2.Visible = true;
		}
    }
}
