using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Graphism;
using System.Data;
using System.Data.OleDb;
namespace Transacts
{
	/// <summary>
	/// Summary description for Tables.
	/// </summary>
	public class Restaurant : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel PanelTransat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private Resto[] T=new Resto[300];
		private System.Windows.Forms.PictureBox ZoneTables;
		private System.Windows.Forms.CheckBox checkLock;
		private System.Windows.Forms.ListBox ListSelection;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private Transacts.DSProds dsProds1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private Transacts.dsRes dsRes1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter6;
		private System.Data.OleDb.OleDbConnection oleDbConnection2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
		private Transacts.Dsmenus dsmenus1;
		private System.Data.OleDb.OleDbCommand oleDbCommand1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter5;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
		private Transacts.dscommtable dscommtable1;
		private System.Windows.Forms.Button button24;
		private System.Data.OleDb.OleDbCommand oleDbCommand2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.RadioButton rdNomClient;
		private System.Windows.Forms.RadioButton rdPrenomClient;
		private System.Windows.Forms.RadioButton rdIdClient;
		private System.Windows.Forms.RadioButton rdDateRes;
		private System.Windows.Forms.RadioButton rdCodeRes;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGrid dataGrid4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGrid dataGrid5;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.Button QteProdmoins;
		private System.Windows.Forms.Button QteProdplus;
		private System.Windows.Forms.NumericUpDown QteProd;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdNom;
		private System.Windows.Forms.TextBox textRechProd;
		private System.Windows.Forms.RadioButton rdRef;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TabControl tabRestau;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private Transacts.dsFamilles dsFamilles1;
		private System.Windows.Forms.Label label2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.ComponentModel.IContainer components;

