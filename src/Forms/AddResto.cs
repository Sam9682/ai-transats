using System.Runtime.CompilerServices;
using System;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Transacts
{
	/// <summary>
	/// Summary description for AddResto.
	/// </summary>
	public class AddResto : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Button button1;
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private string add ="";
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private Transacts.dsAjProduit dsAjProduit1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private Transacts.dsFamillesProduits dsFamillesProduits1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddResto(string add)
		{
			//
			// Required for Windows Form Designer support
			//
			this.add=add;
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
			this.button43 = new System.Windows.Forms.Button();
			this.button41 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsAjProduit1 = new Transacts.dsAjProduit();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.dsFamillesProduits1 = new Transacts.dsFamillesProduits();
			((System.ComponentModel.ISupportInitialize)(this.dsAjProduit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsFamillesProduits1)).BeginInit();
			this.SuspendLayout();
			// 
			// button43
			// 
			this.button43.BackColor = System.Drawing.Color.Cornsilk;
			this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button43.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button43.Location = new System.Drawing.Point(312, 72);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(112, 48);
			this.button43.TabIndex = 146;
			this.button43.Text = "Annuler";
			// 
			// button41
			// 
			this.button41.BackColor = System.Drawing.Color.Cornsilk;
			this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button41.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button41.Location = new System.Drawing.Point(312, 128);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(112, 48);
			this.button41.TabIndex = 145;
			this.button41.Text = "Valider";
			this.button41.Click += new System.EventHandler(this.button41_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(312, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 48);
			this.button1.TabIndex = 142;
			this.button1.Text = "Entrée";
			// 
			// button39
			// 
			this.button39.BackColor = System.Drawing.Color.Cornsilk;
			this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button39.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button39.Location = new System.Drawing.Point(376, 200);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(40, 40);
			this.button39.TabIndex = 102;
			this.button39.Text = "0";
			this.button39.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button30
			// 
			this.button30.BackColor = System.Drawing.Color.Cornsilk;
			this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button30.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button30.Location = new System.Drawing.Point(96, 200);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(40, 40);
			this.button30.TabIndex = 101;
			this.button30.Text = "3";
			this.button30.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button31
			// 
			this.button31.BackColor = System.Drawing.Color.Cornsilk;
			this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button31.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button31.Location = new System.Drawing.Point(56, 200);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(40, 40);
			this.button31.TabIndex = 100;
			this.button31.Text = "2";
			this.button31.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button32
			// 
			this.button32.BackColor = System.Drawing.Color.Cornsilk;
			this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button32.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button32.Location = new System.Drawing.Point(16, 200);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(40, 40);
			this.button32.TabIndex = 99;
			this.button32.Text = "1";
			this.button32.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button33
			// 
			this.button33.BackColor = System.Drawing.Color.Cornsilk;
			this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button33.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button33.Location = new System.Drawing.Point(216, 200);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(40, 40);
			this.button33.TabIndex = 98;
			this.button33.Text = "6";
			this.button33.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.Cornsilk;
			this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button34.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button34.Location = new System.Drawing.Point(176, 200);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(40, 40);
			this.button34.TabIndex = 97;
			this.button34.Text = "5";
			this.button34.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button35
			// 
			this.button35.BackColor = System.Drawing.Color.Cornsilk;
			this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button35.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button35.Location = new System.Drawing.Point(136, 200);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(40, 40);
			this.button35.TabIndex = 96;
			this.button35.Text = "4";
			this.button35.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.Cornsilk;
			this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button36.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button36.Location = new System.Drawing.Point(336, 200);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(40, 40);
			this.button36.TabIndex = 95;
			this.button36.Text = "9";
			this.button36.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button37
			// 
			this.button37.BackColor = System.Drawing.Color.Cornsilk;
			this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button37.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button37.Location = new System.Drawing.Point(296, 200);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(40, 40);
			this.button37.TabIndex = 94;
			this.button37.Text = "8";
			this.button37.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button38
			// 
			this.button38.BackColor = System.Drawing.Color.Cornsilk;
			this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button38.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button38.Location = new System.Drawing.Point(256, 200);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(40, 40);
			this.button38.TabIndex = 93;
			this.button38.Text = "7";
			this.button38.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(256, 328);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 125;
			this.button2.Text = ".";
			// 
			// button29
			// 
			this.button29.BackColor = System.Drawing.Color.Cornsilk;
			this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button29.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button29.Location = new System.Drawing.Point(376, 248);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(40, 40);
			this.button29.TabIndex = 122;
			this.button29.Text = "P";
			this.button29.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.Cornsilk;
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button20.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button20.Location = new System.Drawing.Point(376, 288);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(40, 40);
			this.button20.TabIndex = 121;
			this.button20.Text = "M";
			this.button20.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.Cornsilk;
			this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button21.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button21.Location = new System.Drawing.Point(296, 328);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(120, 40);
			this.button21.TabIndex = 120;
			this.button21.Text = "EFF";
			this.button21.Click += new System.EventHandler(this.button21_Click);
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.Cornsilk;
			this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button22.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button22.Location = new System.Drawing.Point(216, 328);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(40, 40);
			this.button22.TabIndex = 119;
			this.button22.Text = "N";
			this.button22.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button23
			// 
			this.button23.BackColor = System.Drawing.Color.Cornsilk;
			this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button23.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button23.Location = new System.Drawing.Point(16, 368);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(400, 32);
			this.button23.TabIndex = 118;
			this.button23.Text = "Espace";
			this.button23.Click += new System.EventHandler(this.button23_Click);
			// 
			// button24
			// 
			this.button24.BackColor = System.Drawing.Color.Cornsilk;
			this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button24.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button24.Location = new System.Drawing.Point(176, 328);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(40, 40);
			this.button24.TabIndex = 117;
			this.button24.Text = "B";
			this.button24.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button25
			// 
			this.button25.BackColor = System.Drawing.Color.Cornsilk;
			this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button25.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button25.Location = new System.Drawing.Point(136, 328);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(40, 40);
			this.button25.TabIndex = 116;
			this.button25.Text = "V";
			this.button25.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button26
			// 
			this.button26.BackColor = System.Drawing.Color.Cornsilk;
			this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button26.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button26.Location = new System.Drawing.Point(96, 328);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(40, 40);
			this.button26.TabIndex = 115;
			this.button26.Text = "C";
			this.button26.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button27
			// 
			this.button27.BackColor = System.Drawing.Color.Cornsilk;
			this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button27.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button27.Location = new System.Drawing.Point(56, 328);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(40, 40);
			this.button27.TabIndex = 114;
			this.button27.Text = "X";
			this.button27.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button28
			// 
			this.button28.BackColor = System.Drawing.Color.Cornsilk;
			this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button28.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button28.Location = new System.Drawing.Point(16, 328);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(40, 40);
			this.button28.TabIndex = 113;
			this.button28.Text = "W";
			this.button28.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.Cornsilk;
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button11.Location = new System.Drawing.Point(336, 288);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(40, 40);
			this.button11.TabIndex = 112;
			this.button11.Text = "L";
			this.button11.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.Cornsilk;
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button12.Location = new System.Drawing.Point(296, 288);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(40, 40);
			this.button12.TabIndex = 111;
			this.button12.Text = "K";
			this.button12.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.Cornsilk;
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button13.Location = new System.Drawing.Point(256, 288);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(40, 40);
			this.button13.TabIndex = 110;
			this.button13.Text = "J";
			this.button13.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.Cornsilk;
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button14.Location = new System.Drawing.Point(216, 288);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(40, 40);
			this.button14.TabIndex = 109;
			this.button14.Text = "H";
			this.button14.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.Cornsilk;
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button15.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button15.Location = new System.Drawing.Point(176, 288);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(40, 40);
			this.button15.TabIndex = 108;
			this.button15.Text = "G";
			this.button15.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.Cornsilk;
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button16.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button16.Location = new System.Drawing.Point(136, 288);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(40, 40);
			this.button16.TabIndex = 107;
			this.button16.Text = "F";
			this.button16.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Cornsilk;
			this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button17.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button17.Location = new System.Drawing.Point(96, 288);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(40, 40);
			this.button17.TabIndex = 106;
			this.button17.Text = "D";
			this.button17.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Cornsilk;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button18.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button18.Location = new System.Drawing.Point(56, 288);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(40, 40);
			this.button18.TabIndex = 105;
			this.button18.Text = "S";
			this.button18.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.Cornsilk;
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button19.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button19.Location = new System.Drawing.Point(16, 288);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(40, 40);
			this.button19.TabIndex = 104;
			this.button19.Text = "Q";
			this.button19.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.Cornsilk;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button10.Location = new System.Drawing.Point(336, 248);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(40, 40);
			this.button10.TabIndex = 103;
			this.button10.Text = "O";
			this.button10.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.Cornsilk;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button9.Location = new System.Drawing.Point(296, 248);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(40, 40);
			this.button9.TabIndex = 102;
			this.button9.Text = "I";
			this.button9.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Cornsilk;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button8.Location = new System.Drawing.Point(256, 248);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(40, 40);
			this.button8.TabIndex = 101;
			this.button8.Text = "U";
			this.button8.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Cornsilk;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.Location = new System.Drawing.Point(216, 248);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(40, 40);
			this.button7.TabIndex = 100;
			this.button7.Text = "Y";
			this.button7.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Cornsilk;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.Location = new System.Drawing.Point(176, 248);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(40, 40);
			this.button6.TabIndex = 99;
			this.button6.Text = "T";
			this.button6.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Cornsilk;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.Location = new System.Drawing.Point(136, 248);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(40, 40);
			this.button5.TabIndex = 98;
			this.button5.Text = "R";
			this.button5.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Cornsilk;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(96, 248);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(40, 40);
			this.button4.TabIndex = 97;
			this.button4.Text = "E";
			this.button4.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cornsilk;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(56, 248);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 96;
			this.button3.Text = "Z";
			this.button3.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// button40
			// 
			this.button40.BackColor = System.Drawing.Color.Cornsilk;
			this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button40.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button40.Location = new System.Drawing.Point(16, 248);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(40, 40);
			this.button40.TabIndex = 95;
			this.button40.Text = "A";
			this.button40.Click += new System.EventHandler(this.button31_Click_1);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(104, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 26);
			this.textBox1.TabIndex = 133;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(32, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 140;
			this.label6.Text = "Code";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(104, 120);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(200, 26);
			this.textBox3.TabIndex = 137;
			this.textBox3.Text = "";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 136;
			this.label2.Text = "Type";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(104, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 26);
			this.textBox2.TabIndex = 135;
			this.textBox2.Text = "";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 134;
			this.label1.Text = "Nom";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(144, 152);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(160, 26);
			this.textBox4.TabIndex = 148;
			this.textBox4.Text = "";
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 24);
			this.label3.TabIndex = 147;
			this.label3.Text = "Prix Unitaire";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Produit", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("RefProduit", "RefProduit"),
																																																				   new System.Data.Common.DataColumnMapping("LibelleProduit", "LibelleProduit"),
																																																				   new System.Data.Common.DataColumnMapping("TypeProduit", "TypeProduit"),
																																																				   new System.Data.Common.DataColumnMapping("PrixUnit", "PrixUnit"),
																																																				   new System.Data.Common.DataColumnMapping("s_GUID", "s_GUID")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT LibelleProduit, PrixUnit, RefProduit, s_GUID, TypeProduit FROM Produit";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Produit(LibelleProduit, PrixUnit, RefProduit, s_GUID, TypeProduit) VA" +
				"LUES (?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "LibelleProduit"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefProduit", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("s_GUID", System.Data.OleDb.OleDbType.Guid, 0, "s_GUID"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "TypeProduit"));
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Produit SET LibelleProduit = ?, PrixUnit = ?, RefProduit = ?, s_GUID = ?, TypeProduit = ? WHERE (RefProduit = ?) AND (LibelleProduit = ? OR ? IS NULL AND LibelleProduit IS NULL) AND (PrixUnit = ? OR ? IS NULL AND PrixUnit IS NULL) AND (TypeProduit = ? OR ? IS NULL AND TypeProduit IS NULL) AND (s_GUID = ? OR ? IS NULL AND s_GUID IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "LibelleProduit"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefProduit", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("s_GUID", System.Data.OleDb.OleDbType.Guid, 0, "s_GUID"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "TypeProduit"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LibelleProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LibelleProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_s_GUID", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "s_GUID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_s_GUID1", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "s_GUID", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM Produit WHERE (RefProduit = ?) AND (LibelleProduit = ? OR ? IS NULL AND LibelleProduit IS NULL) AND (PrixUnit = ? OR ? IS NULL AND PrixUnit IS NULL) AND (TypeProduit = ? OR ? IS NULL AND TypeProduit IS NULL) AND (s_GUID = ? OR ? IS NULL AND s_GUID IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LibelleProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LibelleProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_s_GUID", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "s_GUID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_s_GUID1", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "s_GUID", System.Data.DataRowVersion.Original, null));
			// 
			// dsAjProduit1
			// 
			this.dsAjProduit1.DataSetName = "dsAjProduit";
			this.dsAjProduit1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsAjProduit1.Namespace = "http://www.tempuri.org/dsAjProduit.xsd";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.dsFamillesProduits1.Produit;
			this.comboBox1.DisplayMember = "TypeProduit";
			this.comboBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.comboBox1.Location = new System.Drawing.Point(104, 80);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 26);
			this.comboBox1.TabIndex = 149;
			this.comboBox1.Text = "comboBox1";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(24, 120);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(72, 24);
			this.checkBox1.TabIndex = 150;
			this.checkBox1.Text = "Nlle Famille";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Produit", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("TypeProduit", "TypeProduit")})});
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT DISTINCT TypeProduit FROM Produit";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// dsFamillesProduits1
			// 
			this.dsFamillesProduits1.DataSetName = "dsFamillesProduits";
			this.dsFamillesProduits1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsFamillesProduits1.Namespace = "http://www.tempuri.org/dsFamillesProduits.xsd";
			// 
			// AddResto
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 422);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.checkBox1,
																		  this.comboBox1,
																		  this.textBox4,
																		  this.label3,
																		  this.button43,
																		  this.button41,
																		  this.button1,
																		  this.textBox1,
																		  this.label6,
																		  this.textBox3,
																		  this.label2,
																		  this.textBox2,
																		  this.label1,
																		  this.button31,
																		  this.button32,
																		  this.button33,
																		  this.button34,
																		  this.button35,
																		  this.button36,
																		  this.button37,
																		  this.button38,
																		  this.button39,
																		  this.button30,
																		  this.button2,
																		  this.button29,
																		  this.button20,
																		  this.button21,
																		  this.button22,
																		  this.button23,
																		  this.button24,
																		  this.button25,
																		  this.button26,
																		  this.button27,
																		  this.button28,
																		  this.button11,
																		  this.button12,
																		  this.button13,
																		  this.button14,
																		  this.button15,
																		  this.button16,
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
																		  this.button40});
			this.Name = "AddResto";
			this.Text = "Ajout...";
			this.Load += new System.EventHandler(this.AddResto_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsAjProduit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsFamillesProduits1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button31_Click(object sender, System.EventArgs e)
		{
			
		}
		int selTex=1;
		private void button31_Click_1(object sender, System.EventArgs e)
		{
			if(selTex==1)
			textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
			if(selTex==2)
				textBox2.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
			if(selTex==3)
				textBox3.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
			if(selTex==4)
				textBox4.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
		selTex=1;
		}

		private void button23_Click(object sender, System.EventArgs e)
		{
			if(selTex==1)
				textBox1.Text+=" ";
			if(selTex==2)
				textBox2.Text+=" ";
			if(selTex==3)
				textBox3.Text+=" ";
			if(selTex==4)
				textBox4.Text+=" ";
		
		}

		private void button21_Click(object sender, System.EventArgs e)
		{
			if(selTex==1)
				textBox1.Text="";
			if(selTex==2)
				textBox2.Text="";
			if(selTex==3)
				textBox3.Text="";
			if(selTex==4)
				textBox4.Text="";
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
		selTex=2;
		}

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
		selTex=3;
		}

		private void textBox4_TextChanged(object sender, System.EventArgs e)
		{
			selTex=4;
		}

		private void button41_Click(object sender, System.EventArgs e)
		{string SQLSTR="";
			if(checkBox1.Checked)
				SQLSTR = "Insert Into Produit( LibelleProduit, PrixUnit, RefProduit, TypeProduit) "+
					"values("+
					"'"+textBox2.Text +"', "+
					textBox4.Text +", "+
					textBox1.Text +", "+
					"'"+textBox3.Text +"'"+
					")";
			else{
				SQLSTR = "Insert Into Produit( LibelleProduit, PrixUnit, RefProduit, TypeProduit) "+
					"values("+
					"'"+textBox2.Text +"', "+
					textBox4.Text +", "+
					textBox1.Text +", "+
					"'"+comboBox1.Text +"'"+
					")";
			}
			OleDbCommand commsql;
			if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)

				oleDbDataAdapter1.SelectCommand.Connection.Open();
			try
			{commsql=new OleDbCommand(SQLSTR,oleDbDataAdapter1.SelectCommand.Connection);

				commsql.ExecuteNonQuery();
				oleDbConnection1.Close();
			}
			catch(Exception ec){ MessageBox.Show(oleDbDataAdapter1.InsertCommand.CommandText+"\n"+ec.ToString());}
			
		}

		private void AddResto_Load(object sender, System.EventArgs e)
		{
			oleDbDataAdapter2.Fill(dsFamillesProduits1);
		}
		bool Exist=true;
		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			oleDbDataAdapter1.SelectCommand.CommandText=
				"Select * from Produit where RefProduit ="+textBox1.Text;
			try
			{	
				dsAjProduit1.Clear();
				oleDbDataAdapter1.Fill(dsAjProduit1);
				if (dsAjProduit1.Tables[0].Rows.Count>0) Exist=true;
				else Exist=false;
				textBox2.Text=dsAjProduit1.Tables[0].Rows[0].ItemArray[0].ToString();
				textBox3.Text=dsAjProduit1.Tables[0].Rows[0].ItemArray[4].ToString();
				textBox4.Text=dsAjProduit1.Tables[0].Rows[0].ItemArray[1].ToString();
			}
			catch(Exception Ex)
			{
				textBox2.Text="";
				textBox3.Text="";
				textBox4.Text="";
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			textBox3.Enabled=checkBox1.Checked;
			comboBox1.Enabled=!textBox3.Enabled;
		
		}
	}
}
