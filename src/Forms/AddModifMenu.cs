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
	/// Summary description for AddModifMenu.
	/// </summary>
	public class AddModifMenu : System.Windows.Forms.Form
	{
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Transacts.dsmenusProduits dsmenusProduits1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private Transacts.dsetmenus dsetmenus1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
		private Transacts.dsproduitsreso dsproduitsreso1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter4;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
		private Transacts.dsProdFamilies dsProdFamilies1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddModifMenu()
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
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.dsmenusProduits1 = new Transacts.dsmenusProduits();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.dsetmenus1 = new Transacts.dsetmenus();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
			this.dsproduitsreso1 = new Transacts.dsproduitsreso();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.oleDbDataAdapter4 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
			this.dsProdFamilies1 = new Transacts.dsProdFamilies();
			((System.ComponentModel.ISupportInitialize)(this.dsmenusProduits1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsetmenus1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsproduitsreso1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsProdFamilies1)).BeginInit();
			this.SuspendLayout();
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
																																																				   new System.Data.Common.DataColumnMapping("TypeProduit", "TypeProduit")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Produit WHERE (RefProduit = ?) AND (LibelleProduit = ? OR ? IS NULL A" +
				"ND LibelleProduit IS NULL) AND (TypeProduit = ? OR ? IS NULL AND TypeProduit IS " +
				"NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LibelleProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LibelleProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeProduit", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Produit(RefProduit, LibelleProduit, TypeProduit) VALUES (?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefProduit", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "LibelleProduit"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "TypeProduit"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT RefProduit, LibelleProduit, TypeProduit FROM Produit";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Produit SET RefProduit = ?, LibelleProduit = ?, TypeProduit = ? WHERE (Ref" +
				"Produit = ?) AND (LibelleProduit = ? OR ? IS NULL AND LibelleProduit IS NULL) AN" +
				"D (TypeProduit = ? OR ? IS NULL AND TypeProduit IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefProduit", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "LibelleProduit"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "TypeProduit"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LibelleProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "LibelleProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeProduit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TypeProduit", System.Data.DataRowVersion.Original, null));
			// 
			// dsmenusProduits1
			// 
			this.dsmenusProduits1.DataSetName = "dsmenusProduits";
			this.dsmenusProduits1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsmenusProduits1.Namespace = "http://www.tempuri.org/dsmenusProduits.xsd";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Référence Menu";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.textBox1.Location = new System.Drawing.Point(136, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(136, 26);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.textBox2.Location = new System.Drawing.Point(136, 80);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(136, 26);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "";
			this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Prix Unitaire";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.textBox3.Location = new System.Drawing.Point(136, 48);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(136, 26);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "";
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nom Menu";
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Menu", new System.Data.Common.DataColumnMapping[] {
																																																				new System.Data.Common.DataColumnMapping("NomMenu", "NomMenu"),
																																																				new System.Data.Common.DataColumnMapping("PrixUnit", "PrixUnit"),
																																																				new System.Data.Common.DataColumnMapping("RefMenu", "RefMenu")})});
			this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT NomMenu, PrixUnit, RefMenu FROM Menu";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Menu(NomMenu, PrixUnit, RefMenu) VALUES (?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomMenu", System.Data.OleDb.OleDbType.VarWChar, 50, "NomMenu"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.VarWChar, 50, "PrixUnit"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefMenu", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefMenu", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = "UPDATE Menu SET NomMenu = ?, PrixUnit = ?, RefMenu = ? WHERE (RefMenu = ?) AND (N" +
				"omMenu = ? OR ? IS NULL AND NomMenu IS NULL) AND (PrixUnit = ? OR ? IS NULL AND " +
				"PrixUnit IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomMenu", System.Data.OleDb.OleDbType.VarWChar, 50, "NomMenu"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrixUnit", System.Data.OleDb.OleDbType.VarWChar, 50, "PrixUnit"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefMenu", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefMenu", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefMenu", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefMenu", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomMenu", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NomMenu", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomMenu1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NomMenu", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = "DELETE FROM Menu WHERE (RefMenu = ?) AND (NomMenu = ? OR ? IS NULL AND NomMenu IS" +
				" NULL) AND (PrixUnit = ? OR ? IS NULL AND PrixUnit IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefMenu", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "RefMenu", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomMenu", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NomMenu", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomMenu1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NomMenu", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrixUnit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrixUnit", System.Data.DataRowVersion.Original, null));
			// 
			// dsetmenus1
			// 
			this.dsetmenus1.DataSetName = "dsetmenus";
			this.dsetmenus1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsetmenus1.Namespace = "http://www.tempuri.org/dsetmenus.xsd";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(280, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 40);
			this.button1.TabIndex = 9;
			this.button1.Text = "Ajouter / Modifier";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(280, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 40);
			this.button2.TabIndex = 10;
			this.button2.Text = "Annuler";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(16, 288);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 32);
			this.button3.TabIndex = 11;
			this.button3.Text = "Supprimer du Menu";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(392, 280);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 40);
			this.button4.TabIndex = 12;
			this.button4.Text = "<<  Ajouter";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// dataGrid2
			// 
			this.dataGrid2.BackgroundColor = System.Drawing.Color.Azure;
			this.dataGrid2.CaptionBackColor = System.Drawing.Color.Beige;
			this.dataGrid2.CaptionForeColor = System.Drawing.Color.Black;
			this.dataGrid2.CaptionText = "Liste des Produits";
			this.dataGrid2.DataMember = "";
			this.dataGrid2.DataSource = this.dsproduitsreso1.Produit;
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(392, 8);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.PreferredColumnWidth = 100;
			this.dataGrid2.ReadOnly = true;
			this.dataGrid2.SelectionBackColor = System.Drawing.Color.Blue;
			this.dataGrid2.Size = new System.Drawing.Size(320, 264);
			this.dataGrid2.TabIndex = 13;
			// 
			// oleDbDataAdapter3
			// 
			this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
			this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
			this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
			this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Produit", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Référence Produit", "Référence Produit"),
																																																				   new System.Data.Common.DataColumnMapping("Nom Produit", "Nom Produit"),
																																																				   new System.Data.Common.DataColumnMapping("Famille Produit", "Famille Produit")})});
			this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
			// 
			// oleDbSelectCommand3
			// 
			this.oleDbSelectCommand3.CommandText = "SELECT RefProduit AS [Référence Produit], LibelleProduit AS [Nom Produit], TypePr" +
				"oduit AS [Famille Produit] FROM Produit";
			this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
			// 
			// oleDbInsertCommand3
			// 
			this.oleDbInsertCommand3.CommandText = "INSERT INTO Produit(RefProduit, LibelleProduit, TypeProduit) VALUES (?, ?, ?)";
			this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence Produit", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Produit"));
			this.oleDbInsertCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Famille Produit"));
			// 
			// oleDbUpdateCommand3
			// 
			this.oleDbUpdateCommand3.CommandText = "UPDATE Produit SET RefProduit = ?, LibelleProduit = ?, TypeProduit = ? WHERE (Ref" +
				"Produit = ?) AND (LibelleProduit = ? OR ? IS NULL AND LibelleProduit IS NULL) AN" +
				"D (TypeProduit = ? OR ? IS NULL AND TypeProduit IS NULL)";
			this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence Produit", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Produit"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, "Famille Produit"));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Famille Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Famille Produit", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbDeleteCommand3
			// 
			this.oleDbDeleteCommand3.CommandText = "DELETE FROM Produit WHERE (RefProduit = ?) AND (LibelleProduit = ? OR ? IS NULL A" +
				"ND LibelleProduit IS NULL) AND (TypeProduit = ? OR ? IS NULL AND TypeProduit IS " +
				"NULL)";
			this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_RefProduit", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Référence Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_LibelleProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Famille Produit", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand3.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TypeProduit1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Famille Produit", System.Data.DataRowVersion.Original, null));
			// 
			// dsproduitsreso1
			// 
			this.dsproduitsreso1.DataSetName = "dsproduitsreso";
			this.dsproduitsreso1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsproduitsreso1.Namespace = "http://www.tempuri.org/dsproduitsreso.xsd";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.dsProdFamilies1.Produit;
			this.comboBox1.DisplayMember = "TypeProduit";
			this.comboBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.comboBox1.Location = new System.Drawing.Point(576, 280);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(136, 26);
			this.comboBox1.TabIndex = 14;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.DataSource = this.dsmenusProduits1.Produit;
			this.listBox1.DisplayMember = "LibelleProduit";
			this.listBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(64, 176);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(160, 105);
			this.listBox1.TabIndex = 15;
			// 
			// listBox2
			// 
			this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox2.DataSource = this.dsmenusProduits1.Produit;
			this.listBox2.DisplayMember = "RefProduit";
			this.listBox2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox2.ItemHeight = 15;
			this.listBox2.Location = new System.Drawing.Point(16, 176);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(48, 105);
			this.listBox2.TabIndex = 16;
			// 
			// listBox3
			// 
			this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox3.DataSource = this.dsmenusProduits1.Produit;
			this.listBox3.DisplayMember = "TypeProduit";
			this.listBox3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox3.ItemHeight = 15;
			this.listBox3.Location = new System.Drawing.Point(224, 176);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(152, 105);
			this.listBox3.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label4.Location = new System.Drawing.Point(16, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 24);
			this.label4.TabIndex = 18;
			this.label4.Text = "Produits Servis";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 19;
			this.label5.Text = "Référence";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(88, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 16);
			this.label6.TabIndex = 20;
			this.label6.Text = "Nom Produit";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(224, 152);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 16);
			this.label7.TabIndex = 21;
			this.label7.Text = "Famille Produit";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(480, 280);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(96, 32);
			this.checkBox1.TabIndex = 22;
			this.checkBox1.Text = "Trier Par Famille";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// oleDbDataAdapter4
			// 
			this.oleDbDataAdapter4.SelectCommand = this.oleDbSelectCommand4;
			this.oleDbDataAdapter4.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Produit", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("TypeProduit", "TypeProduit")})});
			// 
			// oleDbSelectCommand4
			// 
			this.oleDbSelectCommand4.CommandText = "SELECT DISTINCT TypeProduit FROM Produit";
			this.oleDbSelectCommand4.Connection = this.oleDbConnection1;
			// 
			// dsProdFamilies1
			// 
			this.dsProdFamilies1.DataSetName = "dsProdFamilies";
			this.dsProdFamilies1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsProdFamilies1.Namespace = "http://www.tempuri.org/dsProdFamilies.xsd";
			// 
			// AddModifMenu
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 326);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.checkBox1,
																		  this.label7,
																		  this.label6,
																		  this.label5,
																		  this.label4,
																		  this.listBox3,
																		  this.listBox2,
																		  this.listBox1,
																		  this.comboBox1,
																		  this.dataGrid2,
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.button1,
																		  this.textBox3,
																		  this.label3,
																		  this.textBox2,
																		  this.label2,
																		  this.textBox1,
																		  this.label1});
			this.Name = "AddModifMenu";
			this.Text = "AddModifMenu";
			this.Load += new System.EventHandler(this.AddModifMenu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsmenusProduits1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsetmenus1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsproduitsreso1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsProdFamilies1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			Clavier C= new Clavier();
			C.ShowDialog(this);
		}

		private void textBox3_Enter(object sender, System.EventArgs e)
		{
			Clavier C= new Clavier();
			C.ShowDialog(this);
		}

		private void textBox2_Enter(object sender, System.EventArgs e)
		{
			Clavier C= new Clavier();
			C.ShowDialog(this);
		}


		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				oleDbDataAdapter2.SelectCommand.CommandText="select NomMenu,PrixUnit from Menu Where RefMenu = "+textBox1.Text;
				oleDbDataAdapter2.Fill(dsetmenus1);
				textBox2.Text=dsetmenus1.Tables[0].Rows[0].ItemArray[1].ToString();
				textBox3.Text=dsetmenus1.Tables[0].Rows[0].ItemArray[0].ToString();
			}
			catch(Exception exc){textBox3.Text="";textBox2.Text="";}
			if(textBox1.Text !="")
			{
				try
				{
					oleDbDataAdapter1.SelectCommand.CommandText="SELECT Produit.RefProduit, Produit.LibelleProduit, Produit.TypeProduit "+
						"FROM ((Menu INNER JOIN"+
						" MenuProduit ON Menu.RefMenu = MenuProduit.RefMenu) INNER JOIN"+
						" Produit ON MenuProduit.NumProduit = Produit.RefProduit) where Menu.RefMenu =" +textBox1.Text;
					dsmenusProduits1.Clear();
					oleDbDataAdapter1.Fill(dsmenusProduits1);
					listBox1.Refresh();}
			
				catch(Exception Exc){;;}
			}

		}

		private void textBox3_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				oleDbDataAdapter2.SelectCommand.CommandText="select RefMenu,PrixUnit from Menu Where NomMenu Like "+textBox3.Text+"%;";
				oleDbDataAdapter2.Fill(dsetmenus1);
				textBox1.Text=dsetmenus1.Tables[0].Rows[0].ItemArray[0].ToString();
				textBox2.Text=dsetmenus1.Tables[0].Rows[0].ItemArray[1].ToString();
			}
			catch(Exception exc){
				//textBox1.Text="";textBox2.Text="";
				;;
			}
			if(textBox1.Text !="")
			{
				try
				{
					oleDbDataAdapter1.SelectCommand.CommandText="SELECT Produit.RefProduit, Produit.LibelleProduit, Produit.TypeProduit "+
						"FROM ((Menu INNER JOIN"+
						" MenuProduit ON Menu.RefMenu = MenuProduit.RefMenu) INNER JOIN"+
						" Produit ON MenuProduit.NumProduit = Produit.RefProduit) where Menu.RefMenu =" +textBox1.Text;
					dsmenusProduits1.Clear();
					oleDbDataAdapter1.Fill(dsmenusProduits1);
					listBox1.Refresh();}
			
				catch(Exception Exc){;;}
			}
		}
		string STRSQL;
		private void button4_Click(object sender, System.EventArgs e)
		{
			if (listBox2.FindString(dataGrid2[dataGrid2.CurrentCell.RowNumber,0].ToString())<0)
			{
				try
				{
					if(oleDbConnection1.State != ConnectionState.Open)
						oleDbConnection1.Open();
					STRSQL = "Insert Into MenuProduit(NumProduit, RefMenu) values("+
						dataGrid2[dataGrid2.CurrentCell.RowNumber,0].ToString()+", "+
						textBox1.Text +");";
			
					OleDbCommand Commandsql = new OleDbCommand(STRSQL,oleDbConnection1);
					Commandsql.ExecuteNonQuery();
				}
				catch(Exception exc){MessageBox.Show(STRSQL+"\n\n"+exc.ToString());}
			}
			try
			{
				oleDbDataAdapter1.SelectCommand.CommandText="SELECT Produit.RefProduit, Produit.LibelleProduit, Produit.TypeProduit "+
					"FROM ((Menu INNER JOIN"+
					" MenuProduit ON Menu.RefMenu = MenuProduit.RefMenu) INNER JOIN"+
					" Produit ON MenuProduit.NumProduit = Produit.RefProduit) where Menu.RefMenu =" +textBox1.Text;
				dsmenusProduits1.Clear();
				oleDbDataAdapter1.Fill(dsmenusProduits1);
				listBox1.Refresh();}
			
			catch(Exception Exc){;;}
 
		}

		private void AddModifMenu_Load(object sender, System.EventArgs e)
		{
			oleDbDataAdapter4.Fill(dsProdFamilies1);
			comboBox1.Refresh();
			oleDbDataAdapter3.Fill(dsproduitsreso1);
			dataGrid2.Refresh();
		}
		private void FilterProduits(string Col,string valeur)
		{

			string STRSQL ="Select RefProduit AS [Référence Produit], LibelleProduit AS [Nom Produit], "+
				" TypeProduit AS [Famille Produit]"+
				" from Produit Where "+ Col.ToString() +" Like '"+valeur+"%'";
			try
			{
				if(oleDbDataAdapter3.SelectCommand.Connection.State!=ConnectionState.Open)
					oleDbDataAdapter3.SelectCommand.Connection.Open();
				dsproduitsreso1.Clear();
				oleDbDataAdapter3.SelectCommand.CommandText= STRSQL;
				oleDbDataAdapter3.Fill(dsproduitsreso1);
				dataGrid2.Refresh();
				
			}
			catch(Exception ec){;}

		}
		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (checkBox1.Checked)
				FilterProduits("TypeProduit",comboBox1.Text);
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (checkBox1.Checked==false)
				FilterProduits("TypeProduit","");
		}
	}
}
