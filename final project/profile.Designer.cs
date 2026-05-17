/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 5/16/2026
 * Time: 10:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final_project
{
	partial class profile
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
			this.settings_frame = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.profile_frame = new System.Windows.Forms.Panel();
			this.name = new System.Windows.Forms.Label();
			this.avatar = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.about_frame = new System.Windows.Forms.Panel();
			this.credits_frame = new System.Windows.Forms.Panel();
			this.settings_frame.SuspendLayout();
			this.profile_frame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// settings_frame
			// 
			this.settings_frame.BackColor = System.Drawing.Color.Transparent;
			this.settings_frame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings_frame.BackgroundImage")));
			this.settings_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.settings_frame.Controls.Add(this.panel5);
			this.settings_frame.Controls.Add(this.panel4);
			this.settings_frame.Controls.Add(this.panel3);
			this.settings_frame.Controls.Add(this.panel2);
			this.settings_frame.Location = new System.Drawing.Point(124, 83);
			this.settings_frame.Name = "settings_frame";
			this.settings_frame.Size = new System.Drawing.Size(624, 433);
			this.settings_frame.TabIndex = 14;
			// 
			// panel5
			// 
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel5.Location = new System.Drawing.Point(199, 296);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(226, 56);
			this.panel5.TabIndex = 2;
			this.panel5.Click += new System.EventHandler(this.Panel5Click);
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.Location = new System.Drawing.Point(199, 231);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(226, 56);
			this.panel4.TabIndex = 2;
			this.panel4.Click += new System.EventHandler(this.Panel4Click);
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Location = new System.Drawing.Point(199, 166);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(226, 56);
			this.panel3.TabIndex = 1;
			this.panel3.Click += new System.EventHandler(this.Panel3Click);
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Location = new System.Drawing.Point(199, 101);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(226, 56);
			this.panel2.TabIndex = 0;
			// 
			// profile_frame
			// 
			this.profile_frame.AutoSize = true;
			this.profile_frame.BackColor = System.Drawing.Color.Transparent;
			this.profile_frame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profile_frame.BackgroundImage")));
			this.profile_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.profile_frame.Controls.Add(this.name);
			this.profile_frame.Controls.Add(this.avatar);
			this.profile_frame.Location = new System.Drawing.Point(272, 60);
			this.profile_frame.Name = "profile_frame";
			this.profile_frame.Size = new System.Drawing.Size(329, 453);
			this.profile_frame.TabIndex = 12;
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.BackColor = System.Drawing.Color.Transparent;
			this.name.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name.ForeColor = System.Drawing.Color.White;
			this.name.Location = new System.Drawing.Point(112, 364);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(104, 36);
			this.name.TabIndex = 5;
			this.name.Text = "Name";
			this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// avatar
			// 
			this.avatar.BackColor = System.Drawing.Color.Transparent;
			this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.avatar.Location = new System.Drawing.Point(20, 108);
			this.avatar.Name = "avatar";
			this.avatar.Size = new System.Drawing.Size(289, 247);
			this.avatar.TabIndex = 2;
			this.avatar.TabStop = false;
			this.avatar.Click += new System.EventHandler(this.Pic_avatarClick);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox5.Location = new System.Drawing.Point(28, 23);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(131, 54);
			this.pictureBox5.TabIndex = 11;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.PictureBox5Click);
			// 
			// about_frame
			// 
			this.about_frame.BackColor = System.Drawing.Color.Transparent;
			this.about_frame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about_frame.BackgroundImage")));
			this.about_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.about_frame.Location = new System.Drawing.Point(19, 31);
			this.about_frame.Name = "about_frame";
			this.about_frame.Size = new System.Drawing.Size(850, 500);
			this.about_frame.TabIndex = 17;
			// 
			// credits_frame
			// 
			this.credits_frame.BackColor = System.Drawing.Color.Transparent;
			this.credits_frame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("credits_frame.BackgroundImage")));
			this.credits_frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.credits_frame.Location = new System.Drawing.Point(11, 16);
			this.credits_frame.Name = "credits_frame";
			this.credits_frame.Size = new System.Drawing.Size(850, 500);
			this.credits_frame.TabIndex = 16;
			// 
			// profile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(873, 546);
			this.Controls.Add(this.credits_frame);
			this.Controls.Add(this.profile_frame);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.settings_frame);
			this.Controls.Add(this.about_frame);
			this.Name = "profile";
			this.Text = "profile";
			this.Load += new System.EventHandler(this.ProfileLoad);
			this.settings_frame.ResumeLayout(false);
			this.profile_frame.ResumeLayout(false);
			this.profile_frame.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Panel about_frame;
		public System.Windows.Forms.Panel credits_frame;
		public System.Windows.Forms.PictureBox avatar;
		public System.Windows.Forms.Label name;
		public System.Windows.Forms.Panel profile_frame;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.Panel settings_frame;
		public System.Windows.Forms.PictureBox pictureBox5;
	}
}
