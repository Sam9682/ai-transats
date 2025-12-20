using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Transacts
{
	/// <summary>
	/// Summary description for AddCoursStage.
	/// </summary>
	public class AddCoursStage : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
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
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button42;
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Transacts.dsEmploesCours dsEmploesCours1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddCoursStage()
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
			this.button43 = new System.Windows.Forms.Button();
			this.button41 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.button42 = new System.Windows.Forms.Button();
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
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dsEmploesCours1 = new Transacts.dsEmploesCours();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsEmploesCours1)).BeginInit();
			this.SuspendLayout();
			// 
			// button43
			// 
			this.button43.BackColor = System.Drawing.Color.Cornsilk;
			this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button43.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button43.Location = new System.Drawing.Point(336, 88);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(136, 48);
			this.button43.TabIndex = 122;
			this.button43.Text = "Annuler";
			// 
			// button41
			// 
			this.button41.BackColor = System.Drawing.Color.Cornsilk;
			this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button41.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button41.Location = new System.Drawing.Point(336, 32);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(136, 48);
			this.button41.TabIndex = 121;
			this.button41.Text = "Valider";
			this.button41.Click += new System.EventHandler(this.button41_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2});
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabControl1.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.tabControl1.ItemSize = new System.Drawing.Size(66, 30);
			this.tabControl1.Location = new System.Drawing.Point(24, 240);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(440, 224);
			this.tabControl1.TabIndex = 117;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button39,
																				   this.button30,
																				   this.button31,
																				   this.button32,
																				   this.button33,
																				   this.button34,
																				   this.button35,
																				   this.button36,
																				   this.button37,
																				   this.button38});
			this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabPage1.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.tabPage1.Location = new System.Drawing.Point(4, 34);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(432, 186);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Num";
			// 
			// button39
			// 
			this.button39.BackColor = System.Drawing.Color.Cornsilk;
			this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button39.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button39.Location = new System.Drawing.Point(232, 16);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(72, 160);
			this.button39.TabIndex = 102;
			this.button39.Text = "0";
			// 
			// button30
			// 
			this.button30.BackColor = System.Drawing.Color.Cornsilk;
			this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button30.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button30.Location = new System.Drawing.Point(176, 128);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(50, 50);
			this.button30.TabIndex = 101;
			this.button30.Text = "3";
			// 
			// button31
			// 
			this.button31.BackColor = System.Drawing.Color.Cornsilk;
			this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button31.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button31.Location = new System.Drawing.Point(120, 128);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(50, 50);
			this.button31.TabIndex = 100;
			this.button31.Text = "2";
			// 
			// button32
			// 
			this.button32.BackColor = System.Drawing.Color.Cornsilk;
			this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button32.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button32.Location = new System.Drawing.Point(64, 128);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(50, 50);
			this.button32.TabIndex = 99;
			this.button32.Text = "1";
			// 
			// button33
			// 
			this.button33.BackColor = System.Drawing.Color.Cornsilk;
			this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button33.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button33.Location = new System.Drawing.Point(176, 72);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(50, 50);
			this.button33.TabIndex = 98;
			this.button33.Text = "6";
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.Cornsilk;
			this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button34.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button34.Location = new System.Drawing.Point(120, 72);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(50, 50);
			this.button34.TabIndex = 97;
			this.button34.Text = "5";
			// 
			// button35
			// 
			this.button35.BackColor = System.Drawing.Color.Cornsilk;
			this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button35.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button35.Location = new System.Drawing.Point(64, 72);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(50, 50);
			this.button35.TabIndex = 96;
			this.button35.Text = "4";
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.Cornsilk;
			this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button36.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button36.Location = new System.Drawing.Point(176, 16);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(50, 50);
			this.button36.TabIndex = 95;
			this.button36.Text = "9";
			// 
			// button37
			// 
			this.button37.BackColor = System.Drawing.Color.Cornsilk;
			this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button37.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button37.Location = new System.Drawing.Point(120, 16);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(50, 50);
			this.button37.TabIndex = 94;
			this.button37.Text = "8";
			// 
			// button38
			// 
			this.button38.BackColor = System.Drawing.Color.Cornsilk;
			this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button38.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button38.Location = new System.Drawing.Point(64, 16);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(50, 50);
			this.button38.TabIndex = 93;
			this.button38.Text = "7";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button2,
																				   this.button42,
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
			this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabPage2.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.tabPage2.Location = new System.Drawing.Point(4, 34);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(432, 186);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Alpha";
			this.tabPage2.Visible = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(296, 88);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 125;
			this.button2.Text = ".";
			// 
			// button42
			// 
			this.button42.BackColor = System.Drawing.Color.Cornsilk;
			this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button42.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button42.Location = new System.Drawing.Point(256, 88);
			this.button42.Name = "button42";
			this.button42.Size = new System.Drawing.Size(40, 40);
			this.button42.TabIndex = 123;
			this.button42.Text = "@";
			// 
			// button29
			// 
			this.button29.BackColor = System.Drawing.Color.Cornsilk;
			this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button29.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button29.Location = new System.Drawing.Point(376, 8);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(40, 40);
			this.button29.TabIndex = 122;
			this.button29.Text = "P";
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.Cornsilk;
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button20.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button20.Location = new System.Drawing.Point(376, 48);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(40, 40);
			this.button20.TabIndex = 121;
			this.button20.Text = "M";
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.Cornsilk;
			this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button21.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button21.Location = new System.Drawing.Point(336, 88);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(80, 40);
			this.button21.TabIndex = 120;
			this.button21.Text = "EFF";
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.Cornsilk;
			this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button22.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button22.Location = new System.Drawing.Point(216, 88);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(40, 40);
			this.button22.TabIndex = 119;
			this.button22.Text = "N";
			// 
			// button23
			// 
			this.button23.BackColor = System.Drawing.Color.Cornsilk;
			this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button23.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button23.Location = new System.Drawing.Point(16, 128);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(400, 32);
			this.button23.TabIndex = 118;
			this.button23.Text = "Espace";
			// 
			// button24
			// 
			this.button24.BackColor = System.Drawing.Color.Cornsilk;
			this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button24.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button24.Location = new System.Drawing.Point(176, 88);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(40, 40);
			this.button24.TabIndex = 117;
			this.button24.Text = "B";
			// 
			// button25
			// 
			this.button25.BackColor = System.Drawing.Color.Cornsilk;
			this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button25.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button25.Location = new System.Drawing.Point(136, 88);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(40, 40);
			this.button25.TabIndex = 116;
			this.button25.Text = "V";
			// 
			// button26
			// 
			this.button26.BackColor = System.Drawing.Color.Cornsilk;
			this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button26.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button26.Location = new System.Drawing.Point(96, 88);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(40, 40);
			this.button26.TabIndex = 115;
			this.button26.Text = "C";
			// 
			// button27
			// 
			this.button27.BackColor = System.Drawing.Color.Cornsilk;
			this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button27.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button27.Location = new System.Drawing.Point(56, 88);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(40, 40);
			this.button27.TabIndex = 114;
			this.button27.Text = "X";
			// 
			// button28
			// 
			this.button28.BackColor = System.Drawing.Color.Cornsilk;
			this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button28.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button28.Location = new System.Drawing.Point(16, 88);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(40, 40);
			this.button28.TabIndex = 113;
			this.button28.Text = "W";
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.Cornsilk;
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button11.Location = new System.Drawing.Point(336, 48);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(40, 40);
			this.button11.TabIndex = 112;
			this.button11.Text = "L";
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.Cornsilk;
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button12.Location = new System.Drawing.Point(296, 48);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(40, 40);
			this.button12.TabIndex = 111;
			this.button12.Text = "K";
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.Cornsilk;
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button13.Location = new System.Drawing.Point(256, 48);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(40, 40);
			this.button13.TabIndex = 110;
			this.button13.Text = "J";
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.Cornsilk;
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button14.Location = new System.Drawing.Point(216, 48);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(40, 40);
			this.button14.TabIndex = 109;
			this.button14.Text = "H";
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.Cornsilk;
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button15.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button15.Location = new System.Drawing.Point(176, 48);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(40, 40);
			this.button15.TabIndex = 108;
			this.button15.Text = "G";
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.Cornsilk;
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button16.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button16.Location = new System.Drawing.Point(136, 48);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(40, 40);
			this.button16.TabIndex = 107;
			this.button16.Text = "F";
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Cornsilk;
			this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button17.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button17.Location = new System.Drawing.Point(96, 48);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(40, 40);
			this.button17.TabIndex = 106;
			this.button17.Text = "D";
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Cornsilk;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button18.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button18.Location = new System.Drawing.Point(56, 48);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(40, 40);
			this.button18.TabIndex = 105;
			this.button18.Text = "S";
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.Cornsilk;
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button19.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button19.Location = new System.Drawing.Point(16, 48);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(40, 40);
			this.button19.TabIndex = 104;
			this.button19.Text = "Q";
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.Cornsilk;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button10.Location = new System.Drawing.Point(336, 8);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(40, 40);
			this.button10.TabIndex = 103;
			this.button10.Text = "O";
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.Cornsilk;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button9.Location = new System.Drawing.Point(296, 8);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(40, 40);
			this.button9.TabIndex = 102;
			this.button9.Text = "I";
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Cornsilk;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button8.Location = new System.Drawing.Point(256, 8);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(40, 40);
			this.button8.TabIndex = 101;
			this.button8.Text = "U";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Cornsilk;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.Location = new System.Drawing.Point(216, 8);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(40, 40);
			this.button7.TabIndex = 100;
			this.button7.Text = "Y";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Cornsilk;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.Location = new System.Drawing.Point(176, 8);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(40, 40);
			this.button6.TabIndex = 99;
			this.button6.Text = "T";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Cornsilk;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.Location = new System.Drawing.Point(136, 8);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(40, 40);
			this.button5.TabIndex = 98;
			this.button5.Text = "R";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Cornsilk;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(96, 8);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(40, 40);
			this.button4.TabIndex = 97;
			this.button4.Text = "E";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cornsilk;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(56, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 96;
			this.button3.Text = "Z";
			// 
			// button40
			// 
			this.button40.BackColor = System.Drawing.Color.Cornsilk;
			this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button40.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button40.Location = new System.Drawing.Point(16, 8);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(40, 40);
			this.button40.TabIndex = 95;
			this.button40.Text = "A";
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(96, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(224, 26);
			this.textBox1.TabIndex = 106;
			this.textBox1.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 116;
			this.label6.Text = "Code";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(40, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(8, 16);
			this.label4.TabIndex = 113;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(96, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(224, 26);
			this.textBox2.TabIndex = 108;
			this.textBox2.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 107;
			this.label1.Text = "Nom";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 123;
			this.label2.Text = "Date Début";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 124;
			this.label3.Text = "Date Fin";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.dateTimePicker1.Location = new System.Drawing.Point(96, 96);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(232, 26);
			this.dateTimePicker1.TabIndex = 125;
			this.dateTimePicker1.Value = new System.DateTime(2006, 6, 8, 21, 29, 5, 101);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.dateTimePicker2.Location = new System.Drawing.Point(96, 128);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(232, 26);
			this.dateTimePicker2.TabIndex = 126;
			this.dateTimePicker2.Value = new System.DateTime(2006, 6, 8, 21, 29, 5, 101);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 176);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 24);
			this.label5.TabIndex = 128;
			this.label5.Text = "Code Employé";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.dsEmploesCours1.Employe;
			this.comboBox1.DisplayMember = "NumEmploye";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.comboBox1.Location = new System.Drawing.Point(120, 184);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(152, 26);
			this.comboBox1.TabIndex = 129;
			// 
			// dsEmploesCours1
			// 
			this.dsEmploesCours1.DataSetName = "dsEmploesCours";
			this.dsEmploesCours1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsEmploesCours1.Namespace = "http://www.tempuri.org/dsEmploesCours.xsd";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Employe", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("NumEmploye", "NumEmploye")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Employe WHERE (NumEmploye = ?)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "NumEmploye", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Employe(NumEmploye) VALUES (?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "NumEmploye", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT NumEmploye FROM Employe";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Employe SET NumEmploye = ? WHERE (NumEmploye = ?)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "NumEmploye", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "NumEmploye", System.Data.DataRowVersion.Original, null));
			// 
			// AddCoursStage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 486);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.comboBox1,
																		  this.label5,
																		  this.dateTimePicker2,
																		  this.dateTimePicker1,
																		  this.label3,
																		  this.label2,
																		  this.button43,
																		  this.button41,
																		  this.tabControl1,
																		  this.textBox1,
																		  this.label6,
																		  this.label4,
																		  this.textBox2,
																		  this.label1});
			this.Name = "AddCoursStage";
			this.Text = "AddCoursStage";
			this.Load += new System.EventHandler(this.AddCoursStage_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsEmploesCours1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		public string CodeActivite;
		public string Table;
		private void button41_Click(object sender, System.EventArgs e)
		{
		if(Table =="Cours")
		 {
			 string STRSQL = "INSERT INTO COURS VALUES ("+
				 " '"+textBox1.Text +"', "+
				 " '"+textBox2.Text +"', "+
				 " '"+dateTimePicker1.Value.ToShortDateString()+"', "+
				 " '"+dateTimePicker2.Value.ToShortDateString()+ 
				 "','"+ comboBox1.Text+"',"+
				 " '"+CodeActivite+"'"+
				 ")";
			 try 
			 {
				 if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open )
					 oleDbDataAdapter1.SelectCommand.Connection.Open(); 
				 OleDbCommand CommSQL = new OleDbCommand(STRSQL,oleDbDataAdapter1.SelectCommand.Connection);
				 CommSQL.ExecuteNonQuery();
			 }
			 catch(Exception  exc){MessageBox.Show(STRSQL+"\n"+exc.ToString());}
		 }
			if(Table =="Stage")
			{
				string STRSQL = "INSERT INTO Stage VALUES ("+
					" '"+textBox1.Text +"', "+
					" '"+textBox2.Text +"', "+
					" '"+dateTimePicker1.Value.ToShortDateString()+"', "+
					" '"+dateTimePicker2.Value.ToShortDateString()+
					"','"+ comboBox1.Text+"',"+
					" '"+CodeActivite+"'"+
					")";
				try 
				{
					if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open )
						oleDbDataAdapter1.SelectCommand.Connection.Open();
					OleDbCommand CommSQL = new OleDbCommand(STRSQL,oleDbDataAdapter1.SelectCommand.Connection);
					CommSQL.ExecuteNonQuery();
				}
				catch(Exception exc){MessageBox.Show(STRSQL+"\n"+exc.ToString());}
			}
			this.Hide();
		}

		private void AddCoursStage_Load(object sender, System.EventArgs e)
		{
			oleDbDataAdapter1.Fill(dsEmploesCours1);
			comboBox1.Refresh();
			
		}
	}
}
