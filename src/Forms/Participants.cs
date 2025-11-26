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
	/// Summary description for Participants.
	/// </summary>
	public class Participants : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.OleDb.OleDbDataAdapter oleDataAdapterClientsCours;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Transacts.dsClientsCours dsClientsCours1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
		private Transacts.dsClientsPaticipants dsClientsPaticipants1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Participants()
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dsClientsCours1 = new Transacts.dsClientsCours();
			this.oleDataAdapterClientsCours = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dsClientsPaticipants1 = new Transacts.dsClientsPaticipants();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsClientsCours1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsClientsPaticipants1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.AntiqueWhite;
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Black;
			this.dataGrid1.CaptionText = "Liste des participants";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dsClientsCours1.Client;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 16);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.PreferredColumnWidth = 150;
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(544, 264);
			this.dataGrid1.TabIndex = 0;
			// 
			// dsClientsCours1
			// 
			this.dsClientsCours1.DataSetName = "dsClientsCours";
			this.dsClientsCours1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsClientsCours1.Namespace = "http://www.tempuri.org/dsClientsCours.xsd";
			// 
			// oleDataAdapterClientsCours
			// 
			this.oleDataAdapterClientsCours.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDataAdapterClientsCours.InsertCommand = this.oleDbInsertCommand1;
			this.oleDataAdapterClientsCours.SelectCommand = this.oleDbSelectCommand1;
			this.oleDataAdapterClientsCours.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																												 new System.Data.Common.DataTableMapping("Table", "Client", new System.Data.Common.DataColumnMapping[] {
																																																						   new System.Data.Common.DataColumnMapping("Code Client", "Code Client"),
																																																						   new System.Data.Common.DataColumnMapping("Nom Client", "Nom Client"),
																																																						   new System.Data.Common.DataColumnMapping("Prénom Client", "Prénom Client"),
																																																						   new System.Data.Common.DataColumnMapping("Adresse", "Adresse"),
																																																						   new System.Data.Common.DataColumnMapping("e-mail", "e-mail"),
																																																						   new System.Data.Common.DataColumnMapping("Tel/Phone", "Tel/Phone")})});
			this.oleDataAdapterClientsCours.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = @"DELETE FROM Client WHERE (NumClient = ?) AND (AdresseClient = ? OR ? IS NULL AND AdresseClient IS NULL) AND (MailClient = ? OR ? IS NULL AND MailClient IS NULL) AND (NomClient = ? OR ? IS NULL AND NomClient IS NULL) AND (PrenomClient = ? OR ? IS NULL AND PrenomClient IS NULL) AND (TelClient = ? OR ? IS NULL AND TelClient IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_AdresseClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "e-mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_MailClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "e-mail", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_NomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prénom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_PrenomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prénom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel/Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Delete2_Original_TelClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel/Phone", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Client(NumClient, NomClient, PrenomClient, AdresseClient, MailClient," +
				" TelClient) VALUES (?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insert2_NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insert2_NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insert2_PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Prénom Client"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insert2_AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Adresse"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insert2_MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, "e-mail"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Insert2_TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Tel/Phone"));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = @"SELECT Client.NumClient AS [Code Client], Client.NomClient AS [Nom Client], Client.PrenomClient AS [Prénom Client], Client.AdresseClient AS Adresse, Client.MailClient AS [e-mail], Client.TelClient AS [Tel/Phone] FROM (CoursClient INNER JOIN Client ON CoursClient.NumClient = Client.NumClient)";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = @"UPDATE Client SET NumClient = ?, NomClient = ?, PrenomClient = ?, AdresseClient = ?, MailClient = ?, TelClient = ? WHERE (NumClient = ?) AND (AdresseClient = ? OR ? IS NULL AND AdresseClient IS NULL) AND (MailClient = ? OR ? IS NULL AND MailClient IS NULL) AND (NomClient = ? OR ? IS NULL AND NomClient IS NULL) AND (PrenomClient = ? OR ? IS NULL AND PrenomClient IS NULL) AND (TelClient = ? OR ? IS NULL AND TelClient IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Nom Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Prénom Client"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Adresse"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, "e-mail"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, "Tel/Phone"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Code Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_AdresseClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Adresse", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "e-mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_MailClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "e-mail", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_NomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Nom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prénom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_PrenomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Prénom Client", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel/Phone", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Update2_Original_TelClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Tel/Phone", System.Data.DataRowVersion.Original, null));
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(152, 288);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 56);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ajouter Client";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(8, 288);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 56);
			this.button2.TabIndex = 2;
			this.button2.Text = "Annuler Participation";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// dsClientsPaticipants1
			// 
			this.dsClientsPaticipants1.DataSetName = "dsClientsPaticipants";
			this.dsClientsPaticipants1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsClientsPaticipants1.Namespace = "http://www.tempuri.org/dsClientsPaticipants.xsd";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand2;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand2;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Client", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("NumClient", "NumClient"),
																																																				  new System.Data.Common.DataColumnMapping("NomClient", "NomClient"),
																																																				  new System.Data.Common.DataColumnMapping("PrenomClient", "PrenomClient"),
																																																				  new System.Data.Common.DataColumnMapping("AdresseClient", "AdresseClient"),
																																																				  new System.Data.Common.DataColumnMapping("TelClient", "TelClient"),
																																																				  new System.Data.Common.DataColumnMapping("MailClient", "MailClient"),
																																																				  new System.Data.Common.DataColumnMapping("s_GUID", "s_GUID")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand2;
			// 
			// oleDbDeleteCommand2
			// 
			this.oleDbDeleteCommand2.CommandText = @"DELETE FROM Client WHERE (NumClient = ?) AND (AdresseClient = ? OR ? IS NULL AND AdresseClient IS NULL) AND (MailClient = ? OR ? IS NULL AND MailClient IS NULL) AND (NomClient = ? OR ? IS NULL AND NomClient IS NULL) AND (PrenomClient = ? OR ? IS NULL AND PrenomClient IS NULL) AND (TelClient = ? OR ? IS NULL AND TelClient IS NULL) AND (s_GUID = ? OR ? IS NULL AND s_GUID IS NULL)";
			this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "NumClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AdresseClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AdresseClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AdresseClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MailClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_MailClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MailClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NomClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NomClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrenomClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrenomClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TelClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TelClient", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_s_GUID", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "s_GUID", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_s_GUID1", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "s_GUID", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbInsertCommand2
			// 
			this.oleDbInsertCommand2.CommandText = "INSERT INTO Client(AdresseClient, MailClient, NomClient, NumClient, PrenomClient," +
				" s_GUID, TelClient) VALUES (?, ?, ?, ?, ?, ?, ?)";
			this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, "AdresseClient"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, "MailClient"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "NomClient"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "NumClient", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "PrenomClient"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("s_GUID", System.Data.OleDb.OleDbType.Guid, 0, "s_GUID"));
			this.oleDbInsertCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, "TelClient"));
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT AdresseClient, MailClient, NomClient, NumClient, PrenomClient, s_GUID, Tel" +
				"Client FROM Client";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand2
			// 
			this.oleDbUpdateCommand2.CommandText = @"UPDATE Client SET AdresseClient = ?, MailClient = ?, NomClient = ?, NumClient = ?, PrenomClient = ?, s_GUID = ?, TelClient = ? WHERE (NumClient = ?) AND (AdresseClient = ? OR ? IS NULL AND AdresseClient IS NULL) AND (MailClient = ? OR ? IS NULL AND MailClient IS NULL) AND (NomClient = ? OR ? IS NULL AND NomClient IS NULL) AND (PrenomClient = ? OR ? IS NULL AND PrenomClient IS NULL) AND (TelClient = ? OR ? IS NULL AND TelClient IS NULL) AND (s_GUID = ? OR ? IS NULL AND s_GUID IS NULL)";
			this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, "AdresseClient"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, "MailClient"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "NomClient"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "NumClient", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, "PrenomClient"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("s_GUID", System.Data.OleDb.OleDbType.Guid, 0, "s_GUID"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, "TelClient"));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "NumClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AdresseClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AdresseClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_AdresseClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "AdresseClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_MailClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MailClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_MailClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "MailClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NomClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "NomClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrenomClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_PrenomClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "PrenomClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelClient", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TelClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_TelClient1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TelClient", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_s_GUID", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "s_GUID", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand2.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_s_GUID1", System.Data.OleDb.OleDbType.Guid, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "s_GUID", System.Data.DataRowVersion.Original, null));
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(312, 328);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 32);
			this.label1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(312, 368);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(240, 32);
			this.label2.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(304, 288);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 32);
			this.label3.TabIndex = 6;
			this.label3.Text = "Code Client";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(424, 288);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 27);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// Participants
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(9, 20);
			this.ClientSize = new System.Drawing.Size(560, 406);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBox1,
																		  this.label3,
																		  this.label2,
																		  this.label1,
																		  this.button2,
																		  this.button1,
																		  this.dataGrid1});
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Participants";
			this.Text = "Participants";
			this.Load += new System.EventHandler(this.Participants_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsClientsCours1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsClientsPaticipants1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		public string Numero;
		private void Participants_Load(object sender, System.EventArgs e)
		{
			DataSet DS =new DataSet(); 
			try
			{
				oleDbDataAdapter1.Fill(dsClientsPaticipants1);

			}
			catch(Exception exc){MessageBox.Show(exc.ToString());}
			try
			{
				oleDataAdapterClientsCours.SelectCommand.CommandText=
					"SELECT Client.NumClient AS [Code Client], Client.NomClient AS [Nom Client],"+
					" Client.PrenomClient AS [Prénom Client], Client.AdresseClient AS Adresse, "+
					" Client.MailClient AS [e-mail], Client.TelClient AS [Tel/Phone] "+
					" FROM (CoursClient INNER JOIN Client ON CoursClient.NumClient = Client.NumClient)	Where CoursClient.CodeCours="+Numero; 	
				oleDataAdapterClientsCours.Fill(dsClientsCours1);
				dataGrid1.Refresh();
			}
			catch(Exception exc){;}
		}
		public string NumCours;
		private void button1_Click(object sender, System.EventArgs e)
		{
			/*Vérfier que le client n'est pas déja un prticipant*/
			MessageBox.Show(dsClientsCours1.Tables[0].Rows.Count.ToString());
			for(int i=0;i<dsClientsCours1.Tables[0].Rows.Count;i++)
			if(textBox1.Text== dataGrid1[i,0].ToString())
				return;
			
				string STRSQL = "INSERT INTO CoursClient values ("+
					Numero+","+textBox1.Text +")";
				try
				{
					if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open )
						oleDbDataAdapter1.SelectCommand.Connection.Open();
					OleDbCommand CommSQL = new OleDbCommand (STRSQL,
						oleDbDataAdapter1.SelectCommand.Connection);
					CommSQL.ExecuteNonQuery();
				}
				catch(Exception exc) {MessageBox.Show(STRSQL+"\n"+exc.ToString());}
				oleDataAdapterClientsCours.SelectCommand.CommandText=
					"SELECT Client.NumClient AS [Code Client], Client.NomClient AS [Nom Client],"+
					" Client.PrenomClient AS [Prénom Client], Client.AdresseClient AS Adresse, "+
					" Client.MailClient AS [e-mail], Client.TelClient AS [Tel/Phone] "+
					" FROM (CoursClient INNER JOIN Client ON CoursClient.NumClient = Client.NumClient)	Where CoursClient.CodeCours="+Numero; 	
				oleDataAdapterClientsCours.Fill(dsClientsCours1);
				dataGrid1.Refresh();
			
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				System.Convert.ToInt32(textBox1.Text);
			}
			catch(Exception exc ) {textBox1.Text="";}
			string STRSQL ;
			if (textBox1.Text!="")
			{

				STRSQL = "select NomClient, PrenomClient From Client Where NumClient = "+textBox1.Text;
				OleDbDataAdapter DA = new OleDbDataAdapter(STRSQL,oleDbDataAdapter1.SelectCommand.Connection);
				DataSet DS = new DataSet();
				try
				{
					DA.Fill(DS);
					label1.Text="Nom : "+DS.Tables[0].Rows[0].ItemArray[0].ToString();
					label2.Text="Prénom : "+DS.Tables[0].Rows[0].ItemArray[1].ToString();
				}
				catch(Exception Exc){MessageBox.Show("Client inexistant","OXENCO");}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Annuler la participation du client N°"+
							dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString(),"OXENCO",MessageBoxButtons.YesNo)
						==DialogResult.No)
				return;
			string STRSQL = "DELETE FROM CoursClient WHERE NumClient ="+
				dataGrid1[dataGrid1.CurrentCell.RowNumber,0].ToString();
			try
			{
				if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open )
					oleDbDataAdapter1.SelectCommand.Connection.Open();
				OleDbCommand CommSQL = new OleDbCommand (STRSQL,
					oleDbDataAdapter1.SelectCommand.Connection);
				CommSQL.ExecuteNonQuery();
				oleDbDataAdapter1.SelectCommand.Connection.Close();
			}
			catch(Exception exc) {MessageBox.Show(STRSQL+"\n"+exc.ToString());}
			dsClientsCours1.Clear();
			oleDataAdapterClientsCours.Fill(dsClientsCours1);
			dataGrid1.Refresh();
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			Clavier C =new Clavier();
			C.ShowDialog(this);
		}
	}
}
