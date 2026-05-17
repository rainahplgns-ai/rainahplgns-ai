using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_project
{
    public partial class profile : Form
    {
        // Lalagyan ng reference kung saang Form galing ang player (hal. Games.cs)
        private Form pinanggalingangForm;

        public profile()
        {
            InitializeComponent();
        }

        // Gagamitin natin itong constructor para makabalik sa Games.cs mamaya
        public profile(Form galingSaForm)
        {
            InitializeComponent();
            pinanggalingangForm = galingSaForm;
        }

        // Awtomatikong tatakbo ito kapag nag-load ang iyong Profile Screen
        void ProfileLoad(object sender, EventArgs e)
        {
            // 1. Idispley ang pangalan sa iyong label na pinangalanang 'name'
            name.Text = profileData.PlayerName;

            // 2. Idispley ang larawan sa iyong panel na pinangalanang 'avatar'
            if (!string.IsNullOrEmpty(profileData.AvatarPath))
            {
                // Ilalagay ang napiling pic (tj.png, rai.png, atbp.) bilang Background Image ng panel
                avatar.BackgroundImage = Image.FromFile(profileData.AvatarPath);
                
                // Sinisigurong sakto at hindi nayuyupi ang sukat ng larawan sa loob ng panel
                avatar.BackgroundImageLayout = ImageLayout.Stretch; 
            }
        }

		
		void PictureBox5Click(object sender, EventArgs e)
		{
			 if (pinanggalingangForm != null)
            {
                pinanggalingangForm.Show(); // Ipakita ulit ang Games screen
            }
            this.Close(); // Isara ang profile screen na ito
		}
		
		void Pic_avatarClick(object sender, EventArgs e)
		{
			
		}
		
		void Panel5Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Panel3Click(object sender, EventArgs e)
		{
			about_frame.Visible = true;

			about_frame.Location = new Point(
			(this.ClientSize.Width - about_frame.Width) / 2,
			(this.ClientSize.Height - about_frame.Height) / 2
			);
			
			credits_frame.Visible = false;
			profile_frame.Visible = false;
			settings_frame.Visible = false;
		}
		
		void Panel4Click(object sender, EventArgs e)
		{
			credits_frame.Visible = true;

			credits_frame.Location = new Point(
			(this.ClientSize.Width - credits_frame.Width) / 2,
			(this.ClientSize.Height - credits_frame.Height) / 2
			);
			
			about_frame.Visible = false;
			profile_frame.Visible = false;
			settings_frame.Visible = false;
		}
    }
}
