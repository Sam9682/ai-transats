using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Configuration;
namespace Transacts
{
	/// <summary>
	/// Summary description for BaseNautique.
	/// </summary>
	public class Generale : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button addClient;
		private System.Windows.Forms.Button suppclient;
		private System.Windows.Forms.Button button81;
		private System.Windows.Forms.ToolTip Aidepopup;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button83;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button button84;
		private System.Windows.Forms.Button button85;
		private System.Windows.Forms.Button button86;
		private System.Windows.Forms.Button button87;
		private System.Windows.Forms.Button button88;
		private System.Windows.Forms.Button button89;
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
		private System.Windows.Forms.CheckBox Shift;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.CheckBox Shft;
		private System.Windows.Forms.Button btnLock;
		private System.Windows.Forms.Button button92;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private Transacts.dsClients dsClients1;
		private System.Windows.Forms.RadioButton rdNumCl;
		private System.Windows.Forms.RadioButton rdNomCl;
		private System.Windows.Forms.RadioButton rdPrenCl;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private Transacts.dsPersonnel dsPersonnel1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private System.Windows.Forms.RadioButton rdPrenEmp;
		private System.Windows.Forms.RadioButton rdNomEmp;
		private System.Windows.Forms.RadioButton rdIdEmp;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private Transacts.dsComptesJ dsComptesJ1;
		private System.Windows.Forms.Label lblnumCompte;
		private System.Windows.Forms.Label lblDateOuv;
		private System.Windows.Forms.Label lblDateFerm;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.FontDialog fontDialog;
		private String UserName;
		public Generale(string UserName)
		{
			//
			// Required for Windows Form Designer support
			//
			this.UserName=UserName;
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
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.rdPrenCl = new System.Windows.Forms.RadioButton();
			this.rdNomCl = new System.Windows.Forms.RadioButton();
			this.rdNumCl = new System.Windows.Forms.RadioButton();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dsClients1 = new Transacts.dsClients();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
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
			this.tabPage2 = new System.Windows.Forms.TabPage();
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
			this.Shift = new System.Windows.Forms.CheckBox();
			this.button81 = new System.Windows.Forms.Button();
			this.suppclient = new System.Windows.Forms.Button();
			this.addClient = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDateFerm = new System.Windows.Forms.Label();
			this.lblDateOuv = new System.Windows.Forms.Label();
			this.lblnumCompte = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.rdPrenEmp = new System.Windows.Forms.RadioButton();
			this.rdNomEmp = new System.Windows.Forms.RadioButton();
			this.rdIdEmp = new System.Windows.Forms.RadioButton();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.dsPersonnel1 = new Transacts.dsPersonnel();
			this.button92 = new System.Windows.Forms.Button();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
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
			this.Shft = new System.Windows.Forms.CheckBox();
			this.button83 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Aidepopup = new System.Windows.Forms.ToolTip(this.components);
			this.button84 = new System.Windows.Forms.Button();
			this.button85 = new System.Windows.Forms.Button();
			this.button86 = new System.Windows.Forms.Button();
			this.button87 = new System.Windows.Forms.Button();
			this.button88 = new System.Windows.Forms.Button();
			this.button89 = new System.Windows.Forms.Button();
			this.btnLock = new System.Windows.Forms.Button();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.dsComptesJ1 = new Transacts.dsComptesJ();
			this.btnExit = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.fontDialog = new System.Windows.Forms.FontDialog();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsClients1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPersonnel1)).BeginInit();
			this.tabControl3.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsComptesJ1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage3,
																					  this.tabPage4});
			this.tabControl2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabControl2.Location = new System.Drawing.Point(8, 8);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(752, 480);
			this.tabControl2.TabIndex = 8;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.rdPrenCl,
																				   this.rdNomCl,
																				   this.rdNumCl,
																				   this.dataGrid1,
																				   this.tabControl1,
																				   this.button81,
																				   this.suppclient,
																				   this.addClient,
																				   this.groupBox1,
																				   this.dateTimePicker1,
																				   this.textBox1});
			this.tabPage3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabPage3.Location = new System.Drawing.Point(4, 28);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(744, 448);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Infos Clients";
			// 
			// rdPrenCl
			// 
			this.rdPrenCl.Location = new System.Drawing.Point(72, 184);
			this.rdPrenCl.Name = "rdPrenCl";
			this.rdPrenCl.Size = new System.Drawing.Size(64, 16);
			this.rdPrenCl.TabIndex = 103;
			this.rdPrenCl.Text = "Pr�nom";
			// 
			// rdNomCl
			// 
			this.rdNomCl.Location = new System.Drawing.Point(16, 184);
			this.rdNomCl.Name = "rdNomCl";
			this.rdNomCl.Size = new System.Drawing.Size(48, 16);
			this.rdNomCl.TabIndex = 102;
			this.rdNomCl.Text = "Nom";
			// 
			// rdNumCl
			// 
			this.rdNumCl.Checked = true;
			this.rdNumCl.Location = new System.Drawing.Point(16, 160);
			this.rdNumCl.Name = "rdNumCl";
			this.rdNumCl.Size = new System.Drawing.Size(80, 16);
			this.rdNumCl.TabIndex = 101;
			this.rdNumCl.TabStop = true;
			this.rdNumCl.Text = "Identifiant";
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackColor = System.Drawing.SystemColors.Info;
			this.dataGrid1.BackgroundColor = System.Drawing.Color.Beige;
			this.dataGrid1.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid1.CaptionForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.CaptionText = "Liste des Clients";
			this.dataGrid1.DataMember = "Client";
			this.dataGrid1.DataSource = this.dsClients1;
			this.dataGrid1.HeaderBackColor = System.Drawing.SystemColors.ControlLight;
			this.dataGrid1.HeaderFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.PreferredColumnWidth = 100;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(736, 144);
			this.dataGrid1.TabIndex = 100;
			this.dataGrid1.Navigate += new System.Windows.Forms.NavigateEventHandler(this.dataGrid1_Navigate_1);
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// dsClients1
			// 
			this.dsClients1.DataSetName = "dsClients";
			this.dsClients1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsClients1.Namespace = "http://www.tempuri.org/dsClients.xsd";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2});
			this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabControl1.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.tabControl1.ItemSize = new System.Drawing.Size(66, 30);
			this.tabControl1.Location = new System.Drawing.Point(8, 208);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(440, 232);
			this.tabControl1.TabIndex = 99;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button1,
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
			this.tabPage1.Size = new System.Drawing.Size(432, 194);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Num";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(312, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 40);
			this.button1.TabIndex = 121;
			this.button1.Text = "EFF";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
			this.button39.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button30.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button31.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button32.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button33.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button34.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button35.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button36.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button37.Click += new System.EventHandler(this.button36_Click_1);
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
			this.button38.Click += new System.EventHandler(this.button36_Click_1);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
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
																				   this.button40,
																				   this.Shift});
			this.tabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabPage2.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.tabPage2.Location = new System.Drawing.Point(4, 34);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(432, 194);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Alpha";
			this.tabPage2.Visible = false;
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
			this.button42.Text = ":";
			this.button42.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button29.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button20.Click += new System.EventHandler(this.button12_Click_1);
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.Cornsilk;
			this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button21.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button21.Location = new System.Drawing.Point(296, 88);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(120, 40);
			this.button21.TabIndex = 120;
			this.button21.Text = "EFF";
			this.button21.Click += new System.EventHandler(this.button21_Click_2);
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
			this.button22.Click += new System.EventHandler(this.button12_Click_1);
			// 
			// button23
			// 
			this.button23.BackColor = System.Drawing.Color.Cornsilk;
			this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button23.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button23.Location = new System.Drawing.Point(96, 128);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(320, 32);
			this.button23.TabIndex = 118;
			this.button23.Text = "Espace";
			this.button23.Click += new System.EventHandler(this.button23_Click_1);
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
			this.button24.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button25.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button26.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button27.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button28.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button11.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button12.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button13.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button14.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button15.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button16.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button17.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button18.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button19.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button10.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button9.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button8.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button7.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button6.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button5.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button4.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button3.Click += new System.EventHandler(this.button12_Click_1);
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
			this.button40.Click += new System.EventHandler(this.button12_Click_1);
			// 
			// Shift
			// 
			this.Shift.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Shift.Location = new System.Drawing.Point(16, 136);
			this.Shift.Name = "Shift";
			this.Shift.Size = new System.Drawing.Size(80, 24);
			this.Shift.TabIndex = 124;
			this.Shift.Text = "Shift";
			// 
			// button81
			// 
			this.button81.BackColor = System.Drawing.Color.Cornsilk;
			this.button81.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button81.Location = new System.Drawing.Point(456, 352);
			this.button81.Name = "button81";
			this.button81.Size = new System.Drawing.Size(136, 40);
			this.button81.TabIndex = 97;
			this.button81.Text = "Ajouter Compte";
			this.button81.Click += new System.EventHandler(this.button81_Click_1);
			// 
			// suppclient
			// 
			this.suppclient.BackColor = System.Drawing.Color.Cornsilk;
			this.suppclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.suppclient.Location = new System.Drawing.Point(456, 400);
			this.suppclient.Name = "suppclient";
			this.suppclient.Size = new System.Drawing.Size(272, 40);
			this.suppclient.TabIndex = 96;
			this.suppclient.Text = "Supprimer S�lection";
			this.suppclient.Click += new System.EventHandler(this.suppclient_Click_1);
			// 
			// addClient
			// 
			this.addClient.BackColor = System.Drawing.Color.Cornsilk;
			this.addClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addClient.Location = new System.Drawing.Point(600, 352);
			this.addClient.Name = "addClient";
			this.addClient.Size = new System.Drawing.Size(128, 40);
			this.addClient.TabIndex = 95;
			this.addClient.Text = "Ajouter/ Modifier Client";
			this.addClient.Click += new System.EventHandler(this.addClient_Click_1);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label3,
																					this.label2,
																					this.label1,
																					this.lblDateFerm,
																					this.lblDateOuv,
																					this.lblnumCompte});
			this.groupBox1.Location = new System.Drawing.Point(456, 160);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 176);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Compte Journalier";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Date Cl�ture";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Num�ro Compte";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Date Ouverture";
			// 
			// lblDateFerm
			// 
			this.lblDateFerm.Location = new System.Drawing.Point(136, 128);
			this.lblDateFerm.Name = "lblDateFerm";
			this.lblDateFerm.Size = new System.Drawing.Size(128, 32);
			this.lblDateFerm.TabIndex = 2;
			// 
			// lblDateOuv
			// 
			this.lblDateOuv.Location = new System.Drawing.Point(136, 80);
			this.lblDateOuv.Name = "lblDateOuv";
			this.lblDateOuv.Size = new System.Drawing.Size(128, 32);
			this.lblDateOuv.TabIndex = 1;
			// 
			// lblnumCompte
			// 
			this.lblnumCompte.Location = new System.Drawing.Point(136, 32);
			this.lblnumCompte.Name = "lblnumCompte";
			this.lblnumCompte.Size = new System.Drawing.Size(128, 32);
			this.lblnumCompte.TabIndex = 0;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(784, 416);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(16, 22);
			this.dateTimePicker1.TabIndex = 12;
			this.dateTimePicker1.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.textBox1.Location = new System.Drawing.Point(144, 160);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(304, 33);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.rdPrenEmp,
																				   this.rdNomEmp,
																				   this.rdIdEmp,
																				   this.dataGrid2,
																				   this.button92,
																				   this.tabControl3,
																				   this.button83,
																				   this.textBox3});
			this.tabPage4.Location = new System.Drawing.Point(4, 28);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(744, 448);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Infos Personnel";
			this.tabPage4.Visible = false;
			// 
			// rdPrenEmp
			// 
			this.rdPrenEmp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rdPrenEmp.Location = new System.Drawing.Point(536, 256);
			this.rdPrenEmp.Name = "rdPrenEmp";
			this.rdPrenEmp.Size = new System.Drawing.Size(72, 16);
			this.rdPrenEmp.TabIndex = 106;
			this.rdPrenEmp.Text = "Pr�nom";
			// 
			// rdNomEmp
			// 
			this.rdNomEmp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rdNomEmp.Location = new System.Drawing.Point(472, 256);
			this.rdNomEmp.Name = "rdNomEmp";
			this.rdNomEmp.Size = new System.Drawing.Size(56, 16);
			this.rdNomEmp.TabIndex = 105;
			this.rdNomEmp.Text = "Nom";
			// 
			// rdIdEmp
			// 
			this.rdIdEmp.Checked = true;
			this.rdIdEmp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rdIdEmp.Location = new System.Drawing.Point(472, 232);
			this.rdIdEmp.Name = "rdIdEmp";
			this.rdIdEmp.Size = new System.Drawing.Size(96, 16);
			this.rdIdEmp.TabIndex = 104;
			this.rdIdEmp.TabStop = true;
			this.rdIdEmp.Text = "Identifiant";
			// 
			// dataGrid2
			// 
			this.dataGrid2.AlternatingBackColor = System.Drawing.SystemColors.Info;
			this.dataGrid2.BackgroundColor = System.Drawing.Color.Beige;
			this.dataGrid2.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid2.CaptionForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.CaptionText = "Liste  Personnel";
			this.dataGrid2.DataMember = "Employe";
			this.dataGrid2.DataSource = this.dsPersonnel1;
			this.dataGrid2.Font = new System.Drawing.Font("Tahoma", 9F);
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(8, 8);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.ReadOnly = true;
			this.dataGrid2.Size = new System.Drawing.Size(736, 200);
			this.dataGrid2.TabIndex = 103;
			// 
			// dsPersonnel1
			// 
			this.dsPersonnel1.DataSetName = "dsPersonnel";
			this.dsPersonnel1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsPersonnel1.Namespace = "http://www.tempuri.org/dsPersonnel.xsd";
			// 
			// button92
			// 
			this.button92.BackColor = System.Drawing.Color.Cornsilk;
			this.button92.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button92.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button92.Location = new System.Drawing.Point(536, 384);
			this.button92.Name = "button92";
			this.button92.Size = new System.Drawing.Size(128, 40);
			this.button92.TabIndex = 102;
			this.button92.Text = "Supprimer S�lection";
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage5,
																					  this.tabPage6});
			this.tabControl3.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.tabControl3.Location = new System.Drawing.Point(8, 216);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(440, 224);
			this.tabControl3.TabIndex = 101;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button2,
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
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(320, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 40);
			this.button2.TabIndex = 122;
			this.button2.Text = "EFF";
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button41
			// 
			this.button41.BackColor = System.Drawing.Color.Cornsilk;
			this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button41.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button41.Location = new System.Drawing.Point(232, 16);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(72, 160);
			this.button41.TabIndex = 102;
			this.button41.Text = "0";
			this.button41.Click += new System.EventHandler(this.button48_Click);
			// 
			// button43
			// 
			this.button43.BackColor = System.Drawing.Color.Cornsilk;
			this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button43.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button43.Location = new System.Drawing.Point(176, 128);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(50, 50);
			this.button43.TabIndex = 101;
			this.button43.Text = "3";
			this.button43.Click += new System.EventHandler(this.button48_Click);
			// 
			// button44
			// 
			this.button44.BackColor = System.Drawing.Color.Cornsilk;
			this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button44.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button44.Location = new System.Drawing.Point(120, 128);
			this.button44.Name = "button44";
			this.button44.Size = new System.Drawing.Size(50, 50);
			this.button44.TabIndex = 100;
			this.button44.Text = "2";
			this.button44.Click += new System.EventHandler(this.button48_Click);
			// 
			// button45
			// 
			this.button45.BackColor = System.Drawing.Color.Cornsilk;
			this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button45.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button45.Location = new System.Drawing.Point(64, 128);
			this.button45.Name = "button45";
			this.button45.Size = new System.Drawing.Size(50, 50);
			this.button45.TabIndex = 99;
			this.button45.Text = "1";
			this.button45.Click += new System.EventHandler(this.button48_Click);
			// 
			// button46
			// 
			this.button46.BackColor = System.Drawing.Color.Cornsilk;
			this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button46.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button46.Location = new System.Drawing.Point(176, 72);
			this.button46.Name = "button46";
			this.button46.Size = new System.Drawing.Size(50, 50);
			this.button46.TabIndex = 98;
			this.button46.Text = "6";
			this.button46.Click += new System.EventHandler(this.button48_Click);
			// 
			// button47
			// 
			this.button47.BackColor = System.Drawing.Color.Cornsilk;
			this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button47.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button47.Location = new System.Drawing.Point(120, 72);
			this.button47.Name = "button47";
			this.button47.Size = new System.Drawing.Size(50, 50);
			this.button47.TabIndex = 97;
			this.button47.Text = "5";
			this.button47.Click += new System.EventHandler(this.button48_Click);
			// 
			// button48
			// 
			this.button48.BackColor = System.Drawing.Color.Cornsilk;
			this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button48.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button48.Location = new System.Drawing.Point(64, 72);
			this.button48.Name = "button48";
			this.button48.Size = new System.Drawing.Size(50, 50);
			this.button48.TabIndex = 96;
			this.button48.Text = "4";
			this.button48.Click += new System.EventHandler(this.button48_Click);
			// 
			// button49
			// 
			this.button49.BackColor = System.Drawing.Color.Cornsilk;
			this.button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button49.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button49.Location = new System.Drawing.Point(176, 16);
			this.button49.Name = "button49";
			this.button49.Size = new System.Drawing.Size(50, 50);
			this.button49.TabIndex = 95;
			this.button49.Text = "9";
			this.button49.Click += new System.EventHandler(this.button48_Click);
			// 
			// button50
			// 
			this.button50.BackColor = System.Drawing.Color.Cornsilk;
			this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button50.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button50.Location = new System.Drawing.Point(120, 16);
			this.button50.Name = "button50";
			this.button50.Size = new System.Drawing.Size(50, 50);
			this.button50.TabIndex = 94;
			this.button50.Text = "8";
			this.button50.Click += new System.EventHandler(this.button48_Click);
			// 
			// button51
			// 
			this.button51.BackColor = System.Drawing.Color.Cornsilk;
			this.button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button51.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button51.Location = new System.Drawing.Point(64, 16);
			this.button51.Name = "button51";
			this.button51.Size = new System.Drawing.Size(50, 50);
			this.button51.TabIndex = 93;
			this.button51.Text = "7";
			this.button51.Click += new System.EventHandler(this.button48_Click);
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
																				   this.Shft});
			this.tabPage6.Location = new System.Drawing.Point(4, 34);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(432, 186);
			this.tabPage6.TabIndex = 1;
			this.tabPage6.Text = "Alpha";
			this.tabPage6.Visible = false;
			// 
			// button52
			// 
			this.button52.BackColor = System.Drawing.Color.Cornsilk;
			this.button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button52.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button52.Location = new System.Drawing.Point(256, 88);
			this.button52.Name = "button52";
			this.button52.Size = new System.Drawing.Size(40, 40);
			this.button52.TabIndex = 123;
			this.button52.Text = ":";
			this.button52.Click += new System.EventHandler(this.button73_Click);
			// 
			// button53
			// 
			this.button53.BackColor = System.Drawing.Color.Cornsilk;
			this.button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button53.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button53.Location = new System.Drawing.Point(376, 8);
			this.button53.Name = "button53";
			this.button53.Size = new System.Drawing.Size(40, 40);
			this.button53.TabIndex = 122;
			this.button53.Text = "P";
			this.button53.Click += new System.EventHandler(this.button73_Click);
			// 
			// button54
			// 
			this.button54.BackColor = System.Drawing.Color.Cornsilk;
			this.button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button54.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button54.Location = new System.Drawing.Point(376, 48);
			this.button54.Name = "button54";
			this.button54.Size = new System.Drawing.Size(40, 40);
			this.button54.TabIndex = 121;
			this.button54.Text = "M";
			this.button54.Click += new System.EventHandler(this.button73_Click);
			// 
			// button55
			// 
			this.button55.BackColor = System.Drawing.Color.Cornsilk;
			this.button55.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button55.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button55.Location = new System.Drawing.Point(296, 88);
			this.button55.Name = "button55";
			this.button55.Size = new System.Drawing.Size(120, 40);
			this.button55.TabIndex = 120;
			this.button55.Text = "EFF";
			this.button55.Click += new System.EventHandler(this.button55_Click_1);
			// 
			// button56
			// 
			this.button56.BackColor = System.Drawing.Color.Cornsilk;
			this.button56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button56.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button56.Location = new System.Drawing.Point(216, 88);
			this.button56.Name = "button56";
			this.button56.Size = new System.Drawing.Size(40, 40);
			this.button56.TabIndex = 119;
			this.button56.Text = "N";
			this.button56.Click += new System.EventHandler(this.button73_Click);
			// 
			// button57
			// 
			this.button57.BackColor = System.Drawing.Color.Cornsilk;
			this.button57.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button57.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button57.Location = new System.Drawing.Point(96, 128);
			this.button57.Name = "button57";
			this.button57.Size = new System.Drawing.Size(320, 32);
			this.button57.TabIndex = 118;
			this.button57.Text = "Espace";
			this.button57.Click += new System.EventHandler(this.button57_Click_1);
			// 
			// button58
			// 
			this.button58.BackColor = System.Drawing.Color.Cornsilk;
			this.button58.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button58.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button58.Location = new System.Drawing.Point(176, 88);
			this.button58.Name = "button58";
			this.button58.Size = new System.Drawing.Size(40, 40);
			this.button58.TabIndex = 117;
			this.button58.Text = "B";
			this.button58.Click += new System.EventHandler(this.button73_Click);
			// 
			// button59
			// 
			this.button59.BackColor = System.Drawing.Color.Cornsilk;
			this.button59.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button59.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button59.Location = new System.Drawing.Point(136, 88);
			this.button59.Name = "button59";
			this.button59.Size = new System.Drawing.Size(40, 40);
			this.button59.TabIndex = 116;
			this.button59.Text = "V";
			this.button59.Click += new System.EventHandler(this.button73_Click);
			// 
			// button60
			// 
			this.button60.BackColor = System.Drawing.Color.Cornsilk;
			this.button60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button60.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button60.Location = new System.Drawing.Point(96, 88);
			this.button60.Name = "button60";
			this.button60.Size = new System.Drawing.Size(40, 40);
			this.button60.TabIndex = 115;
			this.button60.Text = "C";
			this.button60.Click += new System.EventHandler(this.button73_Click);
			// 
			// button61
			// 
			this.button61.BackColor = System.Drawing.Color.Cornsilk;
			this.button61.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button61.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button61.Location = new System.Drawing.Point(56, 88);
			this.button61.Name = "button61";
			this.button61.Size = new System.Drawing.Size(40, 40);
			this.button61.TabIndex = 114;
			this.button61.Text = "X";
			this.button61.Click += new System.EventHandler(this.button73_Click);
			// 
			// button62
			// 
			this.button62.BackColor = System.Drawing.Color.Cornsilk;
			this.button62.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button62.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button62.Location = new System.Drawing.Point(16, 88);
			this.button62.Name = "button62";
			this.button62.Size = new System.Drawing.Size(40, 40);
			this.button62.TabIndex = 113;
			this.button62.Text = "W";
			this.button62.Click += new System.EventHandler(this.button73_Click);
			// 
			// button63
			// 
			this.button63.BackColor = System.Drawing.Color.Cornsilk;
			this.button63.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button63.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button63.Location = new System.Drawing.Point(336, 48);
			this.button63.Name = "button63";
			this.button63.Size = new System.Drawing.Size(40, 40);
			this.button63.TabIndex = 112;
			this.button63.Text = "L";
			this.button63.Click += new System.EventHandler(this.button73_Click);
			// 
			// button64
			// 
			this.button64.BackColor = System.Drawing.Color.Cornsilk;
			this.button64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button64.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button64.Location = new System.Drawing.Point(296, 48);
			this.button64.Name = "button64";
			this.button64.Size = new System.Drawing.Size(40, 40);
			this.button64.TabIndex = 111;
			this.button64.Text = "K";
			this.button64.Click += new System.EventHandler(this.button73_Click);
			// 
			// button65
			// 
			this.button65.BackColor = System.Drawing.Color.Cornsilk;
			this.button65.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button65.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button65.Location = new System.Drawing.Point(256, 48);
			this.button65.Name = "button65";
			this.button65.Size = new System.Drawing.Size(40, 40);
			this.button65.TabIndex = 110;
			this.button65.Text = "J";
			this.button65.Click += new System.EventHandler(this.button73_Click);
			// 
			// button66
			// 
			this.button66.BackColor = System.Drawing.Color.Cornsilk;
			this.button66.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button66.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button66.Location = new System.Drawing.Point(216, 48);
			this.button66.Name = "button66";
			this.button66.Size = new System.Drawing.Size(40, 40);
			this.button66.TabIndex = 109;
			this.button66.Text = "H";
			this.button66.Click += new System.EventHandler(this.button73_Click);
			// 
			// button67
			// 
			this.button67.BackColor = System.Drawing.Color.Cornsilk;
			this.button67.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button67.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button67.Location = new System.Drawing.Point(176, 48);
			this.button67.Name = "button67";
			this.button67.Size = new System.Drawing.Size(40, 40);
			this.button67.TabIndex = 108;
			this.button67.Text = "G";
			this.button67.Click += new System.EventHandler(this.button73_Click);
			// 
			// button68
			// 
			this.button68.BackColor = System.Drawing.Color.Cornsilk;
			this.button68.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button68.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button68.Location = new System.Drawing.Point(136, 48);
			this.button68.Name = "button68";
			this.button68.Size = new System.Drawing.Size(40, 40);
			this.button68.TabIndex = 107;
			this.button68.Text = "F";
			this.button68.Click += new System.EventHandler(this.button73_Click);
			// 
			// button69
			// 
			this.button69.BackColor = System.Drawing.Color.Cornsilk;
			this.button69.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button69.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button69.Location = new System.Drawing.Point(96, 48);
			this.button69.Name = "button69";
			this.button69.Size = new System.Drawing.Size(40, 40);
			this.button69.TabIndex = 106;
			this.button69.Text = "D";
			this.button69.Click += new System.EventHandler(this.button73_Click);
			// 
			// button70
			// 
			this.button70.BackColor = System.Drawing.Color.Cornsilk;
			this.button70.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button70.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button70.Location = new System.Drawing.Point(56, 48);
			this.button70.Name = "button70";
			this.button70.Size = new System.Drawing.Size(40, 40);
			this.button70.TabIndex = 105;
			this.button70.Text = "S";
			this.button70.Click += new System.EventHandler(this.button73_Click);
			// 
			// button71
			// 
			this.button71.BackColor = System.Drawing.Color.Cornsilk;
			this.button71.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button71.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button71.Location = new System.Drawing.Point(16, 48);
			this.button71.Name = "button71";
			this.button71.Size = new System.Drawing.Size(40, 40);
			this.button71.TabIndex = 104;
			this.button71.Text = "Q";
			this.button71.Click += new System.EventHandler(this.button73_Click);
			// 
			// button72
			// 
			this.button72.BackColor = System.Drawing.Color.Cornsilk;
			this.button72.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button72.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button72.Location = new System.Drawing.Point(336, 8);
			this.button72.Name = "button72";
			this.button72.Size = new System.Drawing.Size(40, 40);
			this.button72.TabIndex = 103;
			this.button72.Text = "O";
			this.button72.Click += new System.EventHandler(this.button73_Click);
			// 
			// button73
			// 
			this.button73.BackColor = System.Drawing.Color.Cornsilk;
			this.button73.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button73.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button73.Location = new System.Drawing.Point(296, 8);
			this.button73.Name = "button73";
			this.button73.Size = new System.Drawing.Size(40, 40);
			this.button73.TabIndex = 102;
			this.button73.Text = "I";
			this.button73.Click += new System.EventHandler(this.button73_Click);
			// 
			// button74
			// 
			this.button74.BackColor = System.Drawing.Color.Cornsilk;
			this.button74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button74.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button74.Location = new System.Drawing.Point(256, 8);
			this.button74.Name = "button74";
			this.button74.Size = new System.Drawing.Size(40, 40);
			this.button74.TabIndex = 101;
			this.button74.Text = "U";
			this.button74.Click += new System.EventHandler(this.button73_Click);
			// 
			// button75
			// 
			this.button75.BackColor = System.Drawing.Color.Cornsilk;
			this.button75.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button75.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button75.Location = new System.Drawing.Point(216, 8);
			this.button75.Name = "button75";
			this.button75.Size = new System.Drawing.Size(40, 40);
			this.button75.TabIndex = 100;
			this.button75.Text = "Y";
			this.button75.Click += new System.EventHandler(this.button73_Click);
			// 
			// button76
			// 
			this.button76.BackColor = System.Drawing.Color.Cornsilk;
			this.button76.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button76.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button76.Location = new System.Drawing.Point(176, 8);
			this.button76.Name = "button76";
			this.button76.Size = new System.Drawing.Size(40, 40);
			this.button76.TabIndex = 99;
			this.button76.Text = "T";
			this.button76.Click += new System.EventHandler(this.button73_Click);
			// 
			// button77
			// 
			this.button77.BackColor = System.Drawing.Color.Cornsilk;
			this.button77.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button77.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button77.Location = new System.Drawing.Point(136, 8);
			this.button77.Name = "button77";
			this.button77.Size = new System.Drawing.Size(40, 40);
			this.button77.TabIndex = 98;
			this.button77.Text = "R";
			this.button77.Click += new System.EventHandler(this.button73_Click);
			// 
			// button78
			// 
			this.button78.BackColor = System.Drawing.Color.Cornsilk;
			this.button78.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button78.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button78.Location = new System.Drawing.Point(96, 8);
			this.button78.Name = "button78";
			this.button78.Size = new System.Drawing.Size(40, 40);
			this.button78.TabIndex = 97;
			this.button78.Text = "E";
			this.button78.Click += new System.EventHandler(this.button73_Click);
			// 
			// button79
			// 
			this.button79.BackColor = System.Drawing.Color.Cornsilk;
			this.button79.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button79.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button79.Location = new System.Drawing.Point(56, 8);
			this.button79.Name = "button79";
			this.button79.Size = new System.Drawing.Size(40, 40);
			this.button79.TabIndex = 96;
			this.button79.Text = "Z";
			this.button79.Click += new System.EventHandler(this.button73_Click);
			// 
			// button80
			// 
			this.button80.BackColor = System.Drawing.Color.Cornsilk;
			this.button80.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button80.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button80.Location = new System.Drawing.Point(16, 8);
			this.button80.Name = "button80";
			this.button80.Size = new System.Drawing.Size(40, 40);
			this.button80.TabIndex = 95;
			this.button80.Text = "A";
			this.button80.Click += new System.EventHandler(this.button73_Click);
			// 
			// Shft
			// 
			this.Shft.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Shft.Location = new System.Drawing.Point(16, 136);
			this.Shft.Name = "Shft";
			this.Shft.Size = new System.Drawing.Size(80, 24);
			this.Shft.TabIndex = 124;
			this.Shft.Text = "Shift";
			// 
			// button83
			// 
			this.button83.BackColor = System.Drawing.Color.Cornsilk;
			this.button83.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button83.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button83.Location = new System.Drawing.Point(536, 328);
			this.button83.Name = "button83";
			this.button83.Size = new System.Drawing.Size(128, 40);
			this.button83.TabIndex = 97;
			this.button83.Text = "Ajouter ";
			this.button83.Click += new System.EventHandler(this.button83_Click_1);
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Font = new System.Drawing.Font("Tahoma", 15.75F);
			this.textBox3.Location = new System.Drawing.Point(472, 280);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(264, 33);
			this.textBox3.TabIndex = 16;
			this.textBox3.Text = "";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// Aidepopup
			// 
			this.Aidepopup.AutomaticDelay = 10;
			// 
			// button84
			// 
			this.button84.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button84.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button84.Location = new System.Drawing.Point(656, 496);
			this.button84.Name = "button84";
			this.button84.Size = new System.Drawing.Size(104, 56);
			this.button84.TabIndex = 15;
			this.button84.Text = "Plage";
			this.button84.Click += new System.EventHandler(this.button84_Click_1);
			// 
			// button85
			// 
			this.button85.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button85.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button85.Location = new System.Drawing.Point(392, 496);
			this.button85.Name = "button85";
			this.button85.Size = new System.Drawing.Size(128, 56);
			this.button85.TabIndex = 16;
			this.button85.Text = "Restaurant";
			this.button85.Click += new System.EventHandler(this.button85_Click);
			// 
			// button86
			// 
			this.button86.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button86.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button86.Location = new System.Drawing.Point(264, 496);
			this.button86.Name = "button86";
			this.button86.Size = new System.Drawing.Size(128, 56);
			this.button86.TabIndex = 17;
			this.button86.Text = "Bar";
			this.button86.Click += new System.EventHandler(this.button86_Click);
			// 
			// button87
			// 
			this.button87.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button87.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button87.Location = new System.Drawing.Point(136, 496);
			this.button87.Name = "button87";
			this.button87.Size = new System.Drawing.Size(128, 56);
			this.button87.TabIndex = 18;
			this.button87.Text = "Snack";
			this.button87.Click += new System.EventHandler(this.button87_Click);
			// 
			// button88
			// 
			this.button88.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button88.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button88.Location = new System.Drawing.Point(520, 496);
			this.button88.Name = "button88";
			this.button88.Size = new System.Drawing.Size(136, 56);
			this.button88.TabIndex = 19;
			this.button88.Text = "Base Nautique";
			this.button88.Click += new System.EventHandler(this.button88_Click);
			// 
			// button89
			// 
			this.button89.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button89.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button89.Location = new System.Drawing.Point(8, 496);
			this.button89.Name = "button89";
			this.button89.Size = new System.Drawing.Size(128, 56);
			this.button89.TabIndex = 20;
			this.button89.Text = " Boutique";
			this.button89.Click += new System.EventHandler(this.button89_Click);
			// 
			// btnLock
			// 
			this.btnLock.BackColor = System.Drawing.Color.Cornsilk;
			this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLock.Location = new System.Drawing.Point(624, 0);
			this.btnLock.Name = "btnLock";
			this.btnLock.Size = new System.Drawing.Size(64, 32);
			this.btnLock.TabIndex = 21;
			this.btnLock.Text = "Lock";
			this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Client", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("Identifiant Client", "Identifiant Client"),
																																																				  new System.Data.Common.DataColumnMapping("Nom Client", "Nom Client"),
																																																				  new System.Data.Common.DataColumnMapping("Pr�nom Client", "Pr�nom Client"),
																																																				  new System.Data.Common.DataColumnMapping("T�l / Mobile", "T�l / Mobile"),
																																																				  new System.Data.Common.DataColumnMapping("Adresse", "Adresse"),
																																																				  new System.Data.Common.DataColumnMapping("e-Mail", "e-Mail")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM Client WHERE (NumClient = ?) AND (AdresseClient = ? OR ? IS NULL AND AdresseClient IS NULL) AND (MailClient = ? OR ? IS NULL AND MailClient IS NULL) AND (NomClient = ? OR ? IS NULL AND NomClient IS NULL) AND (PrenomClient = ? OR ? IS NULL AND PrenomClient IS NULL) AND (TelClient = ? OR ? IS NULL AND TelClient IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Identifiant Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AdresseClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "e-Mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_MailClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "e-Mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pr�nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pr�nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T�l / Mobile", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T�l / Mobile", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Client(NumClient, NomClient, PrenomClient, TelClient, AdresseClient, " +
				"MailClient) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Identifiant Client", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Pr�nom Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, "T�l / Mobile"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Adresse"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, "e-Mail"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT NumClient AS [Identifiant Client], NomClient AS [Nom Client], PrenomClient" +
				" AS [Pr�nom Client], TelClient AS [T�l / Mobile], AdresseClient AS Adresse, Mail" +
				"Client AS [e-Mail] FROM Client";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Client SET NumClient = ?, NomClient = ?, PrenomClient = ?, TelClient = ?, AdresseClient = ?, MailClient = ? WHERE (NumClient = ?) AND (AdresseClient = ? OR ? IS NULL AND AdresseClient IS NULL) AND (MailClient = ? OR ? IS NULL AND MailClient IS NULL) AND (NomClient = ? OR ? IS NULL AND NomClient IS NULL) AND (PrenomClient = ? OR ? IS NULL AND PrenomClient IS NULL) AND (TelClient = ? OR ? IS NULL AND TelClient IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Identifiant Client", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Pr�nom Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, "T�l / Mobile"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Adresse"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, "e-Mail"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Identifiant Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AdresseClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "e-Mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_MailClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "e-Mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pr�nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pr�nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T�l / Mobile", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "T�l / Mobile", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Employe", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Identifiant Employ�", "Identifiant Employ�"),
																																																				   new System.Data.Common.DataColumnMapping("Nom Employ�", "Nom Employ�"),
																																																				   new System.Data.Common.DataColumnMapping("Pr�nom Employ�", "Pr�nom Employ�"),
																																																				   new System.Data.Common.DataColumnMapping("Tel / Mobile", "Tel / Mobile"),
																																																				   new System.Data.Common.DataColumnMapping("Poste Courant", "Poste Courant"),
																																																				   new System.Data.Common.DataColumnMapping("Salaire", "Salaire")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM Employe WHERE (NumEmploye = ?) AND (NomEmploye = ? OR ? IS NULL AND NomEmploye IS NULL) AND (PrenomEmploye = ? OR ? IS NULL AND PrenomEmploye IS NULL) AND (Salaire = ? OR ? IS NULL AND Salaire IS NULL) AND (TelEmploye = ? OR ? IS NULL AND TelEmploye IS NULL) AND (poste = ? OR ? IS NULL AND poste IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "Identifiant Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomEmploye1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pr�nom Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomEmploye1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pr�nom Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salaire", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Salaire", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salaire1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Salaire", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel / Mobile", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelEmploye1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel / Mobile", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_poste", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Poste Courant", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_poste1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Poste Courant", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Employe(NumEmploye, NomEmploye, PrenomEmploye, TelEmploye, poste, Sal" +
				"aire) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "Identifiant Employ�", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Employ�"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrenomEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, "Pr�nom Employ�"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("TelEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, "Tel / Mobile"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("poste", System.Data.OleDb.OleDbType.VarWChar, 50, "Poste Courant"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Salaire", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Salaire", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT NumEmploye AS [Identifiant Employ�], NomEmploye AS [Nom Employ�], PrenomEm" +
				"ploye AS [Pr�nom Employ�], TelEmploye AS [Tel / Mobile], poste AS [Poste Courant" +
				"], Salaire AS Salaire FROM Employe";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE Employe SET NumEmploye = ?, NomEmploye = ?, PrenomEmploye = ?, TelEmploye = ?, poste = ?, Salaire = ? WHERE (NumEmploye = ?) AND (NomEmploye = ? OR ? IS NULL AND NomEmploye IS NULL) AND (PrenomEmploye = ? OR ? IS NULL AND PrenomEmploye IS NULL) AND (Salaire = ? OR ? IS NULL AND Salaire IS NULL) AND (TelEmploye = ? OR ? IS NULL AND TelEmploye IS NULL) AND (poste = ? OR ? IS NULL AND poste IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "Identifiant Employ�", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Employ�"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrenomEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, "Pr�nom Employ�"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("TelEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, "Tel / Mobile"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("poste", System.Data.OleDb.OleDbType.VarWChar, 50, "Poste Courant"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Salaire", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Salaire", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "Identifiant Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomEmploye1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pr�nom Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomEmploye1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Pr�nom Employ�", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salaire", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Salaire", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Salaire1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Salaire", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelEmploye", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel / Mobile", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelEmploye1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel / Mobile", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_poste", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Poste Courant", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_poste1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Poste Courant", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Client", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("DateCloture", "DateCloture"),
																																																				  new System.Data.Common.DataColumnMapping("DateOuvertureCompte", "DateOuvertureCompte"),
																																																				  new System.Data.Common.DataColumnMapping("NumCompteJournalier", "NumCompteJournalier"),
																																																				  new System.Data.Common.DataColumnMapping("NumClient", "NumClient")})});
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = "SELECT CompteJournalier.DateCloture, CompteJournalier.DateOuvertureCompte, Compte" +
				"Journalier.NumCompteJournalier, Client.NumClient FROM (Client INNER JOIN CompteJ" +
				"ournalier ON Client.NumClient = CompteJournalier.RefClient)";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// dsComptesJ1
			// 
			this.dsComptesJ1.DataSetName = "dsComptesJ";
			this.dsComptesJ1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsComptesJ1.Namespace = "http://www.tempuri.org/dsComptesJ.xsd";
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Cornsilk;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(696, 0);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(64, 32);
			this.btnExit.TabIndex = 22;
			this.btnExit.Text = "Quitter";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "Param�tres";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Police des caract�res";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Infos Soci�t�";
			// 
			// Generale
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(806, 560);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnExit,
																		  this.btnLock,
																		  this.button89,
																		  this.button88,
																		  this.button87,
																		  this.button86,
																		  this.button85,
																		  this.button84,
																		  this.tabControl2});
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Generale";
			this.Text = "G�n�rale";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Generale_Load);
			this.Activated += new System.EventHandler(this.Generale_Activated);
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsClients1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsPersonnel1)).EndInit();
			this.tabControl3.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsComptesJ1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		string strconn="Provider=Microsoft.Jet.OLEDB.4.0;Data source=ZenithPlage.mdb";
		OleDbConnection conn;
		private void Generale_Load(object sender, System.EventArgs e)
		{
			ConsoleLogger.WriteLine("Starting Generale form load");
			conn =new OleDbConnection(strconn);
			
			try
			{
				ConsoleLogger.WriteLine("Opening database connections");
				conn.Open();
				oleDbConnection1.Open();
				ConsoleLogger.WriteLine("Database connections opened successfully");
			}
			catch(Exception ex) 
			{
				ConsoleLogger.WriteError($"Failed to open database connections: {ex.Message}");
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(rdNumCl.Checked)
				FilterClient("NumClient",textBox1.Text);
			if(rdNomCl.Checked)
				FilterClient("NomClient",textBox1.Text);
			if(rdPrenCl.Checked)
				FilterClient("PrenomClient",textBox1.Text);
			try
			{
				oleDbDataAdapter1.Fill(dsClients1);
				dataGrid1.Refresh();
				oleDbDataAdapter2.Fill(dsPersonnel1);
				dataGrid2.Refresh();
				oleDbDataAdapter3.Fill(dsComptesJ1);
				FilterComptes(dsClients1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[0].ToString());
			}
			catch(Exception exc){;;}
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
			

		}

		private void label6_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label1_MouseHover(object sender, System.EventArgs e)
		{
			
		}

		private void label1_MouseLeave(object sender, System.EventArgs e)
		{
			
		
		}

		private void label1_Click(object sender, System.EventArgs e)
		{

		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.Text="GENERAL Utilisateur : "+ UserName+ " "+ dateTimePicker1.Value.ToString();
			
		}

		private void label20_MouseHover(object sender, System.EventArgs e)
		{
			
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
			
		}

		private void label4_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label5_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label3_MouseHover(object sender, System.EventArgs e)
		{
			
		}

		private void label3_MouseLeave(object sender, System.EventArgs e)
		{
			
		}

		private void Shift_CheckedChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button37_Click(object sender, System.EventArgs e)
		{
			textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}

		private void button21_Click(object sender, System.EventArgs e)
		{
			textBox1.Text="";
		}

		private void suppclient_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button85_Click(object sender, System.EventArgs e)
		{
			Restaurant Res =new Restaurant();
			this.Hide();
			Res.Show();
		}

		private void button84_Click(object sender, System.EventArgs e)
		{
			
		}

		private void Generale_Closed(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void button90_Click(object sender, System.EventArgs e)
		{

		}

		private void addClient_Click(object sender, System.EventArgs e)
		{

			
		}

		private void button43_Click(object sender, System.EventArgs e)
		{
			textBox3.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}

		private void button70_Click(object sender, System.EventArgs e)
		{
			if (Shft.Checked==true)
				textBox3.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
			else
				textBox3.Text+=sender.ToString().Substring(sender.ToString().Length-1,1).ToLower();
		}

		private void button13_Click(object sender, System.EventArgs e)
		{
			if (Shift.Checked==true)
				textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
			else
				textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1).ToLower();
		}

		private void button38_Click(object sender, System.EventArgs e)
		{
			textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}
		private void Locker()
		{
			foreach (Control c in this.Controls) 
			{
				if (c!=btnLock)  
					c.Enabled=false;    
			}
		}
		private void Unlock()
		{
			foreach (Control c in this.Controls) 
			
				c.Enabled=true;    
			
			
		}
		bool locked=false;
		private void button90_Click_1(object sender, System.EventArgs e)
		{
			
		}

		private void button90_Click_2(object sender, System.EventArgs e)
		{
	
		}

		private void button91_Click(object sender, System.EventArgs e)
		{
		}

		private void button81_Click(object sender, System.EventArgs e)
		{
		
		}

		private void tabPage3_Validated(object sender, System.EventArgs e)
		{
		
		}

		private void Generale_Activated(object sender, System.EventArgs e)
		{
			try
			{
				oleDbDataAdapter1.Fill(dsClients1);
				dataGrid1.Refresh();

				oleDbDataAdapter2.Fill(dsPersonnel1);
				dataGrid2.Refresh();

				oleDbDataAdapter3.Fill(dsComptesJ1);
				
			}
			catch(Exception exc){MessageBox.Show(exc.ToString());}
			
		}

		
		private void button21_Click_1(object sender, System.EventArgs e)
		{
			textBox1.Text="";
		}

		private void button23_Click(object sender, System.EventArgs e)
		{
			textBox1.Text+=" ";
		}

		private void button55_Click(object sender, System.EventArgs e)
		{
			textBox3.Text="";
		}

		private void button57_Click(object sender, System.EventArgs e)
		{
			textBox3.Text+=" ";
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			
		}

		

		private void FilterClient(string FilterCol, string Value)
		{
			
			string STRSQL ="Select NumClient AS [Identifiant Client], NomClient AS [Nom Client], "+
				" PrenomClient AS [Pr�nom Client],"+
				" TelClient AS [T�l / Mobile],"+
				" AdresseClient AS  [Adresse],"+
				" MailClient AS [e-Mail]"+
				"from Client Where "+ FilterCol.ToString() +" Like '%"+Value+"%'";
			try
			{
				dsClients1.Clear();
				oleDbDataAdapter1.SelectCommand.CommandText= STRSQL;
				oleDbDataAdapter1.Fill(dsClients1);
				dataGrid1.Refresh();
				
			}
			catch(Exception ec){MessageBox.Show(STRSQL+"\n"+ec.ToString());}


		}
		private void FilterComptes(string NumClient)
		{
			
			string STRSQL ="SELECT CompteJournalier.DateCloture, "+
				"CompteJournalier.DateOuvertureCompte, CompteJournalier.NumCompteJournalier, "+
				"Client.NumClient FROM "+
				"(Client INNER JOIN CompteJournalier ON Client.NumClient = CompteJournalier.RefClient) where"+
				" Client.NumClient ="+ NumClient ;
				
			try
			{
				dsComptesJ1.Clear();
				oleDbDataAdapter3.SelectCommand.CommandText= STRSQL;
				oleDbDataAdapter3.Fill(dsComptesJ1);
				lblnumCompte.Text =dsComptesJ1.Tables[0].Rows[0].ItemArray[1].ToString();
				lblDateOuv  .Text =dsComptesJ1.Tables[0].Rows[0].ItemArray[2].ToString();
				lblDateFerm .Text =dsComptesJ1.Tables[0].Rows[0].ItemArray[0].ToString();
				
			}
			catch(Exception ec){;;}


		}
		private void FilterPersonnel(string FilterCol, string Value)
		{
			
			string STRSQL ="SELECT "+
				"NumEmploye AS [Identifiant Employ�], "+ 
				"NomEmploye AS [Nom Employ�], "+ 
				"PrenomEmploye AS [Pr�nom Employ�], "+
				"TelEmploye AS [Tel / Mobile], "+
				"poste AS [Poste Courant], "+
				"Salaire AS Salaire "+
				"from Employe Where "+ FilterCol.ToString() +" Like '%"+Value+"%'";
			try
			{
				dsPersonnel1.Clear();
				oleDbDataAdapter2.SelectCommand.CommandText= STRSQL;
				oleDbDataAdapter2.Fill(dsPersonnel1);
				dataGrid2.Refresh();
				
			}
			catch(Exception ec){MessageBox.Show(STRSQL+"\n"+ec.ToString());}


		}
		private void button83_Click(object sender, System.EventArgs e)
		{
			
		}

		private void dataGrid1_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
			
		}

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void button84_Click_1(object sender, System.EventArgs e)
		{
			TransatPrincipal Tr = new TransatPrincipal();
			this.Hide();
			Tr.Show();

		
		}

		private void textBox3_TextChanged_1(object sender, System.EventArgs e)
		{
			if(rdIdEmp.Checked)
			 FilterPersonnel("NumEmploye",textBox3.Text);
			if(rdNomEmp.Checked)
				FilterPersonnel("NomEmploye",textBox3.Text);
			if(rdPrenEmp.Checked)
				FilterPersonnel("PrenomEmploye",textBox3.Text);
		
		}

		private void button83_Click_1(object sender, System.EventArgs e)
		{
			AjoutEmploye AjEmp= new AjoutEmploye();
			AjEmp.ShowDialog(this);
			FilterPersonnel("NumEmploye","");
		}

		private void addClient_Click_1(object sender, System.EventArgs e)
		{
			AjoutClient AC=new AjoutClient();
			AC.ShowDialog(this);

			dsClients1.Clear();
			try
			{
				oleDbDataAdapter1.SelectCommand.Connection.Close();
				oleDbDataAdapter1.SelectCommand.Connection.Open();
			}
			finally{
			oleDbDataAdapter1.Fill(dsClients1);
				dataGrid1.Refresh();}
			

			
		}

		private void button81_Click_1(object sender, System.EventArgs e)
		{
			string NumClient;
			string[] clientAttr=new string[6];
			NumClient =  dsClients1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[0].ToString();
			AjoutCompte AjComp=new AjoutCompte(System.Convert.ToInt32(NumClient));
			AjComp.ShowDialog();
		}

		private void suppclient_Click_1(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Confirmer suppression Client "+dataGrid1[dataGrid1.CurrentRowIndex,0].ToString(),
				"OXENCO",MessageBoxButtons.YesNo)==DialogResult.Yes)
			{
				try
				{
					oleDbDataAdapter1.DeleteCommand.CommandText = "Delete from Client where NumClient = "+
						dataGrid1[dataGrid1.CurrentRowIndex,0].ToString();
					oleDbDataAdapter1.DeleteCommand.ExecuteNonQuery();		
					dsClients1.Clear();
					oleDbDataAdapter1.Fill(dsClients1);
					dataGrid1.Refresh();
				}
				catch(Exception ex){MessageBox.Show("Impossible de supprimer","OXENCO");}
			}
			
		}

		private void button36_Click_1(object sender, System.EventArgs e)
		{
			textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}

		private void button12_Click_1(object sender, System.EventArgs e)
		{
			if (Shift.Checked==true)
				textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
			else
				textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1).ToLower();
		}

		private void button23_Click_1(object sender, System.EventArgs e)
		{
			textBox1.Text+=" ";
		}

		private void button21_Click_2(object sender, System.EventArgs e)
		{
			textBox1.Text="";
		}

		private void button48_Click(object sender, System.EventArgs e)
		{
			textBox3.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}

		private void button73_Click(object sender, System.EventArgs e)
		{
			if (Shft.Checked==true)
				textBox3.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
			else
				textBox3.Text+=sender.ToString().Substring(sender.ToString().Length-1,1).ToLower();
		}

		private void button57_Click_1(object sender, System.EventArgs e)
		{
			textBox3.Text+=" ";
		}

		private void button55_Click_1(object sender, System.EventArgs e)
		{
			textBox3.Text="";
		}

		private void btnLock_Click(object sender, System.EventArgs e)
		{
			if(!locked)
			{
				Locker();
				btnLock.Text="Unlock";
				Accueil G =new Accueil();
				G.ShowDialog();
			}
			else 
			{
				Unlock();
				btnLock.Text="Lock";
			}
			locked=!locked;

		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			Application.ExitThread();
		}

		private void button86_Click(object sender, System.EventArgs e)
		{
			Boutique Bout =new Boutique();
			Bout.Text="Gestion du Bar";
			Bout.ShowDialog();
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			textBox1.Text="";
		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			textBox3.Text="";
		}

		private void button89_Click(object sender, System.EventArgs e)
		{
			Boutique Bout =new Boutique();
			Bout.ShowDialog();
		}

		private void button87_Click(object sender, System.EventArgs e)
		{
			Boutique Bout =new Boutique();
			Bout.Text="Gestion du Snack";
			Bout.ShowDialog();		
		}

		private void button88_Click(object sender, System.EventArgs e)
		{
			BaseNautique BN = new BaseNautique();
			BN.ShowDialog();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			fontDialog.ShowDialog();
			foreach(Control c in this.tabControl2.TabPages[0].Controls)
			if (c.GetType().FullName== "System.Windows.Forms.TextBox" ||
				c.GetType().FullName== "System.Windows.Forms.DataGrid")
			{
				c.Font=fontDialog.Font;
			}

		}

		private void timer1_Tick_1(object sender, System.EventArgs e)
		{
//			try
//			{dsClients1.Clear();
//				oleDbDataAdapter1.Fill(dsClients1);
//				dataGrid1.Refresh();
//
//				dsPersonnel1.Clear();
//				oleDbDataAdapter2.Fill(dsPersonnel1);
//				dataGrid2.Refresh();
//				dsComptesJ1.Clear();
//				oleDbDataAdapter3.Fill(dsComptesJ1);
//				FilterComptes(dsClients1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[0].ToString());
//			}
//			catch(Exception exc){;;}
//			timer1.Enabled=false;
		
		
		}

		private void dataGrid1_Navigate_1(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}

	}

}