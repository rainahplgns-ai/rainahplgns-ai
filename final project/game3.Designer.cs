/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 4/30/2026
 * Time: 12:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace final_project
{
	partial class game3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game3));
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.game1_ins = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.game1_ins.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
			this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox5.Location = new System.Drawing.Point(29, 17);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(131, 54);
			this.pictureBox5.TabIndex = 18;
			this.pictureBox5.TabStop = false;
			// 
			// game1_ins
			// 
			this.game1_ins.BackColor = System.Drawing.Color.Transparent;
			this.game1_ins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("game1_ins.BackgroundImage")));
			this.game1_ins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.game1_ins.Controls.Add(this.panel4);
			this.game1_ins.Controls.Add(this.panel3);
			this.game1_ins.Controls.Add(this.panel2);
			this.game1_ins.Location = new System.Drawing.Point(148, 52);
			this.game1_ins.Name = "game1_ins";
			this.game1_ins.Size = new System.Drawing.Size(641, 411);
			this.game1_ins.TabIndex = 20;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel4.Location = new System.Drawing.Point(91, 349);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(231, 36);
			this.panel4.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel3.Location = new System.Drawing.Point(321, 349);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(231, 36);
			this.panel3.TabIndex = 1;
			this.panel3.Click += new System.EventHandler(this.Panel3Click);
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(24, 13);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(593, 330);
			this.panel2.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(80, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(433, 247);
			this.label3.TabIndex = 14;
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(774, 439);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(131, 54);
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// game3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(934, 511);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.game1_ins);
			this.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.Name = "game3";
			this.Text = "game3";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.game1_ins.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel game1_ins;
		private System.Windows.Forms.PictureBox pictureBox5;
	}
}
