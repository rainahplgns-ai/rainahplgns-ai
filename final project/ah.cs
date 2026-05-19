using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace final_project
{
	public partial class ah : Form
	{
		private Cursor customWrongCursor;
		public ah()
		{
			InitializeComponent();
			LoadCustomCursor();
			group_trivia.Visible = false;
			
			this.MouseDown += new MouseEventHandler(AhMouseDown);
			this.MouseUp += new MouseEventHandler(AhMouseUp);
			
		}
		
		private void LoadCustomCursor()
		{
			try 
			{
				string cursorPath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\wrong.cur";
		
				if (File.Exists(cursorPath))
				{
					using (Bitmap originalBmp = new Bitmap(cursorPath))
					{

						int targetWidth = 60;
						int targetHeight = 60;
		
						using (Bitmap resizedBmp = new Bitmap(originalBmp, targetWidth, targetHeight))
						{
							customWrongCursor = new Cursor(resizedBmp.GetHicon());
						}
					}
				}
				else
				{
					customWrongCursor = Cursors.No; 
				}
			}
			catch
			{
				customWrongCursor = Cursors.No;
			}
		}

				
		void AhMouseDown(object sender, MouseEventArgs e)
		{
			if (customWrongCursor != null)
			{
				this.Cursor = customWrongCursor;
			}
		}
		
		void AhMouseUp(object sender, MouseEventArgs e)
		{
			this.Cursor = Cursors.Default;
		}
		
		void StarrynightClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_starrynight.Checked = !check_starrynight.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found The Starry Night by Vincent van Gogh";
			trivia.Text = "One of the most recognized paintings in the world. Created during a period of intense personal turmoil, it is a masterpiece filled with scientific anomalies, hidden meanings, and bittersweet ironies.";
		}

		
		void WaveClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_wave.Checked = !check_wave.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found The Great Wave off Kanagawa by Katsushika Hokusai!";
			trivia.Text = "The most famous image in Japanese art history. While it looks like a timeless, tranquil masterpiece, its creation is packed with historical drama, hidden visual optical illusions, and a bit of rock-star chaos from its eccentric creator.";
		}
		
		void MotherClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_mother.Checked = !check_mother.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found Migrant Mother by Dorothea Lange (1936)!";
			trivia.Text = "The most iconic photographs in American history. It became the definitive face of the Great Depression, but the story behind the shutter is full of controversy, hidden details, and historical drama.";
		}	
		
		
		void ManClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_man.Checked = !check_man.Checked;
		
			group_trivia.Visible = true;
			label1.Text = "You found The Vitruvian Man by Leonardo da Vinci!";
			trivia.Text = "One of the most famous pen-and-ink drawings in human history. While it looks like a simple study of human anatomy, it is actually a deeply philosophical blueprint that blends art, geometry, and cosmic architecture.";
		}	
		

		void TowerClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			eiffel.Checked = !eiffel.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found The Eiffel Tower (La Tour Eiffel) by Gustave Eiff!";
			trivia.Text = "The ultimate symbol of France. While it is celebrated as a romantic masterpiece today, its history is full of fierce protests, military secrets, and bizarre historical events.";
		
		}
		
		void GirlClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			balloon.Checked = !balloon.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found The Girl with Balloon!";
			trivia.Text = "Also known as 'Balloon Girl' is a legendary series of stencil murals created by the anonymous England-based street artist Banksy, which first appeared on the streets of London in 2002.";
		
		}
		
		void ChaosClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			abode.Checked = !abode.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found Pierre Bourdieu at The Abode of Chaos!";
			trivia.Text = "This mural depicts Pierre Bourdieu, one of France's most influential sociologists and philosophers. His portrait is painted on the walls of The Abode of Chaos, a dystopian open-air museum near Lyon that critiques power, societal structures, and political control.";
	
		}
		
		void ParachuteClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_cute.Checked = !check_cute.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found The Parachute!";
			trivia.Text = "Infact, This is just a normal parachute.";
		}
		
		void No5Click(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_5.Checked = !check_5.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found Beethoven's Symphony No. 5!";
			trivia.Text = "Beethoven was notoriously slow and meticulous when working on his compositions. He made the first notes for the symphony in his sketchbook around 1803 but didn’t officially finish the piece until 1808.";
	
		}
		
		void RavenClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_raven.Checked = !check_raven.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found The Raven!";
			trivia.Text = "Ravens have a great sense of humor and love to play. They frequently slide down snowy roofs on their backs just for fun. They also play a game called 'tail-biting,' sneaking up behind large dogs or eagles to pinch their tails just to tease them.";
		}
		
		void EggClick(object sender, EventArgs e)
		{
			Panel clickedPanel = (Panel)sender;
			string imagePath = @"C:\Users\pc\Documents\SharpDevelop Projects\MOPB Stardust\final project\#0\correct.png";
			clickedPanel.BackgroundImage = Image.FromFile(imagePath);
			check_egg.Checked = !check_egg.Checked;
			
			group_trivia.Visible = true;
			label1.Text = "You found The Intricate Faberge Egg!";
			trivia.Text = "The eggs were made with luxurious materials like gold, diamonds pearls enamel and gemstones.";
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			group_trivia.Visible = false;
		}
		
		
		
		void AhLoad(object sender, EventArgs e)
		{
			
		}
		
		
	}
}