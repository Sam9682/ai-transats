using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using Graphism;

namespace Transacts

{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>


	public partial class TransatPrincipal : Form
	{
		#region UI Controls
		private Button btnLocation;
		private Panel PanelTransat;
		private Button btnReservation;
		private Button btnReturn;
		private Button btnReturnLocation;
		private CheckBox chkLockLocation;
		private Button btnCloseLocation;
		private Button btnNewLocation;
		private Button btnReturnReservation;
		private CheckBox chkLockReservation;
		private Button btnDeleteReservation;
		private Button btnModifyReservation;
		private Button btnNewReservation;
		private GroupBox grpLocation;
		private GroupBox grpReservation;
		private PictureBox ZoneTransats;
		private ListBox lstSelection;
		private ImageList imgButtons;
		private Button btnAddOption;
		private Label lblSelectedTransats;
		private IContainer components;
		private OleDbDataAdapter oleDbDataAdapter1;
		private OleDbCommand oleDbSelectCommand1;
		private OleDbCommand oleDbInsertCommand1;
		private OleDbCommand oleDbUpdateCommand1;
		private OleDbCommand oleDbDeleteCommand1;
		private OleDbConnection oleDbConnection1;
		private dsReservTransats dsReservTransats1;
		private DataGridView dataGridReservations;
		private Button btnDeleteTransat;
		private Button btnSearchTransat;
		#endregion

		#region Private Fields
		private readonly List<Transat> transats = new List<Transat>();
		private readonly Dictionary<int, bool> selectedItems = new Dictionary<int, bool>();
		private const int MaxTransats = 300;
		private readonly string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=ZenithPlage.mdb";
		private OleDbConnection connection;
		private int transatCount;
		private Point lastClickPosition;
		#endregion
		public TransatPrincipal()
		{
			InitializeComponent();
			InitializeTransats();
			InitializeConnection();
		}

		private void InitializeTransats()
		{
			for (int i = 0; i < MaxTransats; i++)
			{
				transats.Add(new Transat());
				selectedItems[i] = false;
			}
		}

