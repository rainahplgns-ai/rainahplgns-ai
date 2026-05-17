/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 5/15/2026
 * Time: 10:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final_project
{
	partial class guessnsave
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guessnsave));
			this.profile_icon = new System.Windows.Forms.Panel();
			this.settings_icon = new System.Windows.Forms.Panel();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// profile_icon
			// 
			this.profile_icon.BackColor = System.Drawing.Color.Transparent;
			this.profile_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_icon.BackgroundImage")));
			this.profile_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.profile_icon.Location = new System.Drawing.Point(780, 27);
			this.profile_icon.Name = "profile_icon";
			this.profile_icon.Size = new System.Drawing.Size(61, 61);
			this.profile_icon.TabIndex = 70;
			// 
			// settings_icon
			// 
			this.settings_icon.BackColor = System.Drawing.Color.Transparent;
			this.settings_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings_icon.BackgroundImage")));
			this.settings_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.settings_icon.Location = new System.Drawing.Point(841, 27);
			this.settings_icon.Name = "settings_icon";
			this.settings_icon.Size = new System.Drawing.Size(61, 61);
			this.settings_icon.TabIndex = 69;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox5.Location = new System.Drawing.Point(31, 25);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(131, 54);
			this.pictureBox5.TabIndex = 68;
			this.pictureBox5.TabStop = false;
			// 
			// guessnsave
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(934, 511);
			this.Controls.Add(this.profile_icon);
			this.Controls.Add(this.settings_icon);
			this.Controls.Add(this.pictureBox5);
			this.Name = "guessnsave";
			this.Text = "guessnsave";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Panel settings_icon;
		private System.Windows.Forms.Panel profile_icon;
	}
}
