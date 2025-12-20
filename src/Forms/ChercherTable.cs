using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Transacts
{
	/// <summary>
	/// Summary description for ChercherTable.
	/// </summary>
	public class ChercherTable : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button39;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button button38;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChercherTable()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button39 = new System.Windows.Forms.Button();
			this.button30 = new System.Windows.Forms.Button();
			this.button31 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.button33 = new System.Windows.Forms.Button();
			this.button34 = new System.Windows.Forms.Button();
			this.button35 = new System.Windows.Forms.Button();
			this.button36 = new System.Windows.Forms.Button();
			this.button37 = new System.Windows.Forms.Button();
			this.button38 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.textBox1.Location = new System.Drawing.Point(312, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(56, 35);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// button39
			// 
			this.button39.BackColor = System.Drawing.Color.Cornsilk;
			this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button39.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button39.Location = new System.Drawing.Point(296, 80);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(72, 104);
			this.button39.TabIndex = 122;
			this.button39.Text = "0";
			this.button39.Click += new System.EventHandler(this.button38_Click);
			// 
			// button30
			// 
			this.button30.BackColor = System.Drawing.Color.Cornsilk;
			this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button30.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button30.Location = new System.Drawing.Point(240, 192);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(50, 50);
			this.button30.TabIndex = 121;
			this.button30.Text = "3";
			this.button30.Click += new System.EventHandler(this.button38_Click);
			// 
			// button31
			// 
			this.button31.BackColor = System.Drawing.Color.Cornsilk;
			this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button31.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button31.Location = new System.Drawing.Point(184, 192);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(50, 50);
			this.button31.TabIndex = 120;
			this.button31.Text = "2";
			this.button31.Click += new System.EventHandler(this.button38_Click);
			// 
			// button32
			// 
			this.button32.BackColor = System.Drawing.Color.Cornsilk;
			this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button32.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button32.Location = new System.Drawing.Point(128, 192);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(50, 50);
			this.button32.TabIndex = 119;
			this.button32.Text = "1";
			this.button32.Click += new System.EventHandler(this.button38_Click);
			// 
			// button33
			// 
			this.button33.BackColor = System.Drawing.Color.Cornsilk;
			this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button33.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button33.Location = new System.Drawing.Point(240, 136);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(50, 50);
			this.button33.TabIndex = 118;
			this.button33.Text = "6";
			this.button33.Click += new System.EventHandler(this.button38_Click);
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.Cornsilk;
			this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button34.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button34.Location = new System.Drawing.Point(184, 136);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(50, 50);
			this.button34.TabIndex = 117;
			this.button34.Text = "5";
			this.button34.Click += new System.EventHandler(this.button38_Click);
			// 
			// button35
			// 
			this.button35.BackColor = System.Drawing.Color.Cornsilk;
			this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button35.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button35.Location = new System.Drawing.Point(128, 136);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(50, 50);
			this.button35.TabIndex = 116;
			this.button35.Text = "4";
			this.button35.Click += new System.EventHandler(this.button38_Click);
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.Cornsilk;
			this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button36.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button36.Location = new System.Drawing.Point(240, 80);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(50, 50);
			this.button36.TabIndex = 115;
			this.button36.Text = "9";
			this.button36.Click += new System.EventHandler(this.button38_Click);
			// 
			// button37
			// 
			this.button37.BackColor = System.Drawing.Color.Cornsilk;
			this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button37.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button37.Location = new System.Drawing.Point(184, 80);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(50, 50);
			this.button37.TabIndex = 114;
			this.button37.Text = "8";
			this.button37.Click += new System.EventHandler(this.button38_Click);
			// 
			// button38
			// 
			this.button38.BackColor = System.Drawing.Color.Cornsilk;
			this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button38.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button38.Location = new System.Drawing.Point(128, 80);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(50, 50);
			this.button38.TabIndex = 113;
			this.button38.Text = "7";
			this.button38.Click += new System.EventHandler(this.button38_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(200, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 123;
			this.radioButton1.Text = "Client";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(200, 8);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 124;
			this.radioButton2.Text = "Table";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 32);
			this.label1.TabIndex = 125;
			this.label1.Text = "Rechercher...";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(8, 144);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 40);
			this.button1.TabIndex = 126;
			this.button1.Text = "Valider";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(8, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 40);
			this.button2.TabIndex = 127;
			this.button2.Text = "Annuler";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cornsilk;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(296, 192);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(72, 50);
			this.button3.TabIndex = 128;
			this.button3.Text = "Eff";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// ChercherTable
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 246);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.label1,
																		  this.radioButton2,
																		  this.radioButton1,
																		  this.button39,
																		  this.button30,
																		  this.button31,
																		  this.button32,
																		  this.button33,
																		  this.button34,
																		  this.button35,
																		  this.button36,
																		  this.button37,
																		  this.button38,
																		  this.textBox1});
			this.Name = "ChercherTable";
			this.Text = "ChercherTable";
			this.ResumeLayout(false);

		}
		#endregion

		private void button3_Click(object sender, System.EventArgs e)
		{
			textBox1.Text="";
		}

		private void button38_Click(object sender, System.EventArgs e)
		{
			textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}
		public int GetNum()
		{
			return Num;
		}
		private int Num;
		private void button1_Click(object sender, System.EventArgs e)
		{
			if (textBox1.Text!="")
			Num=System.Convert.ToInt32(textBox1.Text);
			this.Close();
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Num=-1;
			this.Close();

		}
	
	}
}
