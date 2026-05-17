using System;
using System.Drawing;
using System.Windows.Forms;

namespace final_project
{
	public partial class ah : Form
	{
		public ah()
		{
			InitializeComponent();
			
		}
		
		void StarrynightClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_starrynight.Checked = !check_starrynight.Checked;
		}
		
		void Check_starrynightCheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
