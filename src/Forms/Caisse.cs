using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Transacts
{
	/// <summary>
	/// Summary description for Caisse.
	/// </summary>
	public class Caisse : System.Windows.Forms.Form
	{
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
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button40;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;

		public Caisse()
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
			this.components = new System.ComponentModel.Container();
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
			this.button2 = new System.Windows.Forms.Button();
			this.button29 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.button26 = new System.Windows.Forms.Button();
			this.button27 = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button40 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.button41 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// button39
			// 
			this.button39.BackColor = System.Drawing.Color.Cornsilk;
			this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button39.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button39.Location = new System.Drawing.Point(616, 248);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(72, 160);
			this.button39.TabIndex = 102;
			this.button39.Text = "0";
			this.button39.Click += new System.EventHandler(this.button26_Click);
			// 
			// button30
			// 
			this.button30.BackColor = System.Drawing.Color.Cornsilk;
			this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button30.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button30.Location = new System.Drawing.Point(560, 360);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(50, 50);
			this.button30.TabIndex = 101;
			this.button30.Text = "3";
			this.button30.Click += new System.EventHandler(this.button26_Click);
			// 
			// button31
			// 
			this.button31.BackColor = System.Drawing.Color.Cornsilk;
			this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button31.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button31.Location = new System.Drawing.Point(504, 360);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(50, 50);
			this.button31.TabIndex = 100;
			this.button31.Text = "2";
			this.button31.Click += new System.EventHandler(this.button26_Click);
			// 
			// button32
			// 
			this.button32.BackColor = System.Drawing.Color.Cornsilk;
			this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button32.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button32.Location = new System.Drawing.Point(448, 360);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(50, 50);
			this.button32.TabIndex = 99;
			this.button32.Text = "1";
			this.button32.Click += new System.EventHandler(this.button26_Click);
			// 
			// button33
			// 
			this.button33.BackColor = System.Drawing.Color.Cornsilk;
			this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button33.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button33.Location = new System.Drawing.Point(560, 304);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(50, 50);
			this.button33.TabIndex = 98;
			this.button33.Text = "6";
			this.button33.Click += new System.EventHandler(this.button26_Click);
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.Cornsilk;
			this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button34.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button34.Location = new System.Drawing.Point(504, 304);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(50, 50);
			this.button34.TabIndex = 97;
			this.button34.Text = "5";
			this.button34.Click += new System.EventHandler(this.button26_Click);
			// 
			// button35
			// 
			this.button35.BackColor = System.Drawing.Color.Cornsilk;
			this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button35.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button35.Location = new System.Drawing.Point(448, 304);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(50, 50);
			this.button35.TabIndex = 96;
			this.button35.Text = "4";
			this.button35.Click += new System.EventHandler(this.button26_Click);
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.Cornsilk;
			this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button36.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button36.Location = new System.Drawing.Point(560, 248);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(50, 50);
			this.button36.TabIndex = 95;
			this.button36.Text = "9";
			this.button36.Click += new System.EventHandler(this.button26_Click);
			// 
			// button37
			// 
			this.button37.BackColor = System.Drawing.Color.Cornsilk;
			this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button37.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button37.Location = new System.Drawing.Point(504, 248);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(50, 50);
			this.button37.TabIndex = 94;
			this.button37.Text = "8";
			this.button37.Click += new System.EventHandler(this.button26_Click);
			// 
			// button38
			// 
			this.button38.BackColor = System.Drawing.Color.Cornsilk;
			this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button38.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button38.Location = new System.Drawing.Point(448, 248);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(50, 50);
			this.button38.TabIndex = 93;
			this.button38.Text = "7";
			this.button38.Click += new System.EventHandler(this.button26_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(280, 328);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 125;
			this.button2.Text = ".";
			this.button2.Click += new System.EventHandler(this.button26_Click);
			// 
			// button29
			// 
			this.button29.BackColor = System.Drawing.Color.Cornsilk;
			this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button29.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button29.Location = new System.Drawing.Point(400, 248);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(40, 40);
			this.button29.TabIndex = 122;
			this.button29.Text = "P";
			this.button29.Click += new System.EventHandler(this.button26_Click);
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.Cornsilk;
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button20.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button20.Location = new System.Drawing.Point(400, 288);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(40, 40);
			this.button20.TabIndex = 121;
			this.button20.Text = "M";
			this.button20.Click += new System.EventHandler(this.button26_Click);
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.Cornsilk;
			this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button21.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button21.Location = new System.Drawing.Point(320, 328);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(120, 40);
			this.button21.TabIndex = 120;
			this.button21.Text = "EFF";
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.Cornsilk;
			this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button22.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button22.Location = new System.Drawing.Point(240, 328);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(40, 40);
			this.button22.TabIndex = 119;
			this.button22.Text = "N";
			this.button22.Click += new System.EventHandler(this.button26_Click);
			// 
			// button23
			// 
			this.button23.BackColor = System.Drawing.Color.Cornsilk;
			this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button23.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button23.Location = new System.Drawing.Point(40, 368);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(400, 40);
			this.button23.TabIndex = 118;
			this.button23.Text = "Espace";
			// 
			// button24
			// 
			this.button24.BackColor = System.Drawing.Color.Cornsilk;
			this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button24.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button24.Location = new System.Drawing.Point(200, 328);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(40, 40);
			this.button24.TabIndex = 117;
			this.button24.Text = "B";
			this.button24.Click += new System.EventHandler(this.button26_Click);
			// 
			// button25
			// 
			this.button25.BackColor = System.Drawing.Color.Cornsilk;
			this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button25.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button25.Location = new System.Drawing.Point(160, 328);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(40, 40);
			this.button25.TabIndex = 116;
			this.button25.Text = "V";
			this.button25.Click += new System.EventHandler(this.button26_Click);
			// 
			// button26
			// 
			this.button26.BackColor = System.Drawing.Color.Cornsilk;
			this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button26.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button26.Location = new System.Drawing.Point(120, 328);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(40, 40);
			this.button26.TabIndex = 115;
			this.button26.Text = "C";
			this.button26.Click += new System.EventHandler(this.button26_Click);
			// 
			// button27
			// 
			this.button27.BackColor = System.Drawing.Color.Cornsilk;
			this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button27.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button27.Location = new System.Drawing.Point(80, 328);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(40, 40);
			this.button27.TabIndex = 114;
			this.button27.Text = "X";
			this.button27.Click += new System.EventHandler(this.button26_Click);
			// 
			// button28
			// 
			this.button28.BackColor = System.Drawing.Color.Cornsilk;
			this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button28.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button28.Location = new System.Drawing.Point(40, 328);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(40, 40);
			this.button28.TabIndex = 113;
			this.button28.Text = "W";
			this.button28.Click += new System.EventHandler(this.button26_Click);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.Cornsilk;
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button11.Location = new System.Drawing.Point(360, 288);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(40, 40);
			this.button11.TabIndex = 112;
			this.button11.Text = "L";
			this.button11.Click += new System.EventHandler(this.button26_Click);
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.Cornsilk;
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button12.Location = new System.Drawing.Point(320, 288);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(40, 40);
			this.button12.TabIndex = 111;
			this.button12.Text = "K";
			this.button12.Click += new System.EventHandler(this.button26_Click);
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.Cornsilk;
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button13.Location = new System.Drawing.Point(280, 288);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(40, 40);
			this.button13.TabIndex = 110;
			this.button13.Text = "J";
			this.button13.Click += new System.EventHandler(this.button26_Click);
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.Cornsilk;
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button14.Location = new System.Drawing.Point(240, 288);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(40, 40);
			this.button14.TabIndex = 109;
			this.button14.Text = "H";
			this.button14.Click += new System.EventHandler(this.button26_Click);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.Cornsilk;
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button15.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button15.Location = new System.Drawing.Point(200, 288);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(40, 40);
			this.button15.TabIndex = 108;
			this.button15.Text = "G";
			this.button15.Click += new System.EventHandler(this.button26_Click);
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.Cornsilk;
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button16.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button16.Location = new System.Drawing.Point(160, 288);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(40, 40);
			this.button16.TabIndex = 107;
			this.button16.Text = "F";
			this.button16.Click += new System.EventHandler(this.button26_Click);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Cornsilk;
			this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button17.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button17.Location = new System.Drawing.Point(120, 288);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(40, 40);
			this.button17.TabIndex = 106;
			this.button17.Text = "D";
			this.button17.Click += new System.EventHandler(this.button26_Click);
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Cornsilk;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button18.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button18.Location = new System.Drawing.Point(80, 288);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(40, 40);
			this.button18.TabIndex = 105;
			this.button18.Text = "S";
			this.button18.Click += new System.EventHandler(this.button26_Click);
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.Cornsilk;
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button19.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button19.Location = new System.Drawing.Point(40, 288);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(40, 40);
			this.button19.TabIndex = 104;
			this.button19.Text = "Q";
			this.button19.Click += new System.EventHandler(this.button26_Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.Cornsilk;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button10.Location = new System.Drawing.Point(360, 248);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(40, 40);
			this.button10.TabIndex = 103;
			this.button10.Text = "O";
			this.button10.Click += new System.EventHandler(this.button26_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.Cornsilk;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button9.Location = new System.Drawing.Point(320, 248);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(40, 40);
			this.button9.TabIndex = 102;
			this.button9.Text = "I";
			this.button9.Click += new System.EventHandler(this.button26_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Cornsilk;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button8.Location = new System.Drawing.Point(280, 248);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(40, 40);
			this.button8.TabIndex = 101;
			this.button8.Text = "U";
			this.button8.Click += new System.EventHandler(this.button26_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Cornsilk;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.Location = new System.Drawing.Point(240, 248);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(40, 40);
			this.button7.TabIndex = 100;
			this.button7.Text = "Y";
			this.button7.Click += new System.EventHandler(this.button26_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Cornsilk;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.Location = new System.Drawing.Point(200, 248);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(40, 40);
			this.button6.TabIndex = 99;
			this.button6.Text = "T";
			this.button6.Click += new System.EventHandler(this.button26_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Cornsilk;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.Location = new System.Drawing.Point(160, 248);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(40, 40);
			this.button5.TabIndex = 98;
			this.button5.Text = "R";
			this.button5.Click += new System.EventHandler(this.button26_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Cornsilk;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(120, 248);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(40, 40);
			this.button4.TabIndex = 97;
			this.button4.Text = "E";
			this.button4.Click += new System.EventHandler(this.button26_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cornsilk;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(80, 248);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 96;
			this.button3.Text = "Z";
			this.button3.Click += new System.EventHandler(this.button26_Click);
			// 
			// button40
			// 
			this.button40.BackColor = System.Drawing.Color.Cornsilk;
			this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button40.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button40.Location = new System.Drawing.Point(40, 248);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(40, 40);
			this.button40.TabIndex = 95;
			this.button40.Text = "A";
			this.button40.Click += new System.EventHandler(this.button26_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(560, 416);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 40);
			this.button1.TabIndex = 127;
			this.button1.Text = "Suivant";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(72, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 23);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 24);
			this.label2.TabIndex = 131;
			this.label2.Text = "Espèces";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(72, 40);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(120, 23);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 24);
			this.label3.TabIndex = 133;
			this.label3.Text = "CB";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(72, 72);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(120, 23);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 24);
			this.label4.TabIndex = 135;
			this.label4.Text = "Chèque";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(72, 104);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(120, 23);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 24);
			this.label5.TabIndex = 137;
			this.label5.Text = "Autre";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(424, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(128, 24);
			this.label7.TabIndex = 140;
			this.label7.Text = "Compte Journalier";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(544, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(152, 23);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(544, 56);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(152, 23);
			this.textBox6.TabIndex = 6;
			this.textBox6.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(424, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(128, 24);
			this.label8.TabIndex = 142;
			this.label8.Text = "Identifiant Client";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 144);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(128, 24);
			this.label9.TabIndex = 144;
			this.label9.Text = "Montant Total TTC";
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label10.Location = new System.Drawing.Point(128, 144);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(120, 24);
			this.label10.TabIndex = 145;
			// 
			// button41
			// 
			this.button41.BackColor = System.Drawing.Color.Cornsilk;
			this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button41.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button41.Location = new System.Drawing.Point(568, 88);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(128, 72);
			this.button41.TabIndex = 146;
			this.button41.Text = "Facture";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Caisse
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(704, 462);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button41,
																		  this.label10,
																		  this.label9,
																		  this.textBox6,
																		  this.label8,
																		  this.textBox1,
																		  this.label7,
																		  this.textBox5,
																		  this.label5,
																		  this.textBox4,
																		  this.label4,
																		  this.textBox3,
																		  this.label3,
																		  this.textBox2,
																		  this.label2,
																		  this.button1,
																		  this.button37,
																		  this.button38,
																		  this.button39,
																		  this.button30,
																		  this.button31,
																		  this.button32,
																		  this.button33,
																		  this.button34,
																		  this.button35,
																		  this.button36,
																		  this.button17,
																		  this.button18,
																		  this.button19,
																		  this.button10,
																		  this.button9,
																		  this.button8,
																		  this.button7,
																		  this.button6,
																		  this.button5,
																		  this.button4,
																		  this.button3,
																		  this.button40,
																		  this.button12,
																		  this.button11,
																		  this.button28,
																		  this.button27,
																		  this.button26,
																		  this.button2,
																		  this.button29,
																		  this.button20,
																		  this.button21,
																		  this.button22,
																		  this.button23,
																		  this.button24,
																		  this.button25,
																		  this.button13,
																		  this.button14,
																		  this.button15,
																		  this.button16});
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Caisse";
			this.Text = "Co";
			this.ResumeLayout(false);

		}
		#endregion
		int SelectedControl=1;
		private void button1_Click(object sender, System.EventArgs e)
		{
			ActiveControl.SelectNextControl(textBox1,true,true,true,true);
		}

		private void button26_Click(object sender, System.EventArgs e)
		{
			foreach (Control c in this.Controls)
				if(c.TabIndex==SelectedControl)
					c.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			foreach (Control c in this.Controls)
				if (c.GetType().FullName == "System.Windows.Forms.TextBox" && c.Focused==true)
				SelectedControl = c.TabIndex;
		}
	}
}
