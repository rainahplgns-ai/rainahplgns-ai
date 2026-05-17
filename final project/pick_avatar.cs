using System;
using System.Drawing;
using System.IO; // Idinagdag para sa Path at File handling
using System.Windows.Forms;

namespace final_project
{
    public partial class pick_avatar : Form
    {
        MainForm orihinalNaMainForm;
        string selectedAvatarImage = "";
        
        // Constructor na tumatanggap ng MainForm mula sa loading screen
        public pick_avatar(MainForm galingSaMainForm)
        {
            InitializeComponent();
            orihinalNaMainForm = galingSaMainForm;
            
            // Itago muna ang panel5 sa simula
            panel5.Visible = false; 
        }
        
        // Back Button (PictureBox5) - Inayos para sa mas magandang user experience
        void PictureBox5Click(object sender, EventArgs e)
        {
            // Kung nakabukas ang panel5, itatago lang muna ito at ibabalik ang mga pilian ng avatar
            if (panel5.Visible)
            {
                panel5.Visible = false;
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
            }
            // Kung nasa pilian pa lang ng avatar, doon pa lang tuluyang babalik sa MainForm
            else
            {
                if (orihinalNaMainForm != null)
                {
                    orihinalNaMainForm.Show();
                }
                this.Close();
            }
        }
        
        // Pili ng Avatar 1 (TJ)
        void Panel1Click(object sender, EventArgs e)
        {
            SetupPanel5("tj_ava.png");
        }
        
        // Pili ng Avatar 2 (Rai)
        void Panel2Click(object sender, EventArgs e)
        {
            SetupPanel5("rai_ava.png");
        }
        
        // Pili ng Avatar 3 (Cy)
        void Panel3Click(object sender, EventArgs e)
        {
            SetupPanel5("cy_ava.png");
        }
        
        // Pili ng Avatar 4 (Mae)
        void Panel4Click(object sender, EventArgs e)
        {
            SetupPanel5("mae_ava.png");
        }

        // Method para i-setup ang mga laman ng panel5 at ipagitna ito
        private void SetupPanel5(string imageName)
        {
            selectedAvatarImage = imageName;
            
            // INAYOS: Kailangang ipakita ang panel5 at itago ang ibang panels para lumitaw ang input screen!
            panel5.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            
            pic_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // Hahanapin ang folder na #0 nang hindi mo kailangang ilipat ang mga file
            string projectFolder = System.IO.Path.Combine(Application.StartupPath, @"..\..\#0");
            string fullPath = System.IO.Path.Combine(projectFolder, imageName);
            
            if (File.Exists(fullPath))
            {
                pic_avatar.Image = Image.FromFile(fullPath); 
            }
            else
            {
                MessageBox.Show("Hindi mahanap ang larawan sa: " + fullPath);
            }
            
            label1.Visible = false;
        }


        // Click event para sa iyong save_input (Save Button)
        void Save_inputClick(object sender, EventArgs e)
        {
            // Kukunin ang text mula sa iyong 'players_name' textbox
            
            string playerNamit = players_name.Text;

			if (string.IsNullOrEmpty(playerNamit.Trim()))
			{
			    label2.Text = "Please enter your name so that we know what to call you:)";
			    label2.ForeColor = Color.Red; 
			    label2.Visible = true;        
			    return;
			}
			
			label2.Text = "Welcome!";
			
			profileData.PlayerName = playerNamit;
			profileData.AvatarPath = selectedAvatarImage;
			
			Games g = new Games(orihinalNaMainForm);
			g.Show();
			
			this.Close();
			
        }
    } 
}