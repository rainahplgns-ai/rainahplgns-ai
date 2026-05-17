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
        
        private bool isLoaded = false;

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
            label1.Visible = true;
        }
        
        void Timer1Tick(object sender, EventArgs e)
        {
            progress += 2;
            if (progress > 100) progress = 100;

            progressBar1.Value = progress;
            label1.Text = progress + "%";

            if (progress == 100)
            {
                timer1.Stop();
                label1.Visible = false;
                progressBar1.Visible = false;
                
                panel1.Visible = true;
                isLoaded = true;
            }
        }
                
        void Panel1Click(object sender, EventArgs e)
        {
            pick_avatar pa = new pick_avatar(this);
            pa.Show();
            this.Hide();
        }
        
        void Panel2Click(object sender, EventArgs e)
        {
            profile pf = new profile();
            pf.Show();
            this.Hide();
        }
        
        void Panel3Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResetForm()
        {
            if (!isLoaded)
            {
                StartLoading();
            }
        }
    }
}
