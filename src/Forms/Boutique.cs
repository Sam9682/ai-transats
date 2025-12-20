using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Transacts
{
	/// <summary>
	/// Summary description for Boutique.
	/// </summary>
	public class Boutique : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Transacts.dsProdsBoutique dsProdsBoutique1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private Transacts.dsProdFamiliesBoutique dsProdFamiliesBoutique1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private Transacts.dsinfosClients dsinfosClients1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.NumericUpDown qteProd;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label10;
		private Transacts.dsConsoBoutique dsConsoBoutique1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.ComponentModel.IContainer components;

		public Boutique()
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
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsProdsBoutique1 = new Transacts.dsProdsBoutique();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dsProdFamiliesBoutique1 = new Transacts.dsProdFamiliesBoutique();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.button4 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.dsConsoBoutique1 = new Transacts.dsConsoBoutique();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.dsinfosClients1 = new Transacts.dsinfosClients();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
			this.qteProd = new System.Windows.Forms.NumericUpDown();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dsProdsBoutique1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsProdFamiliesBoutique1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dsConsoBoutique1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsinfosClients1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.qteProd)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
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
																																																				   new System.Data.Common.DataColumnMapping("Famille Produit", "Famille Produit"),
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
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Famille Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Famille Produit", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Produit(RefProduit, LibelleProduit, TypeProduit, PrixUnit) VALUES (?," +
				" ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Produit"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Famille Produit"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT RefProduit AS Référence, LibelleProduit AS [Nom Produit], TypeProduit AS [" +
				"Famille Produit], PrixUnit AS [Prix Unitaire] FROM Produit";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Produit SET RefProduit = ?, LibelleProduit = ?, TypeProduit = ?, PrixUnit = ? WHERE (RefProduit = ?) AND (LibelleProduit = ? OR ? IS NULL AND LibelleProduit IS NULL) AND (PrixUnit = ? OR ? IS NULL AND PrixUnit IS NULL) AND (TypeProduit = ? OR ? IS NULL AND TypeProduit IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Produit"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Famille Produit"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.Single, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(7)), ((System.Byte)(0)), "Prix Unitaire", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Famille Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Famille Produit", System.Data.DataRowVersion.Original, null));
			// 
			// dsProdsBoutique1
			// 
			this.dsProdsBoutique1.DataSetName = "dsProdsBoutique";
			this.dsProdsBoutique1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsProdsBoutique1.Namespace = "http://www.tempuri.org/dsProdsBoutique.xsd";
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackgroundColor = System.Drawing.Color.Azure;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.AliceBlue;
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Black;
			this.dataGrid1.CaptionText = "Liste des produits";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dsProdsBoutique1.Produit;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.HeaderBackColor = System.Drawing.Color.Cornsilk;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(400, 336);
			this.dataGrid1.TabIndex = 0;
			this.dataGrid1.TabStop = false;
			this.dataGrid1.Click += new System.EventHandler(this.dataGrid1_Click);
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(8, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(8, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(152, 24);
			this.radioButton1.TabIndex = 20;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Référence Produit";
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(8, 72);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(120, 24);
			this.radioButton2.TabIndex = 30;
			this.radioButton2.Text = "Nom Produit";
			// 
			// radioButton3
			// 
			this.radioButton3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(216, 32);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 40;
			this.radioButton3.Text = "Famille";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.dsProdFamiliesBoutique1.Produit;
			this.comboBox1.DisplayMember = "TypeProduit";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox1.Location = new System.Drawing.Point(216, 64);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(160, 26);
			this.comboBox1.TabIndex = 202;
			this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dsProdFamiliesBoutique1
			// 
			this.dsProdFamiliesBoutique1.DataSetName = "dsProdFamiliesBoutique";
			this.dsProdFamiliesBoutique1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsProdFamiliesBoutique1.Namespace = "http://www.tempuri.org/dsProdFamiliesBoutique.xsd";
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
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.button8,
																					this.button7,
																					this.button6,
																					this.label10,
																					this.listBox3,
																					this.button4,
																					this.label9,
																					this.label8,
																					this.label7,
																					this.button3,
																					this.label6,
																					this.textBox5,
																					this.label5,
																					this.textBox4,
																					this.label4,
																					this.textBox3,
																					this.label3,
																					this.label2,
																					this.listBox4,
																					this.listBox2,
																					this.listBox1,
																					this.textBox2,
																					this.label1,
																					this.button2});
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(416, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(408, 536);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.Cornsilk;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button8.Location = new System.Drawing.Point(248, 472);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(152, 40);
			this.button8.TabIndex = 213;
			this.button8.Text = "Retour";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Cornsilk;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.Location = new System.Drawing.Point(144, 424);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(96, 40);
			this.button7.TabIndex = 212;
			this.button7.Text = "Ticket";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Cornsilk;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.Location = new System.Drawing.Point(8, 16);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(128, 80);
			this.button6.TabIndex = 211;
			this.button6.Text = "Charger Consommation Client";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(8, 192);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 24);
			this.label10.TabIndex = 210;
			this.label10.Text = "Référence";
			// 
			// listBox3
			// 
			this.listBox3.BackColor = System.Drawing.Color.AntiqueWhite;
			this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.listBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox3.ItemHeight = 16;
			this.listBox3.Location = new System.Drawing.Point(8, 216);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(72, 178);
			this.listBox3.TabIndex = 209;
			this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Cornsilk;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(144, 472);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(96, 40);
			this.button4.TabIndex = 208;
			this.button4.Text = "Solder";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(120, 192);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 24);
			this.label9.TabIndex = 207;
			this.label9.Text = "Désignation";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(328, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 24);
			this.label8.TabIndex = 206;
			this.label8.Text = "Prix Unitaire";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(80, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 24);
			this.label7.TabIndex = 205;
			this.label7.Text = "Qté";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cornsilk;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(8, 472);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 40);
			this.button3.TabIndex = 204;
			this.button3.Text = "Supprimer Commande";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(272, 400);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 15);
			this.label6.TabIndex = 21;
			this.label6.Text = "Total TTC";
			// 
			// textBox5
			// 
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Enabled = false;
			this.textBox5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox5.ForeColor = System.Drawing.Color.Black;
			this.textBox5.Location = new System.Drawing.Point(288, 48);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(112, 26);
			this.textBox5.TabIndex = 5;
			this.textBox5.TabStop = false;
			this.textBox5.Text = "";
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			this.textBox5.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(152, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 24);
			this.label5.TabIndex = 20;
			this.label5.Text = "Numéro Compte";
			// 
			// textBox4
			// 
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Enabled = false;
			this.textBox4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox4.ForeColor = System.Drawing.Color.Black;
			this.textBox4.Location = new System.Drawing.Point(240, 112);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(160, 26);
			this.textBox4.TabIndex = 4;
			this.textBox4.TabStop = false;
			this.textBox4.Text = "";
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			this.textBox4.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(152, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 24);
			this.label4.TabIndex = 18;
			this.label4.Text = "Prénom";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Enabled = false;
			this.textBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox3.ForeColor = System.Drawing.Color.Black;
			this.textBox3.Location = new System.Drawing.Point(240, 80);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(160, 26);
			this.textBox3.TabIndex = 3;
			this.textBox3.TabStop = false;
			this.textBox3.Text = "";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			this.textBox3.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(152, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 24);
			this.label3.TabIndex = 16;
			this.label3.Text = "Nom";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 24);
			this.label2.TabIndex = 15;
			this.label2.Text = "Consommations";
			// 
			// listBox4
			// 
			this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox4.ItemHeight = 16;
			this.listBox4.Location = new System.Drawing.Point(80, 216);
			this.listBox4.Name = "listBox4";
			this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBox4.Size = new System.Drawing.Size(40, 178);
			this.listBox4.TabIndex = 14;
			// 
			// listBox2
			// 
			this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(120, 216);
			this.listBox2.Name = "listBox2";
			this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBox2.Size = new System.Drawing.Size(208, 178);
			this.listBox2.TabIndex = 12;
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(328, 216);
			this.listBox1.Name = "listBox1";
			this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.listBox1.Size = new System.Drawing.Size(72, 178);
			this.listBox1.TabIndex = 11;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Enabled = false;
			this.textBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(248, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(152, 26);
			this.textBox2.TabIndex = 2;
			this.textBox2.TabStop = false;
			this.textBox2.Text = "";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.textBox2.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Code Client";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(8, 424);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 40);
			this.button2.TabIndex = 203;
			this.button2.Text = "Supprimer Ligne";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dsConsoBoutique1
			// 
			this.dsConsoBoutique1.DataSetName = "dsConsoBoutique";
			this.dsConsoBoutique1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsConsoBoutique1.Namespace = "http://www.tempuri.org/dsConsoBoutique.xsd";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(152, 352);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 48);
			this.button1.TabIndex = 8;
			this.button1.Text = "Ajouter >>";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Client", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("NumClient", "NumClient"),
																																																				  new System.Data.Common.DataColumnMapping("NomClient", "NomClient"),
																																																				  new System.Data.Common.DataColumnMapping("PrenomClient", "PrenomClient"),
																																																				  new System.Data.Common.DataColumnMapping("NumCompteJournalier", "NumCompteJournalier")})});
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = "SELECT Client.NumClient, Client.NomClient, Client.PrenomClient, CompteJournalier." +
				"NumCompteJournalier FROM (Client INNER JOIN CompteJournalier ON Client.NumClient" +
				" = CompteJournalier.RefClient)";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// dsinfosClients1
			// 
			this.dsinfosClients1.DataSetName = "dsinfosClients";
			this.dsinfosClients1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsinfosClients1.Namespace = "http://www.tempuri.org/dsinfosClients.xsd";
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Produit", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Qte", "Qte"),
																																																				   new System.Data.Common.DataColumnMapping("LibelleProduit", "LibelleProduit"),
																																																				   new System.Data.Common.DataColumnMapping("PrixUnit", "PrixUnit"),
																																																				   new System.Data.Common.DataColumnMapping("Produit.RefProduit", "Produit.RefProduit"),
																																																				   new System.Data.Common.DataColumnMapping("NumConso", "NumConso"),
																																																				   new System.Data.Common.DataColumnMapping("RefProduit", "RefProduit"),
																																																				   new System.Data.Common.DataColumnMapping("RefProd", "RefProd")})});
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = @"SELECT ConsoBoutiqueProds.Qte, Produit.LibelleProduit, Produit.PrixUnit, Produit.RefProduit, ConsoBoutiqueProds.NumConso, ConsoBoutiqueProds.RefProduit AS RefProduit, Produit.RefProduit AS RefProd FROM (((Produit INNER JOIN ConsoBoutiqueProds ON Produit.RefProduit = ConsoBoutiqueProds.RefProduit) INNER JOIN ConsoBoutique ON ConsoBoutiqueProds.NumConso = ConsoBoutique.NumConsommation) INNER JOIN Client ON ConsoBoutique.NumClient = Client.NumClient)";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// qteProd
			// 
			this.qteProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.qteProd.Location = new System.Drawing.Point(304, 352);
			this.qteProd.Minimum = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			this.qteProd.Name = "qteProd";
			this.qteProd.Size = new System.Drawing.Size(48, 38);
			this.qteProd.TabIndex = 203;
			this.qteProd.Value = new System.Decimal(new int[] {
																  1,
																  0,
																  0,
																  0});
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Cornsilk;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.Location = new System.Drawing.Point(8, 352);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(136, 48);
			this.button5.TabIndex = 204;
			this.button5.Text = "Ajouter / Modifier Produit";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.comboBox1,
																					this.textBox1,
																					this.radioButton2,
																					this.radioButton3,
																					this.radioButton1});
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(8, 408);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(400, 136);
			this.groupBox2.TabIndex = 205;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Recherche";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(264, 360);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(17, 19);
			this.label11.TabIndex = 206;
			this.label11.Text = "X";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.Cornsilk;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button9.Location = new System.Drawing.Point(352, 352);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(40, 40);
			this.button9.TabIndex = 214;
			this.button9.Text = "Qte-";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.Cornsilk;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button10.Location = new System.Drawing.Point(264, 352);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(40, 40);
			this.button10.TabIndex = 215;
			this.button10.Text = "Qte+";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// Boutique
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(832, 568);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button10,
																		  this.label11,
																		  this.groupBox2,
																		  this.button5,
																		  this.qteProd,
																		  this.button1,
																		  this.groupBox1,
																		  this.dataGrid1,
																		  this.button9});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Boutique";
			this.Text = "Boutique";
			this.Load += new System.EventHandler(this.Boutique_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsProdsBoutique1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsProdFamiliesBoutique1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dsConsoBoutique1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsinfosClients1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.qteProd)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Boutique_Load(object sender, System.EventArgs e)
		{
			oleDbDataAdapter1.Fill(dsProdsBoutique1);
			dataGrid1.Refresh();
			oleDbDataAdapter2.Fill(dsProdFamiliesBoutique1);
			comboBox1.Refresh();
			oleDbDataAdapter3.Fill(dsinfosClients1);
		}
		private void FilterClients(string Col, string Value)
		{
			string STRSQL="SELECT Client.NumClient, Client.NomClient, Client.PrenomClient,"+ 
		    " CompteJournalier.NumCompteJournalier FROM (Client "+
			" INNER JOIN CompteJournalier ON Client.NumClient = CompteJournalier.RefClient) Where "+Col +"="+Value;
			oleDbDataAdapter3.SelectCommand.CommandText=STRSQL;
			dsinfosClients1.Clear();
			oleDbDataAdapter3.Fill(dsinfosClients1);
			if(dsinfosClients1.Tables[0].Rows.Count>0)
			{
				textBox2.Text=dsinfosClients1.Tables[0].Rows[0].ItemArray[0].ToString();
				textBox3.Text=dsinfosClients1.Tables[0].Rows[0].ItemArray[1].ToString();
				textBox4.Text=dsinfosClients1.Tables[0].Rows[0].ItemArray[2].ToString();
				textBox5.Text=dsinfosClients1.Tables[0].Rows[0].ItemArray[3].ToString();
			}
			else
			{
				textBox3.Text="";
				textBox4.Text="";
				textBox5.Text="";

			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(radioButton2.Checked)
				FilterProduits("LibelleProduit",textBox1.Text);
			if(radioButton1.Checked)
				FilterProduits("RefProduit",textBox1.Text);
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
				if(radioButton3.Checked)
						FilterProduits("TypeProduit",comboBox1.Text);
			
		}
		private void FilterProduits(string Col, string valeur)
		{
			string STRSQL ="Select RefProduit AS [Référence], LibelleProduit AS [Nom Produit], "+
				" TypeProduit AS [Famille Produit], PrixUnit AS [Prix Unitaire]"+
				" from Produit Where "+ Col.ToString() +" Like '"+valeur+"%'";
			try
			{
				if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)
					oleDbDataAdapter1.SelectCommand.Connection.Open();
				dsProdsBoutique1.Clear();
				oleDbDataAdapter1.SelectCommand.CommandText= STRSQL;
				oleDbDataAdapter1.Fill(dsProdsBoutique1);
				dataGrid1.Refresh();
				
			}
			catch(Exception ec){MessageBox.Show(ec.ToString());}
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			Clavier C = new Clavier();
			C.ShowDialog(this);
		}

		private void textBox2_Enter(object sender, System.EventArgs e)
		{
			Clavier C =new Clavier();
			C.ShowDialog(this);

		}

		private void comboBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked)
				FilterProduits("TypeProduit",comboBox1.Text);

		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				System.Convert.ToInt32(textBox2.Text);
			}
			catch(Exception Exc){;;}
			
		FilterClients("Client.NumClient",textBox2.Text);
		ChargerConsommationClient(textBox2.Text);
		}

		private void ChargerConsommationClient(string NumClient)
		{
			dsConsoBoutique1.Clear();
			string querySelecttext;

			querySelecttext= "SELECT "+
				" ConsoBoutiqueProds.Qte, "+
				" Produit.LibelleProduit, "+
				" Produit.PrixUnit, "+
				" ConsoBoutiqueProds.NumConso, "+
				" ConsoBoutiqueProds.RefProduit, "+
				" Produit.RefProduit As RefProd"+
				" 	FROM"+
				" (((Produit INNER JOIN ConsoBoutiqueProds ON"+
				" Produit.RefProduit = ConsoBoutiqueProds.RefProduit) "+
				" INNER JOIN ConsoBoutique ON "+
				"    ConsoBoutiqueProds.NumConso = ConsoBoutique.NumConsommation) "+
				" INNER JOIN Client ON ConsoBoutique.NumClient = Client.NumClient)	"+	
				"Where Client.NumClient = "+NumClient;
			oleDbDataAdapter4.SelectCommand.CommandText=querySelecttext;
			try
			{
				oleDbDataAdapter4.Fill(dsConsoBoutique1);
				if(dsConsoBoutique1.Tables[0].Rows.Count>0)
				{
					NumConsommation=(int)dsConsoBoutique1.Tables[0].Rows[0].ItemArray[3];
				}
				else{;
					addConsommation();
				}
			}
			catch(Exception ecx) {MessageBox.Show(oleDbDataAdapter4.SelectCommand.CommandText+"\n\n\n"+ecx.ToString());}
			listBox1.Refresh();
		}
		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void textBox4_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void textBox5_TextChanged(object sender, System.EventArgs e)
		{
			
		}
		private int NumConsommation=0;
		
		private void button1_Click(object sender, System.EventArgs e)
		{
			for(int i=0; i<listBox2.Items.Count; i++)
				if(listBox3.Items[i].ToString()==dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString())
				{
				    listBox4.Items[i]=(System.Convert.ToInt32(listBox4.Items[i])+qteProd.Value).ToString();
					return;
				}
			listBox3.Items.Add(dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString());
			listBox1.Items.Add(dataGrid1[dataGrid1.CurrentCell.RowNumber,3].ToString());
			listBox2.Items.Add(dataGrid1[dataGrid1.CurrentCell.RowNumber,1].ToString());
			listBox4.Items.Add(qteProd.Value.ToString());
//			string NumConsom="";
//			
//			string sqlStr= "select NumConsommation from ConsoBoutique Where NumClient  ="+
//				textBox2.Text;
//			
//			try
//			{
//				if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)
//					oleDbDataAdapter1.SelectCommand.Connection.Open();
//				OleDbCommand olecom=new OleDbCommand(sqlStr,oleDbDataAdapter1.SelectCommand.Connection);
//				NumConsom=olecom.ExecuteScalar().ToString();
//			}
//			catch(Exception exc) {;;}
//			string STRSQL = "Insert into ConsoBoutiqueProds values ("+
//				NumConsom.ToString()+", "+
//				dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString()+", "+
//				qteProd.Value.ToString()+")";
//			try
//			{
//				if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)
//					oleDbDataAdapter1.SelectCommand.Connection.Open();
//				OleDbCommand commSql = new OleDbCommand(STRSQL,oleDbDataAdapter1.SelectCommand.Connection);
//				NumConsommation = (int) commSql.ExecuteNonQuery();
//				
//			}
//			catch(Exception exc){
//				;;	
//				}
//			dsConsoBoutique1.Clear();
//			oleDbDataAdapter4.Fill(dsConsoBoutique1);
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			AddResto Adrest = new AddResto("Produit");
			Adrest.ShowDialog();
			oleDbDataAdapter1.Fill(dsProdsBoutique1);
			dataGrid1.Refresh();
		}

		private void addConsommation()
		{int Numero=0;
			string STRSQL = "Insert into ConsoBoutique(NumCompteJ,NumCLient) values ("+
				textBox5.Text+", "+
				textBox2.Text+");";
			try
			{
				if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)
					oleDbDataAdapter1.SelectCommand.Connection.Open();
				OleDbCommand commSql = new OleDbCommand(STRSQL,oleDbDataAdapter1.SelectCommand.Connection);
				commSql.ExecuteNonQuery();

			}
			catch(Exception exce){MessageBox.Show("Ce client n'a pas de compte journalier");}
		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		string STRSQL = "DELETE FROM CONSOBOUTIQUEPRODS WHERE NUMCONSO = "+
			NumConsommation.ToString() +
			" AND REFPRODUIT = " + listBox3.Text;
			if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)
				oleDbDataAdapter1.SelectCommand.Connection.Open();
			OleDbCommand commdelete= new OleDbCommand(STRSQL,oleDbDataAdapter1.SelectCommand.Connection);
			try
			{
				commdelete.ExecuteNonQuery();
			}catch(Exception exc){;;}
			dsConsoBoutique1.Clear();
			oleDbDataAdapter4.Fill(dsConsoBoutique1);
			try
			{
				listBox4.Items.RemoveAt(listBox3.SelectedIndex);
				listBox2.Items.RemoveAt(listBox3.SelectedIndex);
				listBox1.Items.RemoveAt(listBox3.SelectedIndex);
				listBox3.Items.RemoveAt(listBox3.SelectedIndex);
			}
			catch(Exception exc){MessageBox.Show(exc.ToString());}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{OleDbCommand commdelete;
			for (int i=0;i<listBox3.Items.Count;i++)
			{listBox3.SelectedIndex=i;
				string STRSQL = "DELETE FROM CONSOBOUTIQUEPRODS WHERE NUMCONSO = "+
					NumConsommation.ToString() +
					" AND REFPRODUIT = " + listBox3.Text;
				if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open)
					oleDbDataAdapter1.SelectCommand.Connection.Open();
				commdelete= new OleDbCommand(STRSQL,oleDbDataAdapter1.SelectCommand.Connection);
				try
				{
					commdelete.ExecuteNonQuery();
				}
				catch(Exception exc){MessageBox.Show(STRSQL+"\n\n"+exc.ToString());}
			}
			dsConsoBoutique1.Clear();
			oleDbDataAdapter4.Fill(dsConsoBoutique1);
		
		}

		private void dataGrid1_Click(object sender, System.EventArgs e)
		{
			
		}

		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			Caisse Kess = new Caisse();
			Kess.ShowDialog();
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			textBox2.Enabled=true;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			double SommeCommande=0;
			try
			{
				for (int i=0;i<listBox1.Items.Count;i++)
					SommeCommande+=System.Convert.ToDouble(listBox1.Items[i].ToString())*
						System.Convert.ToDouble(listBox4.Items[i].ToString());
				label6.Text="Total TTC :"+SommeCommande.ToString();
			}
			catch(Exception Exc){MessageBox.Show(listBox4.Text[0].ToString()+"\n"+listBox1.Text[0].ToString());
									timer1.Enabled=false;}

					
		}

		private void button7_Click(object sender, System.EventArgs e)
		{string DetailsTicket="";
			double Somme=0;
			DetailsTicket+="DATE "+DateTime.Now.ToShortDateString()+"\n\n";
			
			for (int i=0;i<listBox1.Items.Count;i++)
			{
				DetailsTicket+=listBox4.Items[i].ToString() +" X " ;				
				DetailsTicket+=listBox3.Items[i].ToString()+"\t";
				DetailsTicket+=listBox2.Items[i].ToString()+"\n\t";
				DetailsTicket+= (System.Convert.ToDouble(listBox1.Items[i].ToString() )*
					System.Convert.ToDouble(listBox4.Items[i].ToString())).ToString()+"\n";
				Somme+=(System.Convert.ToDouble(listBox1.Items[i].ToString() )*
					System.Convert.ToDouble(listBox4.Items[i].ToString()));
			}
			DetailsTicket+="\n\nTOTAL HT\t"+Somme.ToString();
			DetailsTicket+="\n\nTVA\t 18.36%";
			DetailsTicket+="\n\nTOTAL A PAYER TTC \n\t"+(Math.Round(1.1836*Somme,2).ToString());
			Ticket T =new Ticket(DetailsTicket);
			T.ShowDialog(this);
		}

		private void button10_Click(object sender, System.EventArgs e)
		{
			qteProd.Value++;
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			if(qteProd.Value>1)qteProd.Value--;
		}

		private void listBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}
	}
}