		private void InitializeConnection()
		{
			connection = new OleDbConnection(connectionString);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				components?.Dispose();
				connection?.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TransatPrincipal));
			this.button1 = new System.Windows.Forms.Button();
			this.PanelTransat = new System.Windows.Forms.Panel();
			this.ZoneTransats = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dsReservTransats1 = new Transacts.dsReservTransats();
			this.ListeSelection = new System.Windows.Forms.ListBox();
			this.GrpLocation = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.GrpReservation = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.ImgButtons = new System.Windows.Forms.ImageList(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.PanelTransat.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsReservTransats1)).BeginInit();
			this.GrpLocation.SuspendLayout();
			this.GrpReservation.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button1.Location = new System.Drawing.Point(8, 472);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Location";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// PanelTransat
			// 
			this.PanelTransat.AutoScroll = true;
			this.PanelTransat.BackColor = System.Drawing.Color.White;
			this.PanelTransat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelTransat.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.ZoneTransats});
			this.PanelTransat.Location = new System.Drawing.Point(8, 32);
			this.PanelTransat.Name = "PanelTransat";
			this.PanelTransat.Size = new System.Drawing.Size(448, 432);
			this.PanelTransat.TabIndex = 3;
			this.PanelTransat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTransat_MouseUp);
			this.PanelTransat.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTransat_Paint);
			// 
			// ZoneTransats
			// 
			this.ZoneTransats.BackColor = System.Drawing.SystemColors.HighlightText;
			this.ZoneTransats.Location = new System.Drawing.Point(8, 8);
			this.ZoneTransats.Name = "ZoneTransats";
			this.ZoneTransats.Size = new System.Drawing.Size(432, 416);
			this.ZoneTransats.TabIndex = 0;
			this.ZoneTransats.TabStop = false;
			this.ZoneTransats.Click += new System.EventHandler(this.ZoneTransats_Click);
			this.ZoneTransats.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ZoneTransats_MouseUp);
			this.ZoneTransats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZoneTransats_MouseDown);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button2.Location = new System.Drawing.Point(208, 472);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 32);
			this.button2.TabIndex = 4;
			this.button2.Text = "R�servation";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button3.Location = new System.Drawing.Point(432, 472);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 32);
			this.button3.TabIndex = 5;
			this.button3.Text = "Retour";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGrid1.CaptionBackColor = System.Drawing.Color.Beige;
			this.dataGrid1.CaptionFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.CaptionForeColor = System.Drawing.Color.Black;
			this.dataGrid1.CaptionText = "Liste des R�servations";
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dsReservTransats1.ReservTransat;
			this.dataGrid1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(464, 32);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(256, 200);
			this.dataGrid1.TabIndex = 0;
			// 
			// dsReservTransats1
			// 
			this.dsReservTransats1.DataSetName = "dsReservTransats";
			this.dsReservTransats1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsReservTransats1.Namespace = "http://www.tempuri.org/dsReservTransats.xsd";
			// 
			// ListeSelection
			// 
			this.ListeSelection.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.ListeSelection.ItemHeight = 18;
			this.ListeSelection.Location = new System.Drawing.Point(464, 288);
			this.ListeSelection.Name = "ListeSelection";
			this.ListeSelection.Size = new System.Drawing.Size(232, 112);
			this.ListeSelection.Sorted = true;
			this.ListeSelection.TabIndex = 16;
			// 
			// GrpLocation
			// 
			this.GrpLocation.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.button5,
																					  this.button7,
																					  this.checkBox1,
																					  this.button6,
																					  this.button4});
			this.GrpLocation.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.GrpLocation.Location = new System.Drawing.Point(8, 472);
			this.GrpLocation.Name = "GrpLocation";
			this.GrpLocation.Size = new System.Drawing.Size(664, 104);
			this.GrpLocation.TabIndex = 8;
			this.GrpLocation.TabStop = false;
			this.GrpLocation.Text = "Location";
			this.GrpLocation.Visible = false;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(168, 24);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(152, 48);
			this.button5.TabIndex = 12;
			this.button5.Text = "Ajouter Option";
			this.button5.Click += new System.EventHandler(this.button5_Click_2);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.ImageIndex = 0;
			this.button7.Location = new System.Drawing.Point(488, 24);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(136, 48);
			this.button7.TabIndex = 10;
			this.button7.Text = "Retour";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(592, 80);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(56, 16);
			this.checkBox1.TabIndex = 9;
			this.checkBox1.Text = "Lock";
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.ImageIndex = 3;
			this.button6.Location = new System.Drawing.Point(328, 24);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(152, 48);
			this.button6.TabIndex = 8;
			this.button6.Text = "Cloturer Location";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.ImageIndex = 2;
			this.button4.Location = new System.Drawing.Point(8, 24);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(152, 48);
			this.button4.TabIndex = 6;
			this.button4.Text = "Nouvelle Location";
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// GrpReservation
			// 
			this.GrpReservation.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.checkBox2,
																						 this.button9,
																						 this.button10,
																						 this.button11,
																						 this.button8});
			this.GrpReservation.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.GrpReservation.Location = new System.Drawing.Point(8, 472);
			this.GrpReservation.Name = "GrpReservation";
			this.GrpReservation.Size = new System.Drawing.Size(664, 104);
			this.GrpReservation.TabIndex = 9;
			this.GrpReservation.TabStop = false;
			this.GrpReservation.Text = "R�servation";
			this.GrpReservation.Visible = false;
			// 
			// checkBox2
			// 
			this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.checkBox2.ImageIndex = 0;
			this.checkBox2.Location = new System.Drawing.Point(600, 80);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(56, 16);
			this.checkBox2.TabIndex = 14;
			this.checkBox2.Text = "Lock";
			this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.ImageIndex = 3;
			this.button9.Location = new System.Drawing.Point(328, 24);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(152, 48);
			this.button9.TabIndex = 13;
			this.button9.Text = "Supprimer R�servation";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button10.ImageIndex = 1;
			this.button10.Location = new System.Drawing.Point(168, 24);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(152, 48);
			this.button10.TabIndex = 12;
			this.button10.Text = "Modifier R�servation";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button11.ImageIndex = 2;
			this.button11.Location = new System.Drawing.Point(8, 24);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(152, 48);
			this.button11.TabIndex = 11;
			this.button11.Text = "Nouvelle R�servation";
			this.button11.Click += new System.EventHandler(this.button11_Click_1);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.ImageIndex = 0;
			this.button8.Location = new System.Drawing.Point(488, 24);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(136, 48);
			this.button8.TabIndex = 15;
			this.button8.Text = "Retour";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// ImgButtons
			// 
			this.ImgButtons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ImgButtons.ImageSize = new System.Drawing.Size(60, 60);
			this.ImgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgButtons.ImageStream")));
			this.ImgButtons.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label4.Location = new System.Drawing.Point(464, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(184, 24);
			this.label4.TabIndex = 17;
			this.label4.Text = "Transat(s) S�lectionn�(s)";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "ReservTransat", new System.Data.Common.DataColumnMapping[] {
																																																						 new System.Data.Common.DataColumnMapping("Num�ro Transat", "Num�ro Transat"),
																																																						 new System.Data.Common.DataColumnMapping("Identificateur Client", "Identificateur Client"),
																																																						 new System.Data.Common.DataColumnMapping("Date R�servation", "Date R�servation")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM ReservTransat WHERE (NumReservation = ?) AND (DateReservation = ? OR " +
				"? IS NULL AND DateReservation IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumReservation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "NumReservation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DateReservation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date R�servation", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DateReservation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date R�servation", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO ReservTransat(NumTransat, NumClient, DateReservation, NumReservation)" +
				" VALUES (?, ?, ?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumTransat", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Num�ro Transat", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Identificateur Client", System.Data.DataRowVersion.Current, null));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DateReservation", System.Data.OleDb.OleDbType.DBDate, 0, "Date R�servation"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumReservation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "NumReservation", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT NumTransat AS [Num�ro Transat], NumClient AS [Identificateur Client], Date" +
				"Reservation AS [Date R�servation], NumReservation FROM ReservTransat";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE ReservTransat SET NumTransat = ?, NumClient = ?, DateReservation = ?, NumR" +
				"eservation = ? WHERE (NumReservation = ?) AND (DateReservation = ? OR ? IS NULL " +
				"AND DateReservation IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumTransat", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Num�ro Transat", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumClient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "Identificateur Client", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("DateReservation", System.Data.OleDb.OleDbType.DBDate, 0, "Date R�servation"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumReservation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "NumReservation", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumReservation", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(10)), ((System.Byte)(0)), "NumReservation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DateReservation", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date R�servation", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_DateReservation1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Date R�servation", System.Data.DataRowVersion.Original, null));
			// 
			// button12
			// 
			this.button12.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button12.ImageIndex = 0;
			this.button12.Location = new System.Drawing.Point(464, 408);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(112, 48);
			this.button12.TabIndex = 16;
			this.button12.Text = "Supprimer Transat";
			// 
			// button13
			// 
			this.button13.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button13.ImageIndex = 0;
			this.button13.Location = new System.Drawing.Point(584, 408);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(112, 48);
			this.button13.TabIndex = 18;
			this.button13.Text = "Rechercher Transat";
			// 
			// TransatPrincipal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(734, 587);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button13,
																		  this.label4,
																		  this.GrpReservation,
																		  this.GrpLocation,
																		  this.button3,
																		  this.button2,
																		  this.PanelTransat,
																		  this.button1,
																		  this.ListeSelection,
																		  this.dataGrid1,
																		  this.button12});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "TransatPrincipal";
			this.Text = "Gestion Des Transats";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.TransatPrincipal_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Activated += new System.EventHandler(this.TransatPrincipal_Activated);
			this.PanelTransat.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsReservTransats1)).EndInit();
			this.GrpLocation.ResumeLayout(false);
			this.GrpReservation.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		
		private void button1_Click(object sender, System.EventArgs e)
		{
			GrpLocation.Visible=true;
			GrpReservation.Visible=false;
		}
		private void B_Click(object sender, System.EventArgs e)
		{
						
		}
		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
		
		}
		int[] selItems= new int[300];
		public void AfficherTransats()
		{
			int maxx=1,maxy=1,i;
			for(i=0; i < nbtransats; i++)
			{
				if(T[i].GetPosX() > maxx) maxx=T[i].GetPosX();
				if(T[i].GetPosY() > maxy) maxy=T[i].GetPosY();
			}
			Bitmap Bmp =new  Bitmap(42*(maxx)+50, 70*(maxy)+150);
			Graphics g=Graphics.FromImage(Bmp);
			g.Clear(Color.White);
			Class1 G =new Graphism.Class1();
			
			G.BackGround(g,Color.Beige,0,0,42*(maxx)+50, 70*(maxy)+150);
			for(i=0; i < nbtransats; i++)
			{
				ZoneTransats.Size=new Size(42*(maxx), 70*(maxy)+52);
				Color C= Color.Green;
				if(this.T[i].GetEtatCourant() ==0) C=Color.Green;
				if(T[i].GetEtatCourant() ==1) C=Color.GreenYellow;
				if(T[i].GetEtatCourant() ==2) C=Color.Red;
				if (selItems[i]==1)
					G.SkyScraper(g,42*(T[i].GetPosX()-1),70*(T[i].GetPosY()-1),30,45,3,3,
						Color.FromArgb(255-C.R,255-C.G,255-C.B),T[i].GetNumTransat(),17);
				else
					G.SkyScraper(g,42*(T[i].GetPosX()-1),70*(T[i].GetPosY()-1),30,45,3,3,
						C,T[i].GetNumTransat(),17);
			}
			ZoneTransats.Image=Bmp;

		}
		int nbtransats ;
		string strconn="Provider=Microsoft.Jet.OLEDB.4.0;Data source=ZenithPlage.mdb";
		OleDbConnection conn;
		string STRSQL;

		private void Form1_Load(object sender, System.EventArgs e)
		{	
			conn =new OleDbConnection(strconn);
			
			try
			{
				conn.Open();
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.ToString());
			}

			
			ChargerDonnesTransats();
			oleDbDataAdapter1.Fill(dsReservTransats1);
			dataGrid1.Refresh();
		
		}
		private void ChargerDonnesTransats()
		{
			try
			{
				STRSQL= "Select * from Transat" ;
				OleDbCommand  CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteScalar();
				DataView DV;
				DataSet DS=new DataSet();
				OleDbDataAdapter DA= new OleDbDataAdapter();
				DA.SelectCommand= CommandSql;
				DA.Fill(DS,"Transat");
				DV=new DataView(DS.Tables[0]);
				nbtransats=DV.Table.Rows.Count;
				for(int i=0;i<nbtransats;i++)
				{
					T[i].SetNumTransat(System.Convert.ToInt32(DV.Table.Rows[i].ItemArray[0]));
					T[i].SetEtatCourant(System.Convert.ToInt32(DV.Table.Rows[i].ItemArray[3]));
					T[i].SetPosX(System.Convert.ToInt32(DV.Table.Rows[i].ItemArray[1]));
					T[i].SetPosY(System.Convert.ToInt32(DV.Table.Rows[i].ItemArray[2]));
				}
			}
			catch(Exception Ex){;;}
			AfficherTransats();
		}
		private void PanelTransat_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void PanelTransat_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
		
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button5_Click(object sender, System.EventArgs e)
		{

		}

		private void button11_Click(object sender, System.EventArgs e)
		{
			
		
		}

		private void button11_Click_1(object sender, System.EventArgs e)
		{
			string Ch;
			int[] index_transat = new int[300];
			int j=0;
			for(int i=0;i<ListeSelection.Items.Count;i++)
			{
				Ch=ListeSelection.Items[i].ToString();
				
				index_transat[j]=Convert.ToInt16(Ch.Substring(8,Ch.Length-8));
				j++;
			}
			NouvelleReservation NewRes = new NouvelleReservation();
			NewRes.ShowDialog();
			OleDbCommand CommandSql;
			if(NewRes.reserver ==true)
			{
				try 
				{
					if(oleDbDataAdapter1.SelectCommand.Connection.State!=ConnectionState.Open )
						oleDbDataAdapter1.SelectCommand.Connection.Open();
				
					STRSQL = "insert into ReservTransat (NumTransat, NumClient,DateReservation) values ("+
						ListeSelection.Items[0].ToString().Substring(8,ListeSelection.Items[0].ToString().Length-8)+", "+
						NewRes.NumClient+", "+
						"'"+System.Convert.ToDateTime(NewRes.DateRes)+"')";
					CommandSql = new OleDbCommand(STRSQL, oleDbDataAdapter1.SelectCommand.Connection);
					CommandSql.ExecuteNonQuery();
					dsReservTransats1.Clear();
					oleDbDataAdapter1.Fill(dsReservTransats1);
					dataGrid1.Refresh();
				}
			
				catch(Exception exc ){MessageBox.Show(STRSQL+"\n\n"+exc.ToString());}
			}

		}

		private void button10_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button4_Click_1(object sender, System.EventArgs e)
		{string Ch;
			int index_transat;
			NouvelleLocation F =new NouvelleLocation();
			F.ShowDialog();
			for(int i=0; i<ListeSelection.Items.Count; i++)
			{
				Ch=ListeSelection.Items[i].ToString(); 
				index_transat=Convert.ToInt16(Ch.Substring(8,Ch.Length-8));
				STRSQL = "Update Transat set EtatCourant = 2 where numTransat = "+index_transat.ToString();
				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteNonQuery();
				conn.Close();
				for(int tr=0;tr<nbtransats;tr++)
					if(T[tr].GetNumTransat()==index_transat)
						T[tr].SetEtatCourant(0);
			}
			ChargerDonnesTransats();
			AfficherTransats();
		}

		private void button5_Click_1(object sender, System.EventArgs e)
		{			

		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			GrpReservation.Visible=true;
			GrpLocation.Visible=false;
		}

		private void Locataire(int NumTransat)
		{STRSQL ="select * from LocationTransats where NumTransat = "+ NumTransat.ToString();
			
			try
			{
				OleDbCommand  CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteScalar();
				DataView DV;
				DataSet DS=new DataSet();
				OleDbDataAdapter DA= new OleDbDataAdapter();
				DA.SelectCommand= CommandSql;
				DA.Fill(DS,"LocationTransat");
				DV=new DataView(DS.Tables[0]);
						
			}
			catch(Exception ex){
				MessageBox.Show(STRSQL+"\n"+ex.ToString());}
			
		}

		private void ZoneTransats_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{int transat=0;
		 int Nouv_Transat=2;
		 Boolean Existe=false;
			int position_x=(e.X/42);
			int position_y=(e.Y/70);
			for (int t=0; t<nbtransats; t++)
				if (T[t].GetPosX()==position_x+1 && T[t].GetPosY()==position_y+1)
				{
					transat=t;
					Existe = true;
				}
			/*Selection du transat*/
			try
			{
				for(int i=0;i<nbtransats;i++)
					selItems[i]=0;
				selItems[transat]=1;
			}
			catch (Exception ex)
			
			{MessageBox.Show("Aucun Transat Selectionn�","Gestion de Transats");}
			if (transat >=0)
			{
				
				if(checkBox1.Checked==false && checkBox2.Checked==false)
					ListeSelection.Items.Clear();
				if (ListeSelection.Items.IndexOf("Transat "+T[transat].GetNumTransat().ToString())<0)
					ListeSelection.Items.Add("Transat "+T[transat].GetNumTransat().ToString());
				switch(T[transat].GetEtatCourant())
				{
					case 0 :break;
					case 1 :;
					{/* Charger les informations sur la r�servation*/
						
						break;
					}
					
					{/* Charger les informations sur la location*/
					Locataire(T[transat].GetNumTransat());
						break;
					}
						
						

				}
			}

			if (posXT1!= position_x || posYT1!= position_y )
			{
				for(int t=0; t<nbtransats; t++)
				{
					if(T[t].GetPosX()==posXT1+1 && T[t].GetPosY()==posYT1+1 )
					{
						Nouv_Transat=t;
					}
				}
				if(Existe)
				{
					PermuterPosTransats(ref T[transat], ref T[Nouv_Transat]);
				}
				else
				{
					T[Nouv_Transat].SetPosX(position_x+1);
					T[Nouv_Transat].SetPosY(position_y+1);
					STRSQL="Update transat set PosX = "+
						(position_x+1).ToString()+", PosY = "+
						(position_y+1).ToString()+
						" Where NumTransat = "+T[Nouv_Transat].GetNumTransat().ToString();
					try
					{
						OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
						CommandSql.ExecuteNonQuery();
					}
					catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
				}
			}
			AfficherTransats();
			ZoneTransats.Cursor=Cursors.Default;
		}

		private void ZoneTransats_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button6_Click(object sender, System.EventArgs e)
		{string Ch;
		 int index_transat;
			for(int i=0; i<ListeSelection.Items.Count; i++)
			{
				Ch=ListeSelection.Items[i].ToString(); 
				index_transat=Convert.ToInt16(Ch.Substring(8,Ch.Length-8));
				STRSQL = "Update Transat set EtatCourant = 0 where numTransat = "+index_transat.ToString();
				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteNonQuery();
				for(int tr=0;tr<nbtransats;tr++)
					if(T[tr].GetNumTransat()==index_transat)
						T[tr].SetEtatCourant(0);
			}
			ListeSelection.Items.Clear();
			AfficherTransats();
			
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			GrpLocation.Visible=false;
		}

		private void button8_Click(object sender, System.EventArgs e)
		{
			GrpReservation.Visible=false;
			checkBox2.Checked=false;
		}

		private void button9_Click(object sender, System.EventArgs e)
		{string Ch;
		 int index_transat;
			if (MessageBox.Show("Confirmation de demande de suppression de r�servation ",
				"R�servation Transats",MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				for(int i=0; i<ListeSelection.Items.Count; i++)
				{
					Ch=ListeSelection.Items[i].ToString(); 
					index_transat=Convert.ToInt16(Ch.Substring(8,Ch.Length-8));
					STRSQL = "Update Transat set EtatCourant = 0 where numTransat = "+index_transat.ToString();
					OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
					CommandSql.ExecuteNonQuery();
					for(int tr=0;tr<nbtransats;tr++)
						if(T[tr].GetNumTransat()==index_transat)
							T[tr].SetEtatCourant(0);
				}
				ListeSelection.Items.Clear();
				AfficherTransats();			
			}	
		}

		private void button5_Click_2(object sender, System.EventArgs e)
		{
			AjouterOption Aopt = new AjouterOption();
			Aopt.ShowDialog();
		}

		private void TransatPrincipal_Activated(object sender, System.EventArgs e)
		{
//			if(conn.State!=ConnectionState.Open)
//				conn.Open();
//			for(int i=0;i<nbtransats;i++)
//			{
//				STRSQL = "Update Transat set EtatCourant = "+T[i].GetEtatCourant().ToString()+" where numTransat = " + (i+1).ToString();
//				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
//				CommandSql.ExecuteNonQuery();	
//			}
//			ChargerDonnesTransats();
//			conn.Close();
		}
		int posXT1,posYT1;
		private void creerTransat(int PX, int PY, int NumTransat)
		{
			
			STRSQL="Insert into transat (NumTransat,PosX,PosY,EtatCourant) values ("+
				NumTransat.ToString()+","+
				PX.ToString()+","+
				PY.ToString()+","+ 
				"0)";
			try
			{
				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteNonQuery();
			}
			catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
		}
		private void ZoneTransats_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			bool Existe=false;
			 ZoneTransats.Cursor=Cursors.Hand;
			 posXT1=e.X/42;
			 posYT1=e.Y/70;
			 int position_x=(e.X/42);
			 int position_y=(e.Y/70);
			 for (int t=0; t<nbtransats; t++)
				 if (T[t].GetPosX()==position_x+1 && T[t].GetPosY()==position_y+1)
					 Existe = true;
			 if (Existe==false)
			 {
					 AjouTable AjT= new AjouTable();
				 if(MessageBox.Show("Creer un transat ici ?",
					 "Gestion de la plage",MessageBoxButtons.YesNo)==DialogResult.Yes)
				 {
						 AjT.ShowDialog();
					 creerTransat(position_x+1,position_y+1,AjT.numeroTable);}

			 }

		}
		private void PermuterPosTransats(ref Transat T1, ref Transat T2)
		{Transat Temp=new Transat();

			Temp.SetPosX(T1.GetPosX());
			Temp.SetPosY(T1.GetPosY());

			T1.SetPosX(T2.GetPosX());
			T1.SetPosY(T2.GetPosY());

			T2.SetPosX(Temp.GetPosX());
			T2.SetPosY(Temp.GetPosY());
			STRSQL="Update Transat set PosX = "+
				(T1.GetPosX()).ToString()+", PosY = "+
				(T1.GetPosY()).ToString()+
				" Where NumTransat = "+T1.GetNumTransat().ToString();
				
				
				
			try
			{
				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteNonQuery();
			}
			catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
			STRSQL="Update Transat set PosX = "+
				(T2.GetPosX()).ToString()+", PosY = "+
				(T2.GetPosY()).ToString()+
				" Where NumTransat = "+T2.GetNumTransat().ToString();
				
				
				
				
			try
			{
				OleDbCommand CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteNonQuery();
			}
			catch(Exception Ex){MessageBox.Show(STRSQL+Ex.ToString());}
			ChargerDonnesTransats();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Generale Gen = new Generale("");
			this.Hide();
			Gen.Show();
		}

		private void TransatPrincipal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}


	}
}
