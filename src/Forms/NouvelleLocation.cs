using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Transacts
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class NouvelleLocation : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TabControl tabControl3;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button44;
		private System.Windows.Forms.Button button45;
		private System.Windows.Forms.Button button46;
		private System.Windows.Forms.Button button47;
		private System.Windows.Forms.Button button48;
		private System.Windows.Forms.Button button49;
		private System.Windows.Forms.Button button50;
		private System.Windows.Forms.Button button51;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.Button button52;
		private System.Windows.Forms.Button button53;
		private System.Windows.Forms.Button button54;
		private System.Windows.Forms.Button button55;
		private System.Windows.Forms.Button button56;
		private System.Windows.Forms.Button button57;
		private System.Windows.Forms.Button button58;
		private System.Windows.Forms.Button button59;
		private System.Windows.Forms.Button button60;
		private System.Windows.Forms.Button button61;
		private System.Windows.Forms.Button button62;
		private System.Windows.Forms.Button button63;
		private System.Windows.Forms.Button button64;
		private System.Windows.Forms.Button button65;
		private System.Windows.Forms.Button button66;
		private System.Windows.Forms.Button button67;
		private System.Windows.Forms.Button button68;
		private System.Windows.Forms.Button button69;
		private System.Windows.Forms.Button button70;
		private System.Windows.Forms.Button button71;
		private System.Windows.Forms.Button button72;
		private System.Windows.Forms.Button button73;
		private System.Windows.Forms.Button button74;
		private System.Windows.Forms.Button button75;
		private System.Windows.Forms.Button button76;
		private System.Windows.Forms.Button button77;
		private System.Windows.Forms.Button button78;
		private System.Windows.Forms.Button button79;
		private System.Windows.Forms.Button button80;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Transacts.dsComptes dsComptes1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NouvelleLocation()
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.button41 = new System.Windows.Forms.Button();
			this.button43 = new System.Windows.Forms.Button();
			this.button44 = new System.Windows.Forms.Button();
			this.button45 = new System.Windows.Forms.Button();
			this.button46 = new System.Windows.Forms.Button();
			this.button47 = new System.Windows.Forms.Button();
			this.button48 = new System.Windows.Forms.Button();
			this.button49 = new System.Windows.Forms.Button();
			this.button50 = new System.Windows.Forms.Button();
			this.button51 = new System.Windows.Forms.Button();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.button52 = new System.Windows.Forms.Button();
			this.button53 = new System.Windows.Forms.Button();
			this.button54 = new System.Windows.Forms.Button();
			this.button55 = new System.Windows.Forms.Button();
			this.button56 = new System.Windows.Forms.Button();
			this.button57 = new System.Windows.Forms.Button();
			this.button58 = new System.Windows.Forms.Button();
			this.button59 = new System.Windows.Forms.Button();
			this.button60 = new System.Windows.Forms.Button();
			this.button61 = new System.Windows.Forms.Button();
			this.button62 = new System.Windows.Forms.Button();
			this.button63 = new System.Windows.Forms.Button();
			this.button64 = new System.Windows.Forms.Button();
			this.button65 = new System.Windows.Forms.Button();
			this.button66 = new System.Windows.Forms.Button();
			this.button67 = new System.Windows.Forms.Button();
			this.button68 = new System.Windows.Forms.Button();
			this.button69 = new System.Windows.Forms.Button();
			this.button70 = new System.Windows.Forms.Button();
			this.button71 = new System.Windows.Forms.Button();
			this.button72 = new System.Windows.Forms.Button();
			this.button73 = new System.Windows.Forms.Button();
			this.button74 = new System.Windows.Forms.Button();
			this.button75 = new System.Windows.Forms.Button();
			this.button76 = new System.Windows.Forms.Button();
			this.button77 = new System.Windows.Forms.Button();
			this.button78 = new System.Windows.Forms.Button();
			this.button79 = new System.Windows.Forms.Button();
			this.button80 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.dsComptes1 = new Transacts.dsComptes();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabControl3.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsComptes1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Compte Journalier";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button1.Location = new System.Drawing.Point(312, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 72);
			this.button1.TabIndex = 2;
			this.button1.Text = "Ajouter Au Compte";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.dsComptes1.CompteJournalier;
			this.comboBox1.DisplayMember = "NumCompteJournalier";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.comboBox1.Location = new System.Drawing.Point(136, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(168, 26);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage5,
																					  this.tabPage6});
			this.tabControl3.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.tabControl3.Location = new System.Drawing.Point(8, 240);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(440, 224);
			this.tabControl3.TabIndex = 103;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button41,
																				   this.button43,
																				   this.button44,
																				   this.button45,
																				   this.button46,
																				   this.button47,
																				   this.button48,
																				   this.button49,
																				   this.button50,
																				   this.button51});
			this.tabPage5.Location = new System.Drawing.Point(4, 34);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(432, 186);
			this.tabPage5.TabIndex = 0;
			this.tabPage5.Text = "Num";
			// 
			// button41
			// 
			this.button41.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button41.Location = new System.Drawing.Point(232, 16);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(72, 160);
			this.button41.TabIndex = 102;
			this.button41.Text = "0";
			// 
			// button43
			// 
			this.button43.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button43.Location = new System.Drawing.Point(176, 128);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(50, 50);
			this.button43.TabIndex = 101;
			this.button43.Text = "3";
			// 
			// button44
			// 
			this.button44.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button44.Location = new System.Drawing.Point(120, 128);
			this.button44.Name = "button44";
			this.button44.Size = new System.Drawing.Size(50, 50);
			this.button44.TabIndex = 100;
			this.button44.Text = "2";
			// 
			// button45
			// 
			this.button45.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button45.Location = new System.Drawing.Point(64, 128);
			this.button45.Name = "button45";
			this.button45.Size = new System.Drawing.Size(50, 50);
			this.button45.TabIndex = 99;
			this.button45.Text = "1";
			// 
			// button46
			// 
			this.button46.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button46.Location = new System.Drawing.Point(176, 72);
			this.button46.Name = "button46";
			this.button46.Size = new System.Drawing.Size(50, 50);
			this.button46.TabIndex = 98;
			this.button46.Text = "6";
			// 
			// button47
			// 
			this.button47.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button47.Location = new System.Drawing.Point(120, 72);
			this.button47.Name = "button47";
			this.button47.Size = new System.Drawing.Size(50, 50);
			this.button47.TabIndex = 97;
			this.button47.Text = "5";
			// 
			// button48
			// 
			this.button48.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button48.Location = new System.Drawing.Point(64, 72);
			this.button48.Name = "button48";
			this.button48.Size = new System.Drawing.Size(50, 50);
			this.button48.TabIndex = 96;
			this.button48.Text = "4";
			// 
			// button49
			// 
			this.button49.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button49.Location = new System.Drawing.Point(176, 16);
			this.button49.Name = "button49";
			this.button49.Size = new System.Drawing.Size(50, 50);
			this.button49.TabIndex = 95;
			this.button49.Text = "9";
			// 
			// button50
			// 
			this.button50.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button50.Location = new System.Drawing.Point(120, 16);
			this.button50.Name = "button50";
			this.button50.Size = new System.Drawing.Size(50, 50);
			this.button50.TabIndex = 94;
			this.button50.Text = "8";
			// 
			// button51
			// 
			this.button51.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button51.Location = new System.Drawing.Point(64, 16);
			this.button51.Name = "button51";
			this.button51.Size = new System.Drawing.Size(50, 50);
			this.button51.TabIndex = 93;
			this.button51.Text = "7";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button52,
																				   this.button53,
																				   this.button54,
																				   this.button55,
																				   this.button56,
																				   this.button57,
																				   this.button58,
																				   this.button59,
																				   this.button60,
																				   this.button61,
																				   this.button62,
																				   this.button63,
																				   this.button64,
																				   this.button65,
																				   this.button66,
																				   this.button67,
																				   this.button68,
																				   this.button69,
																				   this.button70,
																				   this.button71,
																				   this.button72,
																				   this.button73,
																				   this.button74,
																				   this.button75,
																				   this.button76,
																				   this.button77,
																				   this.button78,
																				   this.button79,
																				   this.button80,
																				   this.checkBox1});
			this.tabPage6.Location = new System.Drawing.Point(4, 34);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(432, 186);
			this.tabPage6.TabIndex = 1;
			this.tabPage6.Text = "Alpha";
			this.tabPage6.Visible = false;
			// 
			// button52
			// 
			this.button52.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button52.Location = new System.Drawing.Point(256, 88);
			this.button52.Name = "button52";
			this.button52.Size = new System.Drawing.Size(40, 40);
			this.button52.TabIndex = 123;
			this.button52.Text = ":";
			// 
			// button53
			// 
			this.button53.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button53.Location = new System.Drawing.Point(376, 8);
			this.button53.Name = "button53";
			this.button53.Size = new System.Drawing.Size(40, 40);
			this.button53.TabIndex = 122;
			this.button53.Text = "P";
			// 
			// button54
			// 
			this.button54.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button54.Location = new System.Drawing.Point(376, 48);
			this.button54.Name = "button54";
			this.button54.Size = new System.Drawing.Size(40, 40);
			this.button54.TabIndex = 121;
			this.button54.Text = "M";
			// 
			// button55
			// 
			this.button55.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button55.Location = new System.Drawing.Point(296, 88);
			this.button55.Name = "button55";
			this.button55.Size = new System.Drawing.Size(120, 40);
			this.button55.TabIndex = 120;
			this.button55.Text = "EFF";
			// 
			// button56
			// 
			this.button56.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button56.Location = new System.Drawing.Point(216, 88);
			this.button56.Name = "button56";
			this.button56.Size = new System.Drawing.Size(40, 40);
			this.button56.TabIndex = 119;
			this.button56.Text = "N";
			// 
			// button57
			// 
			this.button57.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button57.Location = new System.Drawing.Point(96, 128);
			this.button57.Name = "button57";
			this.button57.Size = new System.Drawing.Size(320, 32);
			this.button57.TabIndex = 118;
			this.button57.Text = "Espace";
			// 
			// button58
			// 
			this.button58.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button58.Location = new System.Drawing.Point(176, 88);
			this.button58.Name = "button58";
			this.button58.Size = new System.Drawing.Size(40, 40);
			this.button58.TabIndex = 117;
			this.button58.Text = "B";
			// 
			// button59
			// 
			this.button59.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button59.Location = new System.Drawing.Point(136, 88);
			this.button59.Name = "button59";
			this.button59.Size = new System.Drawing.Size(40, 40);
			this.button59.TabIndex = 116;
			this.button59.Text = "V";
			// 
			// button60
			// 
			this.button60.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button60.Location = new System.Drawing.Point(96, 88);
			this.button60.Name = "button60";
			this.button60.Size = new System.Drawing.Size(40, 40);
			this.button60.TabIndex = 115;
			this.button60.Text = "C";
			// 
			// button61
			// 
			this.button61.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button61.Location = new System.Drawing.Point(56, 88);
			this.button61.Name = "button61";
			this.button61.Size = new System.Drawing.Size(40, 40);
			this.button61.TabIndex = 114;
			this.button61.Text = "X";
			// 
			// button62
			// 
			this.button62.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button62.Location = new System.Drawing.Point(16, 88);
			this.button62.Name = "button62";
			this.button62.Size = new System.Drawing.Size(40, 40);
			this.button62.TabIndex = 113;
			this.button62.Text = "W";
			// 
			// button63
			// 
			this.button63.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button63.Location = new System.Drawing.Point(336, 48);
			this.button63.Name = "button63";
			this.button63.Size = new System.Drawing.Size(40, 40);
			this.button63.TabIndex = 112;
			this.button63.Text = "L";
			// 
			// button64
			// 
			this.button64.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button64.Location = new System.Drawing.Point(296, 48);
			this.button64.Name = "button64";
			this.button64.Size = new System.Drawing.Size(40, 40);
			this.button64.TabIndex = 111;
			this.button64.Text = "K";
			// 
			// button65
			// 
			this.button65.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button65.Location = new System.Drawing.Point(256, 48);
			this.button65.Name = "button65";
			this.button65.Size = new System.Drawing.Size(40, 40);
			this.button65.TabIndex = 110;
			this.button65.Text = "J";
			// 
			// button66
			// 
			this.button66.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button66.Location = new System.Drawing.Point(216, 48);
			this.button66.Name = "button66";
			this.button66.Size = new System.Drawing.Size(40, 40);
			this.button66.TabIndex = 109;
			this.button66.Text = "H";
			// 
			// button67
			// 
			this.button67.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button67.Location = new System.Drawing.Point(176, 48);
			this.button67.Name = "button67";
			this.button67.Size = new System.Drawing.Size(40, 40);
			this.button67.TabIndex = 108;
			this.button67.Text = "G";
			// 
			// button68
			// 
			this.button68.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button68.Location = new System.Drawing.Point(136, 48);
			this.button68.Name = "button68";
			this.button68.Size = new System.Drawing.Size(40, 40);
			this.button68.TabIndex = 107;
			this.button68.Text = "F";
			// 
			// button69
			// 
			this.button69.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button69.Location = new System.Drawing.Point(96, 48);
			this.button69.Name = "button69";
			this.button69.Size = new System.Drawing.Size(40, 40);
			this.button69.TabIndex = 106;
			this.button69.Text = "D";
			// 
			// button70
			// 
			this.button70.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button70.Location = new System.Drawing.Point(56, 48);
			this.button70.Name = "button70";
			this.button70.Size = new System.Drawing.Size(40, 40);
			this.button70.TabIndex = 105;
			this.button70.Text = "S";
			// 
			// button71
			// 
			this.button71.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button71.Location = new System.Drawing.Point(16, 48);
			this.button71.Name = "button71";
			this.button71.Size = new System.Drawing.Size(40, 40);
			this.button71.TabIndex = 104;
			this.button71.Text = "Q";
			// 
			// button72
			// 
			this.button72.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button72.Location = new System.Drawing.Point(336, 8);
			this.button72.Name = "button72";
			this.button72.Size = new System.Drawing.Size(40, 40);
			this.button72.TabIndex = 103;
			this.button72.Text = "O";
			// 
			// button73
			// 
			this.button73.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button73.Location = new System.Drawing.Point(296, 8);
			this.button73.Name = "button73";
			this.button73.Size = new System.Drawing.Size(40, 40);
			this.button73.TabIndex = 102;
			this.button73.Text = "I";
			// 
			// button74
			// 
			this.button74.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button74.Location = new System.Drawing.Point(256, 8);
			this.button74.Name = "button74";
			this.button74.Size = new System.Drawing.Size(40, 40);
			this.button74.TabIndex = 101;
			this.button74.Text = "U";
			// 
			// button75
			// 
			this.button75.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button75.Location = new System.Drawing.Point(216, 8);
			this.button75.Name = "button75";
			this.button75.Size = new System.Drawing.Size(40, 40);
			this.button75.TabIndex = 100;
			this.button75.Text = "Y";
			// 
			// button76
			// 
			this.button76.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button76.Location = new System.Drawing.Point(176, 8);
			this.button76.Name = "button76";
			this.button76.Size = new System.Drawing.Size(40, 40);
			this.button76.TabIndex = 99;
			this.button76.Text = "T";
			// 
			// button77
			// 
			this.button77.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button77.Location = new System.Drawing.Point(136, 8);
			this.button77.Name = "button77";
			this.button77.Size = new System.Drawing.Size(40, 40);
			this.button77.TabIndex = 98;
			this.button77.Text = "R";
			// 
			// button78
			// 
			this.button78.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button78.Location = new System.Drawing.Point(96, 8);
			this.button78.Name = "button78";
			this.button78.Size = new System.Drawing.Size(40, 40);
			this.button78.TabIndex = 97;
			this.button78.Text = "E";
			// 
			// button79
			// 
			this.button79.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button79.Location = new System.Drawing.Point(56, 8);
			this.button79.Name = "button79";
			this.button79.Size = new System.Drawing.Size(40, 40);
			this.button79.TabIndex = 96;
			this.button79.Text = "Z";
			// 
			// button80
			// 
			this.button80.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button80.Location = new System.Drawing.Point(16, 8);
			this.button80.Name = "button80";
			this.button80.Size = new System.Drawing.Size(40, 40);
			this.button80.TabIndex = 95;
			this.button80.Text = "A";
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(16, 136);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(80, 24);
			this.checkBox1.TabIndex = 124;
			this.checkBox1.Text = "Shift";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "CompteJournalier", new System.Data.Common.DataColumnMapping[] {
																																																							new System.Data.Common.DataColumnMapping("NumCompteJournalier", "NumCompteJournalier"),
																																																							new System.Data.Common.DataColumnMapping("RefClient", "RefClient"),
																																																							new System.Data.Common.DataColumnMapping("NumClient", "NumClient"),
																																																							new System.Data.Common.DataColumnMapping("NomClient", "NomClient"),
																																																							new System.Data.Common.DataColumnMapping("PrenomClient", "PrenomClient")})});
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT CompteJournalier.NumCompteJournalier, CompteJournalier.RefClient, Client.N" +
				"umClient, Client.NomClient, Client.PrenomClient FROM (CompteJournalier INNER JOI" +
				"N Client ON CompteJournalier.RefClient = Client.NumClient)";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// dsComptes1
			// 
			this.dsComptes1.DataSetName = "dsComptes";
			this.dsComptes1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsComptes1.Namespace = "http://www.tempuri.org/dsComptes.xsd";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label3.Location = new System.Drawing.Point(136, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 32);
			this.label3.TabIndex = 104;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label4.Location = new System.Drawing.Point(136, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 32);
			this.label4.TabIndex = 105;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 32);
			this.label5.TabIndex = 106;
			this.label5.Text = "Nom";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label6.Location = new System.Drawing.Point(8, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 32);
			this.label6.TabIndex = 107;
			this.label6.Text = "Prénom";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nom";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.textBox2.Location = new System.Drawing.Point(56, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 26);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button2.Location = new System.Drawing.Point(216, 24);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(208, 40);
			this.button2.TabIndex = 3;
			this.button2.Text = "Ouvrir un Compte Journalier";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label2,
																					this.textBox2,
																					this.button2});
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.groupBox1.Location = new System.Drawing.Point(8, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(432, 72);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Ou";
			// 
			// NouvelleLocation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(458, 472);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label6,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.tabControl3,
																		  this.comboBox1,
																		  this.groupBox1,
																		  this.button1,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "NouvelleLocation";
			this.ShowInTaskbar = false;
			this.Text = "Nouvelle Location";
			this.Load += new System.EventHandler(this.NouvelleLocation_Load);
			this.tabControl3.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsComptes1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void button16_Click(object sender, System.EventArgs e)
		{
			textBox2.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
			textBox2.SelectionStart=textBox2.Text.Length;
			textBox2.Focus();
		}

		private void button23_Click(object sender, System.EventArgs e)
		{
			textBox2.Text+=" ";
			textBox2.SelectionStart=textBox2.Text.Length;
			textBox2.Focus();		
		}

		private void button21_Click(object sender, System.EventArgs e)
		{
		
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string STRSQL = 
			 "SELECT "+
	  "  Client.NomClient, "+
	  "  Client.PrenomClient"+
	" FROM"+
	  "  (Client INNER"+
	" JOIN"+
	" 	CompteJournalier ON"+
	" 	  CompteJournalier.RefClient = Client.NumClient) Where NumCompteJournalier = "+comboBox1.Text ;
if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)
	oleDbDataAdapter1.SelectCommand.Connection.Open();
	 	OleDbDataAdapter DA = new OleDbDataAdapter(STRSQL,oleDbDataAdapter1.SelectCommand.Connection.ConnectionString);
			DataSet ds = new DataSet();
			DA.Fill(ds);
			try
			{
				label3.Text=ds.Tables[0].Rows[0].ItemArray[0].ToString();
				label4.Text=ds.Tables[0].Rows[0].ItemArray[1].ToString();
			}
			catch(Exception exc){MessageBox.Show(exc.ToString());}
			
		}

		private void NouvelleLocation_Load(object sender, System.EventArgs e)
		{
			oleDbDataAdapter1.Fill(dsComptes1);
		}
	}
}
