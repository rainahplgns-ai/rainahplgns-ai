/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 5/16/2026
 * Time: 7:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final_project
{
	partial class pick_avatar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pick_avatar));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_avatar = new System.Windows.Forms.PictureBox();
			this.save_input = new System.Windows.Forms.PictureBox();
			this.players_name = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.save_input)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panel1.Location = new System.Drawing.Point(132, 106);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(161, 393);
			this.panel1.TabIndex = 0;
			this.panel1.Click += new System.EventHandler(this.Panel1Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panel2.Location = new System.Drawing.Point(305, 106);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(161, 393);
			this.panel2.TabIndex = 1;
			this.panel2.Click += new System.EventHandler(this.Panel2Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Transparent;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panel4.Location = new System.Drawing.Point(478, 106);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(161, 393);
			this.panel4.TabIndex = 2;
			this.panel4.Click += new System.EventHandler(this.Panel4Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panel3.Location = new System.Drawing.Point(651, 106);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(161, 393);
			this.panel3.TabIndex = 3;
			this.panel3.Click += new System.EventHandler(this.Panel3Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(305, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(321, 41);
			this.label1.TabIndex = 4;
			this.label1.Text = "Pick your avatar!";
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
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.PictureBox5Click);
			// 
			// panel5
			// 
			this.panel5.AutoSize = true;
			this.panel5.BackColor = System.Drawing.Color.Transparent;
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.pic_avatar);
			this.panel5.Controls.Add(this.save_input);
			this.panel5.Controls.Add(this.players_name);
			this.panel5.Location = new System.Drawing.Point(651, 23);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(248, 356);
			this.panel5.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(27, 218);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Name your character...";
			// 
			// pic_avatar
			// 
			this.pic_avatar.BackColor = System.Drawing.Color.Transparent;
			this.pic_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pic_avatar.Location = new System.Drawing.Point(22, 21);
			this.pic_avatar.Name = "pic_avatar";
			this.pic_avatar.Size = new System.Drawing.Size(205, 180);
			this.pic_avatar.TabIndex = 2;
			this.pic_avatar.TabStop = false;
			// 
			// save_input
			// 
			this.save_input.BackColor = System.Drawing.Color.Transparent;
			this.save_input.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_input.BackgroundImage")));
			this.save_input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.save_input.Cursor = System.Windows.Forms.Cursors.Hand;
			this.save_input.Location = new System.Drawing.Point(46, 287);
			this.save_input.Name = "save_input";
			this.save_input.Size = new System.Drawing.Size(156, 45);
			this.save_input.TabIndex = 1;
			this.save_input.TabStop = false;
			this.save_input.Click += new System.EventHandler(this.Save_inputClick);
			// 
			// players_name
			// 
			this.players_name.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.players_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.players_name.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.players_name.ForeColor = System.Drawing.Color.White;
			this.players_name.Location = new System.Drawing.Point(27, 237);
			this.players_name.Multiline = true;
			this.players_name.Name = "players_name";
			this.players_name.Size = new System.Drawing.Size(195, 35);
			this.players_name.TabIndex = 0;
			this.players_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pick_avatar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(934, 511);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "pick_avatar";
			this.Text = "pick_avatar";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.save_input)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox players_name;
		private System.Windows.Forms.PictureBox save_input;
		private System.Windows.Forms.PictureBox pic_avatar;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
	}
}
