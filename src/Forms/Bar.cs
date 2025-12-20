using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Transacts
{
	/// <summary>
	/// Summary description for Bar.
	/// </summary>
	public class Bar : System.Windows.Forms.Form
	{
		private Transacts.dsprodsBAr dsprodsBAr1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Bar()
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
			this.dsprodsBAr1 = new Transacts.dsprodsBAr();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dsprodsBAr1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// dsprodsBAr1
			// 
			this.dsprodsBAr1.DataSetName = "dsprodsBAr";
			this.dsprodsBAr1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsprodsBAr1.Namespace = "http://www.tempuri.org/dsprodsBAr.xsd";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dsprodsBAr1.Produit;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 8);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(328, 296);
			this.dataGrid1.TabIndex = 0;
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// Bar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(688, 550);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.dataGrid1});
			this.Name = "Bar";
			this.Text = "Bar";
			this.Load += new System.EventHandler(this.Bar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsprodsBAr1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void oleDbDataAdapter1_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
		{

		}

		private void Bar_Load(object sender, System.EventArgs e)
		{
			

		}
	}
}
