﻿namespace WindowsFormsApplication1
{
	partial class XtraForm1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(121, 36);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(75, 23);
			this.simpleButton1.TabIndex = 0;
			this.simpleButton1.Text = "Add file";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(32, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(249, 211);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(121, 318);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(75, 23);
			this.simpleButton2.TabIndex = 2;
			this.simpleButton2.Text = "Save";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// XtraForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 353);
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.simpleButton1);
			this.Text = "XtraForm1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
	}
}