		public Restaurant()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			for (int i=0;i<300;i++)
				T[i] = new Resto();

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
		int nbtables=0;
		double TotalCommande=0;
		int NumeroCommande;
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.PanelTransat = new System.Windows.Forms.Panel();
			this.ZoneTables = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dsRes1 = new Transacts.dsRes();
			this.dsmenus1 = new Transacts.Dsmenus();
			this.dsProds1 = new Transacts.DSProds();
			this.button3 = new System.Windows.Forms.Button();
			this.checkLock = new System.Windows.Forms.CheckBox();
			this.ListSelection = new System.Windows.Forms.ListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button24 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.label21 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button22 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
			this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter6 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter5 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
			this.dscommtable1 = new Transacts.dscommtable();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button16 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.rdNomClient = new System.Windows.Forms.RadioButton();
			this.rdPrenomClient = new System.Windows.Forms.RadioButton();
			this.rdIdClient = new System.Windows.Forms.RadioButton();
			this.rdDateRes = new System.Windows.Forms.RadioButton();
			this.rdCodeRes = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGrid4 = new System.Windows.Forms.DataGrid();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.dataGrid5 = new System.Windows.Forms.DataGrid();
			this.label15 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button18 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.QteProdmoins = new System.Windows.Forms.Button();
			this.QteProdplus = new System.Windows.Forms.Button();
			this.QteProd = new System.Windows.Forms.NumericUpDown();
			this.button29 = new System.Windows.Forms.Button();
			this.button27 = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dsFamilles1 = new Transacts.dsFamilles();
			this.rdNom = new System.Windows.Forms.RadioButton();
			this.textRechProd = new System.Windows.Forms.TextBox();
			this.rdRef = new System.Windows.Forms.RadioButton();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.tabRestau = new System.Windows.Forms.TabControl();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.PanelTransat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsRes1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsmenus1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsProds1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dscommtable1)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.QteProd)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsFamilles1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.tabRestau.SuspendLayout();
			this.SuspendLayout();
			// 
			// PanelTransat
			// 
			this.PanelTransat.AutoScroll = true;
			this.PanelTransat.BackColor = System.Drawing.Color.White;
			this.PanelTransat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelTransat.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.ZoneTables});
			this.PanelTransat.Location = new System.Drawing.Point(16, 56);
			this.PanelTransat.Name = "PanelTransat";
			this.PanelTransat.Size = new System.Drawing.Size(400, 184);
			this.PanelTransat.TabIndex = 4;
			// 
			// ZoneTables
			// 
			this.ZoneTables.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ZoneTables.Location = new System.Drawing.Point(8, 8);
			this.ZoneTables.Name = "ZoneTables";
			this.ZoneTables.Size = new System.Drawing.Size(384, 168);
			this.ZoneTables.TabIndex = 0;
			this.ZoneTables.TabStop = false;
			this.ZoneTables.Click += new System.EventHandler(this.ZoneTables_Click_1);
			this.ZoneTables.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZoneTables_MouseUp_1);
			this.ZoneTables.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ZoneTables_MouseMove);
			this.ZoneTables.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZoneTables_MouseDown_2);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Plan Tables";
			// 
			// dsRes1
			// 
			this.dsRes1.DataSetName = "dsRes";
			this.dsRes1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsRes1.Namespace = "http://www.tempuri.org/dsRes.xsd";
			// 
			// dsmenus1
			// 
			this.dsmenus1.DataSetName = "Dsmenus";
			this.dsmenus1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsmenus1.Namespace = "http://www.tempuri.org/Dsmenus.xsd";
			// 
			// dsProds1
			// 
			this.dsProds1.DataSetName = "DSProds";
			this.dsProds1.EnforceConstraints = false;
			this.dsProds1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsProds1.Namespace = "http://www.tempuri.org/DSProds.xsd";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cornsilk;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button3.Location = new System.Drawing.Point(632, 448);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 96);
			this.button3.TabIndex = 10;
			this.button3.Text = "Retour";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// checkLock
			// 
			this.checkLock.Location = new System.Drawing.Point(432, 480);
			this.checkLock.Name = "checkLock";
			this.checkLock.Size = new System.Drawing.Size(48, 16);
			this.checkLock.TabIndex = 11;
			this.checkLock.Text = "Lock";
			// 
			// ListSelection
			// 
			this.ListSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ListSelection.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.ListSelection.ItemHeight = 18;
			this.ListSelection.Location = new System.Drawing.Point(576, 448);
			this.ListSelection.Name = "ListSelection";
			this.ListSelection.Size = new System.Drawing.Size(48, 72);
			this.ListSelection.Sorted = true;
			this.ListSelection.TabIndex = 12;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label11.Location = new System.Drawing.Point(424, 448);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(152, 24);
			this.label11.TabIndex = 13;
			this.label11.Text = "Tables Sélectionnées";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button24,
																					this.button21,
																					this.button20,
																					this.label21,
																					this.label16,
																					this.label19,
																					this.label18,
																					this.listView1});
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F);
			this.groupBox2.Location = new System.Drawing.Point(16, 256);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(392, 296);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Commande En Cours";
			// 
			// button24
			// 
			this.button24.BackColor = System.Drawing.Color.Cornsilk;
			this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button24.Location = new System.Drawing.Point(144, 248);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(104, 40);
			this.button24.TabIndex = 24;
			this.button24.Text = "Solder";
			this.button24.Click += new System.EventHandler(this.button24_Click);
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.Cornsilk;
			this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button21.Location = new System.Drawing.Point(8, 248);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(96, 40);
			this.button21.TabIndex = 12;
			this.button21.Text = "Supprimer Ligne(s)";
			this.button21.Click += new System.EventHandler(this.button21_Click);
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.Cornsilk;
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button20.Location = new System.Drawing.Point(288, 248);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(96, 40);
			this.button20.TabIndex = 11;
			this.button20.Text = "Imprimer Ticket";
			this.button20.Click += new System.EventHandler(this.button20_Click);
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(200, 208);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(88, 32);
			this.label21.TabIndex = 10;
			this.label21.Text = "Total Commande";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(296, 208);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(88, 32);
			this.label16.TabIndex = 9;
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Tahoma", 9F);
			this.label19.Location = new System.Drawing.Point(8, 224);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(35, 15);
			this.label19.TabIndex = 7;
			this.label19.Text = "Client";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Tahoma", 9F);
			this.label18.Location = new System.Drawing.Point(8, 200);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(51, 15);
			this.label18.TabIndex = 6;
			this.label18.Text = "Employé";
			// 
			// listView1
			// 
			this.listView1.CheckBoxes = true;
			this.listView1.Location = new System.Drawing.Point(16, 24);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(360, 168);
			this.listView1.TabIndex = 8;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.Cornsilk;
			this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button22.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button22.Location = new System.Drawing.Point(312, 8);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(104, 40);
			this.button22.TabIndex = 15;
			this.button22.Text = "Rechercher";
			this.button22.Click += new System.EventHandler(this.button22_Click_1);
			// 
			// button23
			// 
			this.button23.BackColor = System.Drawing.Color.Cornsilk;
			this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button23.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button23.Location = new System.Drawing.Point(424, 504);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(144, 40);
			this.button23.TabIndex = 16;
			this.button23.Text = "Supprimer Table(s)";
			this.button23.Click += new System.EventHandler(this.button23_Click);
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Produit", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Référence", "Référence"),
																																																				   new System.Data.Common.DataColumnMapping("Nom Produit", "Nom Produit"),
																																																				   new System.Data.Common.DataColumnMapping("Type Produit", "Type Produit"),
																																																				   new System.Data.Common.DataColumnMapping("Prix Unitaire", "Prix Unitaire")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Produit WHERE (RefProduit = ?) AND (LibelleProduit = ? OR ? IS NULL A" +
				"ND LibelleProduit IS NULL) AND (PrixUnit = ? OR ? IS NULL AND PrixUnit IS NULL) " +
				"AND (TypeProduit = ? OR ? IS NULL AND TypeProduit IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type Produit", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Produit(RefProduit, LibelleProduit, TypeProduit, PrixUnit) VALUES (?," +
				" ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Produit"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Type Produit"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT RefProduit AS Référence, LibelleProduit AS [Nom Produit], TypeProduit AS [" +
				"Type Produit], PrixUnit AS [Prix Unitaire] FROM Produit";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Produit SET RefProduit = ?, LibelleProduit = ?, TypeProduit = ?, PrixUnit = ? WHERE (RefProduit = ?) AND (LibelleProduit = ? OR ? IS NULL AND LibelleProduit IS NULL) AND (PrixUnit = ? OR ? IS NULL AND PrixUnit IS NULL) AND (TypeProduit = ? OR ? IS NULL AND TypeProduit IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Produit"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Type Produit"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Type Produit", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.DeleteCommand = this.oleDbCommand1;
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "ReservTables", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("Numéro Table", "Numéro Table"),
																																																						new System.Data.Common.DataColumnMapping("Identifiant Client", "Identifiant Client"),
																																																						new System.Data.Common.DataColumnMapping("Nom Client", "Nom Client"),
																																																						new System.Data.Common.DataColumnMapping("Prénom Client", "Prénom Client"),
																																																						new System.Data.Common.DataColumnMapping("Tél / Mobile", "Tél / Mobile"),
																																																						new System.Data.Common.DataColumnMapping("Adresse", "Adresse"),
																																																						new System.Data.Common.DataColumnMapping("e-Mail", "e-Mail"),
																																																						new System.Data.Common.DataColumnMapping("Date Réservation", "Date Réservation"),
																																																						new System.Data.Common.DataColumnMapping("NumReservation", "NumReservation")})});
			// 
			// oleDbCommand1
			// 
			this.oleDbCommand1.Connection = this.oleDbConnection2;
			// 
			// oleDbConnection2
			// 
			this.oleDbConnection2.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = @"SELECT ReservTables.NumTable AS [Numéro Table], Client.NumClient AS [Identifiant Client], Client.NomClient AS [Nom Client], Client.PrenomClient AS [Prénom Client], Client.TelClient AS [Tél / Mobile], Client.AdresseClient AS Adresse, Client.MailClient AS [e-Mail], ReservTables.DateReservation AS [Date Réservation], ReservTables.NumReservation FROM (ReservTables INNER JOIN Client ON ReservTables.NumClient = Client.NumClient)";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter6
			// 
			this.oleDbDataAdapter6.DeleteCommand = this.oleDbDeleteCommand5;
			this.oleDbDataAdapter6.InsertCommand = this.oleDbInsertCommand5;
			this.oleDbDataAdapter6.SelectCommand = this.oleDbSelectCommand6;
			this.oleDbDataAdapter6.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Menu", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("Référence", "Référence"),
																																																				new System.Data.Common.DataColumnMapping("Nom Menu", "Nom Menu"),
																																																				new System.Data.Common.DataColumnMapping("Prix unitaire", "Prix unitaire")})});
			this.oleDbDataAdapter6.UpdateCommand = this.oleDbUpdateCommand5;
			// 
			// oleDbDeleteCommand5
			// 
			this.oleDbDeleteCommand5.CommandText = "DELETE FROM Menu WHERE (RefMenu = ?) AND (NomMenu = ? OR ? IS NULL AND NomMenu IS" +
				" NULL) AND (PrixUnit = ? OR ? IS NULL AND PrixUnit IS NULL)";
			this.oleDbDeleteCommand5.Connection = this.oleDbConnection2;
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefMenu", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomMenu", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Menu", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomMenu1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Menu", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix unitaire", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix unitaire", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand5
			// 
			this.oleDbInsertCommand5.CommandText = "INSERT INTO Menu(RefMenu, NomMenu, PrixUnit) VALUES (?, ?, ?)";
			this.oleDbInsertCommand5.Connection = this.oleDbConnection2;
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefMenu", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomMenu", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Menu"));
			this.oleDbInsertCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.VarWChar, 50, "Prix unitaire"));
			// 
			// oleDbSelectCommand6
			// 
			this.oleDbSelectCommand6.CommandText = "SELECT RefMenu AS Référence, NomMenu AS [Nom Menu], PrixUnit AS [Prix unitaire] F" +
				"ROM Menu";
			this.oleDbSelectCommand6.Connection = this.oleDbConnection2;
			// 
			// oleDbUpdateCommand5
			// 
			this.oleDbUpdateCommand5.CommandText = "UPDATE Menu SET RefMenu = ?, NomMenu = ?, PrixUnit = ? WHERE (RefMenu = ?) AND (N" +
				"omMenu = ? OR ? IS NULL AND NomMenu IS NULL) AND (PrixUnit = ? OR ? IS NULL AND " +
				"PrixUnit IS NULL)";
			this.oleDbUpdateCommand5.Connection = this.oleDbConnection2;
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefMenu", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomMenu", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Menu"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.VarWChar, 50, "Prix unitaire"));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefMenu", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomMenu", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Menu", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomMenu1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Menu", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix unitaire", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand5.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prix unitaire", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDataAdapter5
			// 
			this.oleDbDataAdapter5.DeleteCommand = this.oleDbCommand2;
			this.oleDbDataAdapter5.SelectCommand = this.oleDbSelectCommand5;
			this.oleDbDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Commande", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("Numero Table", "Numero Table"),
																																																					new System.Data.Common.DataColumnMapping("Num Client", "Num Client")})});
			// 
			// oleDbCommand2
			// 
			this.oleDbCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbSelectCommand5
			// 
			this.oleDbSelectCommand5.CommandText = "SELECT Tables.NumTable AS [Numero Table], Commande.NumClient AS [Num Client], Com" +
				"mande.NumCommande, Commande.NumTable FROM (Commande INNER JOIN Tables ON Command" +
				"e.NumTable = Tables.NumTable)";
			this.oleDbSelectCommand5.Connection = this.oleDbConnection1;
			// 
			// dscommtable1
			// 
			this.dscommtable1.DataSetName = "dscommtable";
			this.dscommtable1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dscommtable1.Namespace = "http://www.tempuri.org/dscommtable.xsd";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.button16,
																				   this.button6,
																				   this.rdNomClient,
																				   this.rdPrenomClient,
																				   this.rdIdClient,
																				   this.rdDateRes,
																				   this.rdCodeRes,
																				   this.textBox2,
																				   this.dateTimePicker1,
																				   this.dataGrid4});
			this.tabPage1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabPage1.Location = new System.Drawing.Point(4, 27);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(320, 401);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Réservations";
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.Cornsilk;
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button16.Location = new System.Drawing.Point(176, 304);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(136, 48);
			this.button16.TabIndex = 26;
			this.button16.Text = "Réserver Table";
			this.button16.Click += new System.EventHandler(this.button16_Click_1);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Cornsilk;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Location = new System.Drawing.Point(16, 304);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(136, 48);
			this.button6.TabIndex = 25;
			this.button6.Text = "Annuler Réservation";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// rdNomClient
			// 
			this.rdNomClient.Location = new System.Drawing.Point(8, 256);
			this.rdNomClient.Name = "rdNomClient";
			this.rdNomClient.TabIndex = 24;
			this.rdNomClient.Text = "Nom Client";
			// 
			// rdPrenomClient
			// 
			this.rdPrenomClient.Location = new System.Drawing.Point(168, 224);
			this.rdPrenomClient.Name = "rdPrenomClient";
			this.rdPrenomClient.Size = new System.Drawing.Size(120, 24);
			this.rdPrenomClient.TabIndex = 23;
			this.rdPrenomClient.Text = "Prénom Client";
			// 
			// rdIdClient
			// 
			this.rdIdClient.Checked = true;
			this.rdIdClient.Location = new System.Drawing.Point(8, 192);
			this.rdIdClient.Name = "rdIdClient";
			this.rdIdClient.Size = new System.Drawing.Size(152, 24);
			this.rdIdClient.TabIndex = 22;
			this.rdIdClient.TabStop = true;
			this.rdIdClient.Text = "Identifiant CLient";
			// 
			// rdDateRes
			// 
			this.rdDateRes.Location = new System.Drawing.Point(8, 224);
			this.rdDateRes.Name = "rdDateRes";
			this.rdDateRes.Size = new System.Drawing.Size(144, 24);
			this.rdDateRes.TabIndex = 21;
			this.rdDateRes.Text = "Date Réservation";
			// 
			// rdCodeRes
			// 
			this.rdCodeRes.Location = new System.Drawing.Point(168, 192);
			this.rdCodeRes.Name = "rdCodeRes";
			this.rdCodeRes.Size = new System.Drawing.Size(144, 24);
			this.rdCodeRes.TabIndex = 20;
			this.rdCodeRes.Text = "Code Réservation";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(168, 256);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 32);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 360);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.Value = new System.DateTime(2006, 6, 8, 21, 29, 5, 101);
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dataGrid4
			// 
			this.dataGrid4.BackColor = System.Drawing.SystemColors.Info;
			this.dataGrid4.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGrid4.CaptionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid4.CaptionForeColor = System.Drawing.Color.Black;
			this.dataGrid4.CaptionText = "Liste des Réservations";
			this.dataGrid4.DataMember = "ReservTables";
			this.dataGrid4.DataSource = this.dsRes1;
			this.dataGrid4.Font = new System.Drawing.Font("Tahoma", 9F);
			this.dataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid4.Location = new System.Drawing.Point(8, 16);
			this.dataGrid4.Name = "dataGrid4";
			this.dataGrid4.ReadOnly = true;
			this.dataGrid4.Size = new System.Drawing.Size(304, 168);
			this.dataGrid4.TabIndex = 123;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.groupBox3,
																				   this.dataGrid5,
																				   this.label15,
																				   this.numericUpDown1,
																				   this.button18,
																				   this.button11,
																				   this.button12,
																				   this.label13});
			this.tabPage3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabPage3.Location = new System.Drawing.Point(4, 27);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(320, 401);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Menus";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radioButton1,
																					this.textBox1,
																					this.radioButton2});
			this.groupBox3.Location = new System.Drawing.Point(152, 264);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(160, 128);
			this.groupBox3.TabIndex = 1213;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Rechercher Par :";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(8, 56);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(128, 24);
			this.radioButton1.TabIndex = 20;
			this.radioButton1.Text = "Nom Menu";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 88);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 26);
			this.textBox1.TabIndex = 18;
			this.textBox1.Text = "";
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(8, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(96, 24);
			this.radioButton2.TabIndex = 19;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Référence";
			// 
			// dataGrid5
			// 
			this.dataGrid5.DataMember = "Menu";
			this.dataGrid5.DataSource = this.dsmenus1;
			this.dataGrid5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid5.Location = new System.Drawing.Point(16, 48);
			this.dataGrid5.Name = "dataGrid5";
			this.dataGrid5.ReadOnly = true;
			this.dataGrid5.Size = new System.Drawing.Size(296, 168);
			this.dataGrid5.TabIndex = 1212;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(208, 224);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 24);
			this.label15.TabIndex = 11;
			this.label15.Text = "Quantité";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(272, 224);
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(40, 26);
			this.numericUpDown1.TabIndex = 10;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 1,
																		 0,
																		 0,
																		 0});
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(112, 8);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(184, 32);
			this.button18.TabIndex = 9;
			this.button18.Text = "Ajouter Commande";
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(16, 344);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(88, 48);
			this.button11.TabIndex = 7;
			this.button11.Text = "Supprimer Menu";
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(16, 272);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(88, 48);
			this.button12.TabIndex = 6;
			this.button12.Text = "Ajouter Menu";
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(12, 13);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(92, 24);
			this.label13.TabIndex = 5;
			this.label13.Text = "Liste Menus";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.QteProdmoins,
																				   this.QteProdplus,
																				   this.QteProd,
																				   this.button29,
																				   this.button27,
																				   this.button28,
																				   this.groupBox1,
																				   this.dataGrid1});
			this.tabPage6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabPage6.Location = new System.Drawing.Point(4, 27);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(320, 401);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Produits";
			// 
			// QteProdmoins
			// 
			this.QteProdmoins.BackColor = System.Drawing.Color.Cornsilk;
			this.QteProdmoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.QteProdmoins.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.QteProdmoins.Location = new System.Drawing.Point(280, 232);
			this.QteProdmoins.Name = "QteProdmoins";
			this.QteProdmoins.Size = new System.Drawing.Size(40, 40);
			this.QteProdmoins.TabIndex = 30;
			this.QteProdmoins.Text = "Qte-";
			this.QteProdmoins.Click += new System.EventHandler(this.QteProdmoins_Click);
			// 
			// QteProdplus
			// 
			this.QteProdplus.BackColor = System.Drawing.Color.Cornsilk;
			this.QteProdplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.QteProdplus.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.QteProdplus.Location = new System.Drawing.Point(184, 232);
			this.QteProdplus.Name = "QteProdplus";
			this.QteProdplus.Size = new System.Drawing.Size(48, 40);
			this.QteProdplus.TabIndex = 29;
			this.QteProdplus.Text = "Qte+";
			this.QteProdplus.Click += new System.EventHandler(this.QteProdplus_Click);
			// 
			// QteProd
			// 
			this.QteProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.QteProd.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.QteProd.Location = new System.Drawing.Point(216, 232);
			this.QteProd.Minimum = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			this.QteProd.Name = "QteProd";
			this.QteProd.ReadOnly = true;
			this.QteProd.Size = new System.Drawing.Size(64, 40);
			this.QteProd.TabIndex = 28;
			this.QteProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.QteProd.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
			this.QteProd.Value = new System.Decimal(new int[] {
																  1,
																  0,
																  0,
																  0});
			// 
			// button29
			// 
			this.button29.BackColor = System.Drawing.Color.Cornsilk;
			this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button29.Location = new System.Drawing.Point(184, 184);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(128, 40);
			this.button29.TabIndex = 27;
			this.button29.Text = "Ajouter Commande";
			this.button29.Click += new System.EventHandler(this.button29_Click);
			// 
			// button27
			// 
			this.button27.BackColor = System.Drawing.Color.Cornsilk;
			this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button27.Location = new System.Drawing.Point(208, 352);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(104, 40);
			this.button27.TabIndex = 24;
			this.button27.Text = "Supprimer";
			this.button27.Click += new System.EventHandler(this.button27_Click);
			// 
			// button28
			// 
			this.button28.BackColor = System.Drawing.Color.Cornsilk;
			this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button28.Location = new System.Drawing.Point(208, 304);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(104, 40);
			this.button28.TabIndex = 23;
			this.button28.Text = "Ajouter";
			this.button28.Click += new System.EventHandler(this.button28_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label2,
																					this.comboBox1,
																					this.rdNom,
																					this.textRechProd,
																					this.rdRef});
			this.groupBox1.Location = new System.Drawing.Point(16, 192);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(160, 200);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rechercher Par :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 24);
			this.label2.TabIndex = 22;
			this.label2.Text = "Famille";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.dsFamilles1;
			this.comboBox1.DisplayMember = "Produit.TypeProduit";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Location = new System.Drawing.Point(8, 168);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(144, 26);
			this.comboBox1.TabIndex = 21;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dsFamilles1
			// 
			this.dsFamilles1.DataSetName = "dsFamilles";
			this.dsFamilles1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsFamilles1.Namespace = "http://www.tempuri.org/dsFamilles.xsd";
			// 
			// rdNom
			// 
			this.rdNom.Location = new System.Drawing.Point(8, 56);
			this.rdNom.Name = "rdNom";
			this.rdNom.Size = new System.Drawing.Size(128, 24);
			this.rdNom.TabIndex = 20;
			this.rdNom.Text = "Nom Produit";
			// 
			// textRechProd
			// 
			this.textRechProd.Location = new System.Drawing.Point(8, 88);
			this.textRechProd.Name = "textRechProd";
			this.textRechProd.Size = new System.Drawing.Size(144, 26);
			this.textRechProd.TabIndex = 18;
			this.textRechProd.Text = "";
			this.textRechProd.TextChanged += new System.EventHandler(this.textRechProd_TextChanged_1);
			this.textRechProd.Enter += new System.EventHandler(this.textRechProd_Enter);
			// 
			// rdRef
			// 
			this.rdRef.Checked = true;
			this.rdRef.Location = new System.Drawing.Point(8, 24);
			this.rdRef.Name = "rdRef";
			this.rdRef.Size = new System.Drawing.Size(96, 24);
			this.rdRef.TabIndex = 19;
			this.rdRef.TabStop = true;
			this.rdRef.Text = "Référence";
			// 
			// dataGrid1
			// 
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dataGrid1.CaptionText = "Liste Produits";
			this.dataGrid1.DataMember = "Produit";
			this.dataGrid1.DataSource = this.dsProds1;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(312, 168);
			this.dataGrid1.TabIndex = 1502;
			this.dataGrid1.TabStop = false;
			// 
			// tabRestau
			// 
			this.tabRestau.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.tabPage1,
																					this.tabPage3,
																					this.tabPage6});
			this.tabRestau.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabRestau.ItemSize = new System.Drawing.Size(95, 23);
			this.tabRestau.Location = new System.Drawing.Point(432, 8);
			this.tabRestau.Multiline = true;
			this.tabRestau.Name = "tabRestau";
			this.tabRestau.SelectedIndex = 0;
			this.tabRestau.Size = new System.Drawing.Size(328, 432);
			this.tabRestau.TabIndex = 6;
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
			this.oleDbSelectCommand2.CommandText = "SELECT DISTINCT TypeProduit  FROM Produit";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// Restaurant
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(768, 558);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button23,
																		  this.button22,
																		  this.groupBox2,
																		  this.label11,
																		  this.ListSelection,
																		  this.checkLock,
																		  this.button3,
																		  this.tabRestau,
																		  this.label1,
																		  this.PanelTransat});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Restaurant";
			this.Text = "Gestion du Restaurant";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Restaurant_Load);
			this.PanelTransat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsRes1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsmenus1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsProds1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dscommtable1)).EndInit();
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.QteProd)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsFamilles1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.tabRestau.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		private void AfficherTables()
		{
			int maxx=1,maxy=1,i;
			for(i=0; i < nbtables; i++)
			{
				if(T[i].GetPosX() > maxx) maxx=T[i].GetPosX();
				if(T[i].GetPosY() > maxy) maxy=T[i].GetPosY();
			}
			Bitmap Bmp =new  Bitmap(42*(maxx)+50, 42*(maxy)+50);
			Graphics g=Graphics.FromImage(Bmp);
			g.Clear(Color.White);
			Class1 G =new Graphism.Class1();
			
			G.BackGround(g,Color.Gray,0,0,42*(maxx)+50, 42*(maxy)+50);
			for(i=0; i < nbtables; i++)
			{
				ZoneTables.Size=new Size(42*(maxx), 42*(maxy)+52);
				Color C= Color.Green;
				if(this.T[i].GetEtatCourant() ==0) C=Color.Green;
				if(T[i].GetEtatCourant() ==1) C=Color.GreenYellow;
				if(T[i].GetEtatCourant() ==2) C=Color.Red;
				if (selItems[i]==1)
					G.SkyScraper(g,42*(T[i].GetPosX()-1),42*(T[i].GetPosY()-1),30,30,3,3,
						Color.FromArgb(255-C.R,255-C.G,255-C.B),T[i].GetNumTable(),17);
				else
					G.SkyScraper(g,42*(T[i].GetPosX()-1),42*(T[i].GetPosY()-1),30,30,3,3,
						C,T[i].GetNumTable(),17);
			}
			ZoneTables.Image=Bmp;
		}
		private void button3_Click(object sender, System.EventArgs e)
		{
			Generale Gen =new Generale("");
			this.Hide();
			Gen.Show();
		}
		string strconn="Provider=Microsoft.Jet.OLEDB.4.0;Data source=ZenithPlage.mdb";
		OleDbConnection conn;
		string STRSQL;
		OleDbCommand CommandSql ;
		private void Restaurant_Load(object sender, System.EventArgs e)
		{
			oleDbDataAdapter1.Fill(dsProds1);
			oleDbDataAdapter4.Fill(dsRes1);
			oleDbDataAdapter5.Fill(dscommtable1);
			oleDbDataAdapter6.Fill(dsmenus1);
			oleDbDataAdapter2.Fill(dsFamilles1);
			conn =new OleDbConnection(strconn);
			conn.Open();
			listView1.Activation=ItemActivation.OneClick;
			listView1.View = View.Details;
			listView1.GridLines = true;
			listView1.Sorting = SortOrder.Ascending;
			listView1.Columns.Add("",20,HorizontalAlignment.Left );
			listView1.Columns.Add("Qté",60, HorizontalAlignment.Center);
			listView1.Columns.Add("Code",100, HorizontalAlignment.Center);
			listView1.Columns.Add("Désignation",120, HorizontalAlignment.Center);
			listView1.Columns.Add("Prix Unitaire TTC",80, HorizontalAlignment.Center);
			ChargerDonneeTable();
		
		}
		/// <summary>
		/// Charger la commande d'une table
		/// </summary>
		/// <param name="NumTable"></param>
		private void ChargerComandeTable(int NumTable)
		{listView1.Items.Clear();

			try
			{	
				LoadComProd(NumTable);
			}			
			catch(Exception ex )
			{
				NumeroCommande=-1;
			}
	

		}
		
		private void LoadComProd(int NumTable)
		{
			STRSQL=
				"SELECT     Produit.RefProduit,Produit.TypeProduit,Produit.LibelleProduit, Produit.PrixUnit, ComProduit.Qte, ComProduit.NumCommande "+
				"FROM         (((ComProduit INNER JOIN "+
				"Produit ON ComProduit.RefProduit = Produit.RefProduit) INNER JOIN "+
				"Commande ON ComProduit.NumCommande = Commande.NumCommande) INNER JOIN "+
				"Tables ON Commande.NumTable = Tables.NumTable) "+ "Where Tables.NumTable ="+NumTable.ToString();
	
				CommandSql = new OleDbCommand(STRSQL,conn);
				DataView DV;
				DataSet DS=new DataSet();
				OleDbDataAdapter DA= new OleDbDataAdapter();
				DA.SelectCommand= CommandSql;
				DA.Fill(DS);
				DV=new DataView(DS.Tables[0]);
				int nbcoms = DV.Table.Rows.Count;
				NumeroCommande=System.Convert.ToInt32(DV.Table.Rows[0].ItemArray[5]);
				for(int j=0;j<nbcoms;j++)
				{
					ListViewItem item1 = new ListViewItem("");
					item1.SubItems.Add(DV.Table.Rows[j].ItemArray[4].ToString());
					item1.SubItems.Add(DV.Table.Rows[j].ItemArray[0].ToString());
					item1.SubItems.Add(DV.Table.Rows[j].ItemArray[2].ToString());
					item1.SubItems.Add(DV.Table.Rows[j].ItemArray[3].ToString());
					listView1.Items.AddRange(new ListViewItem[]{item1});
				}
				
		}
		private void SaveCommandeTable(int NumTable)
		{

		}
		private void ChargerDonneeTable()
		{
			try
			{
				STRSQL= "Select * from Tables" ;
				CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteScalar();
				DataView DV;
				DataSet DS=new DataSet();
				OleDbDataAdapter DA= new OleDbDataAdapter();
				DA.SelectCommand= CommandSql;
				DA.Fill(DS,"Tables");
				DV=new DataView(DS.Tables[0]);
				nbtables=DV.Table.Rows.Count;
				for(int i=0;i<nbtables;i++)
				{
					T[i].SetNumTable(System.Convert.ToInt32(DV.Table.Rows[i].ItemArray[0]));
					ChargerEtatTable(T[i].GetNumTable());
					T[i].SetPosX(System.Convert.ToInt32(DV.Table.Rows[i].ItemArray[1]));
					T[i].SetPosY(System.Convert.ToInt32(DV.Table.Rows[i].ItemArray[2]));
				}
			}
			catch(Exception Ex){MessageBox.Show("");}
			AfficherTables();
		}
		int[] selItems= new int[300];
		private void ChargerEtatTable(int NumTable)
		{/*Tables Occuppées*/
			for (int j=0;j<dscommtable1.Tables[0].Rows.Count;j++)
			{		if (dscommtable1.Tables[0].Rows[j].ItemArray[0].ToString()==NumTable.ToString())
			for(int i=0;i<nbtables;i++)
				if (T[i].GetNumTable()==NumTable)
				{
					T[i].SetEtatCourant(2);
					label19.Text="Client N° "+dscommtable1.Tables[0].Rows[j].ItemArray[1].ToString();
				}
			}
		}
		private void ZoneTables_MouseUp_1(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int table=0;
			int Nouv_Table=0;
			Boolean Existe=false;
			int position_x=(e.X/42);
			int position_y=(e.Y/42);
			for (int t=0; t<nbtables; t++)
				if (T[t].GetPosX()==position_x+1 && T[t].GetPosY()==position_y+1)
				{
					table=t;
					Existe = true;
				}
			/*Selection du transat*/
			if (Existe==true) 
				try
				{
					for(int i=0;i<nbtables;i++)
						selItems[i]=0;
					selItems[table]=1;
				}
			
				catch (Exception ex)
				{MessageBox.Show("Aucune Table Selectionnée","Gestion de Restaurant");}
			
					 
			if (table >=0)
			{
				
				if(checkLock.Checked==false)
					ListSelection.Items.Clear();
				if (ListSelection.Items.IndexOf(T[table].GetNumTable().ToString())<0)
					ListSelection.Items.Add(T[table].GetNumTable().ToString());
				
			}

			if (posXT1!= position_x || posYT1!= position_y )
			{
				for(int t=0; t<nbtables; t++)
				{
					if(T[t].GetPosX()==posXT1+1 && T[t].GetPosY()==posYT1+1 )
					{
						Nouv_Table=t;
					}
				}
				if(Existe)
				{
					PermuterPosTables(ref T[table], ref T[Nouv_Table]);
				}
				else
				{
					T[Nouv_Table].SetPosX(position_x+1);
					T[Nouv_Table].SetPosY(position_y+1);
					STRSQL="Update tables set PosX = "+
						(position_x+1).ToString()+", PosY = "+
						(position_y+1).ToString()+
						" Where NumTable = "+T[Nouv_Table].GetNumTable().ToString();

					try
					{
						OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
						CommandSql.ExecuteNonQuery();
					}
					catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
				}
			}
			if (Existe==true)
			{
				ChargerComandeTable(T[table].GetNumTable());
				ChargerEtatTable(T[table].GetNumTable());
			}
			else listView1.Items.Clear();
			AfficherTables();
			ZoneTables.Cursor=Cursors.Default;
		}
		
		private void button16_Click(object sender, System.EventArgs e)
		{
		 
		}


		private void PermuterPosTables(ref Resto T1, ref Resto T2)
		{
			Resto Temp=new Resto();

			Temp.SetPosX(T1.GetPosX());
			Temp.SetPosY(T1.GetPosY());

			T1.SetPosX(T2.GetPosX());
			T1.SetPosY(T2.GetPosY());

			T2.SetPosX(Temp.GetPosX());
			T2.SetPosY(Temp.GetPosY());

			STRSQL="Update tables set PosX = "+
				(T1.GetPosX()).ToString()+", PosY = "+
			(T1.GetPosY()).ToString()+
				" Where NumTable = "+T1.GetNumTable().ToString();
				
				
				
			try
			{
				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteNonQuery();
			}
			catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
			STRSQL="Update tables set PosX = "+
				(T2.GetPosX()).ToString()+", PosY = "+
				(T2.GetPosY()).ToString()+
				" Where NumTable = "+T2.GetNumTable().ToString();
				
				
				
				
			try
			{
				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteNonQuery();
			}
			catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
			ChargerDonneeTable();
		}
		int posXT1,posYT1;
		private void ZoneTables_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			NouvelleReservation Res = new NouvelleReservation();
			for (int i=0;i<ListSelection.Items.Count;i++)
				if (T[i].GetNumTable().ToString() == ListSelection.Items[0].ToString())
					Res.Tab =T[i];
			Res.ShowDialog();
			AfficherTables();
		}


		private void ZoneTables_Click(object sender, System.EventArgs e)
		{
		
		}
		private void creerTable(int PX, int PY, int NumTable)
		{
			STRSQL="Insert into tables (NumTable,PosX,PosY,EtatCourant,Deplacable) values ("+
				NumTable.ToString()+","+
				PX.ToString()+","+
				PY.ToString()+","+ 
				"0,0)";
			try
			{
				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);

				CommandSql.ExecuteNonQuery();
				conn.Close();
			}
			catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
			ChargerDonneeTable();
		}
		private void ZoneTables_DoubleClick(object sender, System.EventArgs e)
		{


		}


		private void button21_Click(object sender, System.EventArgs e)
		{MessageBox.Show(listView1.CheckedItems.Count.ToString());
			for(int l=0;l<listView1.Items.Count;l++)
			{if(listView1.Items[l].Checked==true)
				listView1.Items[l].Remove();
			}
		}



		private void button23_Click(object sender, System.EventArgs e)
		{
			for(int i=0;i<nbtables;i++)
			{
				if (T[i].GetNumTable().ToString()==ListSelection.Items[0].ToString() && T[i].GetEtatCourant()==2)
				{
					MessageBox.Show("Impossible de supprimer la table. \n Elle est encore occupée",this.Text);
					return;
				}
			}
			for(int i=0;i<ListSelection.Items.Count;i++)
			{
				STRSQL="delete from tables Where NumTable = "+
					ListSelection.Items[i].ToString();
				try
				{
					OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
					CommandSql.ExecuteNonQuery();
				}
				catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
				
			}
			ListSelection.Items.Clear();
			ChargerDonneeTable();
		}


		private void numericUpDown3_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void Restaurant_Activated(object sender, System.EventArgs e)
		{
			
		
		}
		private void FilterProduit(string FilterCol, string Value)
		{
			
			string STRSQL ="Select RefProduit AS [Référence], LibelleProduit AS [Nom Produit], "+
				" TypeProduit AS [Type Produit],"+
				" PrixUnit AS  [Prix Unitaire] from Produit Where "+ FilterCol.ToString() +" Like '"+Value+"%'";
			try{
			if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)
				oleDbDataAdapter1.SelectCommand.Connection.Open();
			dsProds1.Clear();
			oleDbDataAdapter1.SelectCommand.CommandText= STRSQL;
			oleDbDataAdapter1.Fill(dsProds1);
			dataGrid1.Refresh();
				
			}
			catch(Exception ec){;;}


		}

			private void FilterRes(string FilterCol, string Value)
			{
			
				string STRSQL ="SELECT "+
					 "ReservTables.NumTable AS [Numéro Table], "+ 
					 "Client.NumClient AS [Identifiant Client], "+ 
					 "Client.NomClient AS [Nom Client], "+
					"Client.PrenomClient AS [Prénom Client], "+
					 "Client.TelClient AS [Tél / Mobile], "+
					 " Client.AdresseClient AS Adresse, "+
					"Client.MailClient AS [e-Mail], "+
					"ReservTables.DateReservation AS [Date Réservation], "+
					" ReservTables.NumReservation "+
					"FROM "+
					"(ReservTables INNER "+
					"JOIN "+
					"Client ON "+
					"ReservTables.NumClient = Client.NumClient) "+

					"Where "+ FilterCol.ToString() +" Like '"+Value+"%'";
				try
				{
					dsRes1.Clear();
					oleDbDataAdapter4.SelectCommand.CommandText= STRSQL;
					oleDbDataAdapter4.Fill(dsRes1);
					dataGrid4.Refresh();
				
				}
				catch(Exception ec){MessageBox.Show(ec.ToString());}

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			NouvelleLocation Loc = new NouvelleLocation();
			Loc.ShowDialog();
		}

		private void button26_Click(object sender, System.EventArgs e)
		{
			
		}

		private void textRechProd_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void QteProdplus_Click(object sender, System.EventArgs e)
		{
		QteProd.Value=(QteProd.Value+1)%100;
		}

		private void QteProdmoins_Click(object sender, System.EventArgs e)
		{
			if (QteProd.Value>1)
				QteProd.Value=(QteProd.Value-1);
		}

		private void button29_Click(object sender, System.EventArgs e)
		{
			string[] ItCh = new string[300];
			for(int i=0;i<listView1.Items.Count;i++)
			{
				if(listView1.Items[i].SubItems[2].Text==dsProds1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[0].ToString())
				{
					listView1.Items[i].SubItems[1].Text=(System.Convert.ToInt32(listView1.Items[i].SubItems[1].Text)+QteProd.Value).ToString();
					STRSQL= "Update ComProduit set Qte ="+
						listView1.Items[i].SubItems[1].Text+" where NumCommande = "+ NumeroCommande + "And RefProduit = " +
						listView1.Items[i].SubItems[2].Text;
					try
					{
						OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
						CommandSql.ExecuteNonQuery();
					}
					catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}	
					return;
				}
			}

			ListViewItem item1 = new ListViewItem("");
			/*1*/item1.SubItems.Add(QteProd.Value.ToString());
			/*2*/item1.SubItems.Add(dsProds1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[0].ToString());
			/*3*/item1.SubItems.Add(dsProds1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[2].ToString());
			/*4*/item1.SubItems.Add(dsProds1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[3].ToString());
			TotalCommande+=System.Convert.ToDouble(ItCh[3])*System.Convert.ToDouble(QteProd.Value);


			label16.Text=TotalCommande.ToString();
			listView1.Items.AddRange(new ListViewItem[]{item1});
			
			/*Mise A jour de la table CommandeProduit*/
			if(NumeroCommande>0)
			{
				STRSQL= "Insert Into ComProduit(NumCommande, RefProduit, Qte) values("+
					NumeroCommande.ToString()+","+
					dsProds1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[0].ToString()+","+
					QteProd.Value.ToString()+")";
				try
				{
					OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
					CommandSql.ExecuteNonQuery();
				}
				catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}	
			}
			else /*Création d'une Nlle commande*/
			{
					if (ListSelection.Items.Count==0)
			 {
						MessageBox.Show("Choisir d'abord une table","OXENCO");
						return;
			 }
				if (MessageBox.Show("Voulez Vous Créer une Nouvelle Commande?","Restaurant",
					MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					ChoisirClient ChoCli= new ChoisirClient();
					ChoCli.ShowDialog();
					STRSQL= "Insert Into Commande (NumTable,NumClient) values ("+
						ListSelection.Items[0].ToString()+", "+ChoCli.Client + ")";

					label19.Text="Client N° "+ChoCli.Client;
					for(int i=0;i<nbtables;i++)
						if(T[i].GetNumTable().ToString()==ListSelection.Items[0].ToString())
							T[i].SetEtatCourant(2);
					try
					{
						OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
						CommandSql.ExecuteNonQuery();
						STRSQL = "select NumCommande from Commande where NumTable = "+ListSelection.Items[0].ToString(); 
						CommandSql = new OleDbCommand(STRSQL,conn);
						NumeroCommande=(int)CommandSql.ExecuteScalar();
						STRSQL= "Insert Into ComProduit(NumCommande, RefProduit, Qte) values("+
							NumeroCommande.ToString()+","+
							dsProds1.Tables[0].Rows[dataGrid1.CurrentRowIndex].ItemArray[0].ToString()+","+
							QteProd.Value.ToString()+")";
					}
					catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}	
					try
					{
						CommandSql = new OleDbCommand(STRSQL,conn);
						CommandSql.ExecuteNonQuery();
					}
					catch(Exception Ex){MessageBox.Show("ee"+STRSQL+Ex.ToString());}	
				}


			}
		AfficherTables();
		}

		private void button22_Click_1(object sender, System.EventArgs e)
		{
			ChercherTable ChT= new ChercherTable();
			ChT.ShowDialog();
			int table = ChT.GetNum();
			if (table>0)
			{
				try
				{
					for (int i=0;i<nbtables;i++)
					{
						if(T[i].GetNumTable()!=table)
							selItems[i]=0;

						else 
						{
							selItems[i]=1;
							
							ChargerComandeTable(T[i].GetNumTable());
						}
					}

					ChargerDonneeTable();
					AfficherTables();
				}
				catch(Exception Exc)
				{
					MessageBox.Show("Table Inexistante",
						"Gestion Restaurant");}			
			}
		}

		private void textRechProd_TextChanged_1(object sender, System.EventArgs e)
		{
			if (rdNom.Checked)
				FilterProduit("LibelleProduit", textRechProd.Text);
			if (rdRef.Checked)
				FilterProduit("RefProduit", textRechProd.Text);
		
		}

		private void ZoneTables_MouseDown_2(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			bool Existe=false;
			ZoneTables.Cursor=Cursors.Hand;
			posXT1=e.X/42;
			posYT1=e.Y/42;
			int position_x=(e.X/42);
			int position_y=(e.Y/42);
			for (int t=0; t<nbtables; t++)
				if (T[t].GetPosX()==position_x+1 && T[t].GetPosY()==position_y+1)
					Existe = true;
			if (Existe==false)
			{
					AjouTable AjT= new AjouTable();
				if(MessageBox.Show("Creer une table ici ?",
					"Gestion du Restaurant",MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
						AjT.ShowDialog();
					creerTable(position_x+1,position_y+1,AjT.numeroTable);}

			}
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			double Sum=0;
			if(ListSelection.Items.Count==0)
				button16.Enabled=false;
			else
				button16.Enabled=true;
			if (label16.Text =="0")
				button20.Enabled=false;
			else button20.Enabled=true;;
			try
			{
				for(int i=0;i<listView1.Items.Count;i++)
				{
					Sum+= System.Convert.ToDouble(listView1.Items[i].SubItems[1].Text)*
						System.Convert.ToDouble(listView1.Items[i].SubItems[4].Text);
				}
			}
			catch(Exception ec)
			{timer1.Enabled=false;
				MessageBox.Show(listView1.Items[0].SubItems[1].Text+"  "+
									listView1.Items[0].SubItems[4].Text+"  "+
									ec.ToString());
				
			}
			finally{label16.Text=Sum.ToString();}

		}

		private void button20_Click(object sender, System.EventArgs e)
		{int NumTable=System.Convert.ToInt32(ListSelection.Items[0].ToString());
			double Somme=0;
			string DetailsTicket="";
			DetailsTicket+="ADDITION TABLE "+NumTable.ToString()+"\n\n";;
			DetailsTicket+="DATE : "+ DateTime.Now.ToShortDateString()+"\n\n";
			for (int i=0;i<listView1.Items.Count;i++)
			{
				DetailsTicket+=listView1 .Items[i].SubItems[1].Text +" X " ;				
				DetailsTicket+=listView1.Items[i].SubItems[2].Text+"\t";
				DetailsTicket+=listView1.Items[i].SubItems[3].Text+"\n\t";
				DetailsTicket+= (System.Convert.ToDouble(listView1.Items[i].SubItems[4].Text )*
					System.Convert.ToDouble(listView1.Items[i].SubItems[1].Text)).ToString()+"\n";
				Somme+=System.Convert.ToDouble(listView1.Items[i].SubItems[4].Text )*
					System.Convert.ToDouble(listView1.Items[i].SubItems[1].Text);
			}
			DetailsTicket+="\n\nTOTAL HT\t"+Somme.ToString();
			DetailsTicket+="\n\nTVA\t 18.36%";
			DetailsTicket+="\n\nTOTAL A PAYER TTC \n\t"+(Math.Round(1.1836*Somme,2).ToString());
			Ticket T= new Ticket(DetailsTicket);
			T.ShowDialog();
		
		}

		
		
		private void button21_Click_1(object sender, System.EventArgs e)
		{
		
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			Clavier C= new Clavier();
			C.ShowDialog(this);		

		}

		
		private void textRechProd_Enter(object sender, System.EventArgs e)
		{
			Clavier C= new Clavier();
			C.ShowDialog(this);		
		}

	

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
				if(rdDateRes.Checked)
						FilterRes("DateReservation",dateTimePicker1.Value.ToShortDateString());
					else 
						FilterRes("DateReservation","");

		}

		private void dateTimePicker1_Click(object sender, System.EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{ 

			if(rdCodeRes.Checked)
				FilterRes("ReservTables.NumReservation",textBox2.Text);
			if(rdIdClient.Checked)
				FilterRes("Client.NumClient",textBox2.Text);
			if(rdNomClient.Checked)
				FilterRes("Client.NomClient",textBox2.Text);
			if(rdPrenomClient.Checked)
				FilterRes("Client.PrenomClient",textBox2.Text);

		}

		private void textBox2_Enter(object sender, System.EventArgs e)
		{
			Clavier C= new Clavier();
			C.ShowDialog(this);
		}


		private void dataGrid3_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne)
		{
		
		}

		private void button15_Click(object sender, System.EventArgs e)
		{
			AddResto AddPlat = new AddResto("Plat");
			AddPlat.ShowDialog();
		}

		private void button28_Click(object sender, System.EventArgs e)
		{
			AddResto AProd=new AddResto("Produit");
			AProd.ShowDialog();
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			AddResto AProd=new AddResto("Vin");
			AProd.ShowDialog();		
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
		
		 
			 string NumRes=dataGrid4[dataGrid4.CurrentCell.RowNumber,8].ToString();
			 if (MessageBox.Show("Confirmer suppression Réservation N° "+NumRes,"",MessageBoxButtons.YesNo)==DialogResult.No)
				 return;
			
			 try
			 {
				 oleDbDataAdapter4.DeleteCommand.Connection.Open();
				 oleDbDataAdapter4.DeleteCommand.CommandText= "delete from ReservTables where NumReservation ="+NumRes;
				 for (int i=0;i<nbtables;i++)
				 {
					 if (T[i].GetNumTable().ToString()==dataGrid4[dataGrid4.CurrentCell.RowNumber,0].ToString())
						 T[i].SetEtatCourant(0);
				 }
				 oleDbDataAdapter4.DeleteCommand.ExecuteNonQuery();
				 dsRes1.Clear();
				 oleDbDataAdapter4.Fill(dsRes1);

			 }
			 catch(Exception Ex){MessageBox.Show(Ex.ToString());}
			 dataGrid4.Refresh();
			 AfficherTables();
		
		}

		private void button24_Click(object sender, System.EventArgs e)
		{if(oleDbDataAdapter5.DeleteCommand.Connection.State != ConnectionState.Open)
			oleDbDataAdapter5.DeleteCommand.Connection.Open();
			try
		 {
		
			oleDbDataAdapter5.DeleteCommand.CommandText="Delete from  Commande where NumTable ="+
				 ListSelection.Items[0].ToString(); 
			oleDbDataAdapter5.DeleteCommand.ExecuteNonQuery();
			dscommtable1.Clear();
			oleDbDataAdapter5.Fill(dscommtable1);
			this.Show();
				for(int i=0;i<nbtables;i++)
					if (T[i].GetNumTable().ToString()==ListSelection.Items[0].ToString())
					{
						ChargerComandeTable(T[i].GetNumTable());
						T[i].SetEtatCourant(0);
					}
				ChargerDonneeTable();
				AfficherTables();
		 }
		catch(Exception Exc){MessageBox.Show("Erreur de solde"+Exc.ToString());}
		}

		private void button27_Click(object sender, System.EventArgs e)
		{
		
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			FilterProduit("TypeProduit",comboBox1.Text);
		}

		private void button16_Click_1(object sender, System.EventArgs e)
		{
			NouvelleReservation NewRes = new NouvelleReservation();
			NewRes.ShowDialog();
			if(NewRes.reserver ==true)
			{
				try
				{
					if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open )
						oleDbDataAdapter1.SelectCommand.Connection.Open();
				
					STRSQL = "insert into ReservTables (NumTable, NumClient,DateReservation) values ("+
						ListSelection.Items[0].ToString()+", "+
						NewRes.NumClient+", "+
						"'"+System.Convert.ToDateTime(NewRes.DateRes)+"')";
					CommandSql = new OleDbCommand(STRSQL, oleDbDataAdapter1.SelectCommand.Connection);
					CommandSql.ExecuteNonQuery();}
			
			catch(Exception exc ){MessageBox.Show(STRSQL+"\n\n"+exc.ToString());}
			}
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			AddModifMenu MenuCreat = new AddModifMenu();

			MenuCreat.ShowDialog();
		}

		private void ZoneTables_Click_1(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void ZoneTables_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
		}

	
	}
}
