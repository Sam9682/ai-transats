using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Transacts
{
	/// <summary>
	/// Summary description for AjouTable.
	/// </summary>
	public class AjouTable : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button39;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		public int numeroTable;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AjouTable()
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
			this.button39 = new System.Windows.Forms.Button();
			this.button36 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button39
			// 
			this.button39.BackColor = System.Drawing.Color.Cornsilk;
			this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button39.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button39.Location = new System.Drawing.Point(288, 8);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(72, 104);
			this.button39.TabIndex = 112;
			this.button39.Text = "0";
			this.button39.Click += new System.EventHandler(this.button8_Click);
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.Cornsilk;
			this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button36.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button36.Location = new System.Drawing.Point(232, 8);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(50, 50);
			this.button36.TabIndex = 105;
			this.button36.Text = "9";
			this.button36.Click += new System.EventHandler(this.button8_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.textBox1.Location = new System.Drawing.Point(8, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 35);
			this.textBox1.TabIndex = 116;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 48);
			this.label1.TabIndex = 117;
			this.label1.Text = "Numéro de la table";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(232, 120);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(50, 50);
			this.button2.TabIndex = 111;
			this.button2.Text = "3";
			this.button2.Click += new System.EventHandler(this.button8_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cornsilk;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(8, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 48);
			this.button3.TabIndex = 115;
			this.button3.Text = "Valider";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Cornsilk;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button4.Location = new System.Drawing.Point(120, 64);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(50, 50);
			this.button4.TabIndex = 106;
			this.button4.Text = "4";
			this.button4.Click += new System.EventHandler(this.button8_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Cornsilk;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button5.Location = new System.Drawing.Point(176, 64);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(50, 50);
			this.button5.TabIndex = 107;
			this.button5.Text = "5";
			this.button5.Click += new System.EventHandler(this.button8_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Cornsilk;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button6.Location = new System.Drawing.Point(232, 64);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(50, 50);
			this.button6.TabIndex = 108;
			this.button6.Text = "6";
			this.button6.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Cornsilk;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button7.Location = new System.Drawing.Point(176, 120);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(50, 50);
			this.button7.TabIndex = 110;
			this.button7.Text = "2";
			this.button7.Click += new System.EventHandler(this.button8_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Cornsilk;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button8.Location = new System.Drawing.Point(120, 120);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(50, 50);
			this.button8.TabIndex = 109;
			this.button8.Text = "1";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.Cornsilk;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button9.Location = new System.Drawing.Point(120, 8);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(50, 50);
			this.button9.TabIndex = 103;
			this.button9.Text = "7";
			this.button9.Click += new System.EventHandler(this.button8_Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.Cornsilk;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button10.Location = new System.Drawing.Point(176, 8);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(50, 50);
			this.button10.TabIndex = 104;
			this.button10.Text = "8";
			this.button10.Click += new System.EventHandler(this.button8_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(288, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 50);
			this.button1.TabIndex = 118;
			this.button1.Text = "Eff";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// AjouTable
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(368, 174);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.label1,
																		  this.textBox1,
																		  this.button39,
																		  this.button36,
																		  this.button2,
																		  this.button3,
																		  this.button4,
																		  this.button5,
																		  this.button6,
																		  this.button7,
																		  this.button8,
																		  this.button9,
																		  this.button10});
			this.Name = "AjouTable";
			this.Text = "AjouTable";
			this.Click += new System.EventHandler(this.button8_Click);
			this.ResumeLayout(false);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void button1_Click(object sender, System.EventArgs e)
		{
			numeroTable = System.Convert.ToInt32(textBox1.Text);
		}

		private void button30_Click_1(object sender, System.EventArgs e)
		{
			textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			textBox1.Text="";
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.numeroTable=System.Convert.ToInt32(textBox1.Text);
			this.Close();
		}
	}
}
