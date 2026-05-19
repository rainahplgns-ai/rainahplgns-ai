using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace final_project
{
    public partial class MainForm : Form
    {
        int progress = 0;
        
        SoundPlayer player = new SoundPlayer(@"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\bgmusic.wav");

        public MainForm()
        {
            InitializeComponent();
            player.PlayLooping();
            StartLoading();
        }

        private void StartLoading()
        {
            progress = 0;
            timer1.Interval = 50;
            timer1.Start();
            
            panel1.Visible = false;
            progressBar1.Visible = true;
        }
        
        void Timer1Tick(object sender, EventArgs e)
        {
            progress += 2;
            if (progress > 100) progress = 100;

            progressBar1.Value = progress;

            if (progress == 100)
            {
                timer1.Stop();
                progressBar1.Visible = false;
                
                panel1.Visible = true;
            }
        }
                
        void Panel1Click(object sender, EventArgs e)
        {
        	Games g = new Games();
            g.Show();
            this.Hide();
        }
    }
}
