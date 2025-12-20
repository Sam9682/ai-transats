using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Drawing.Printing ;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Transacts
{
	/// <summary>
	/// Summary description for Ticket.
	/// </summary>
	public class Ticket : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Drawing.Printing.PrintDocument printDocument1;
		public int NumTable;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.RichTextBox DetailsTicket;
		public ListView Commande;
		public int NTable; 
		public Ticket(string TicketText)
		{double Somme=0;
			this.NumTable=NTable;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
				DetailsTicket.Text =TicketText;
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.DetailsTicket = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button1.Location = new System.Drawing.Point(120, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Annuler";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button2.Location = new System.Drawing.Point(8, 280);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 32);
			this.button2.TabIndex = 2;
			this.button2.Text = "Valider";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
			// 
			// DetailsTicket
			// 
			this.DetailsTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DetailsTicket.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.DetailsTicket.Location = new System.Drawing.Point(8, 8);
			this.DetailsTicket.Name = "DetailsTicket";
			this.DetailsTicket.ReadOnly = true;
			this.DetailsTicket.Size = new System.Drawing.Size(216, 264);
			this.DetailsTicket.TabIndex = 3;
			this.DetailsTicket.Text = "";
			// 
			// Ticket
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(232, 320);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.DetailsTicket,
																		  this.button2,
																		  this.button1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Ticket";
			this.Text = "Ticket";
			this.Load += new System.EventHandler(this.Ticket_Load);
			this.ResumeLayout(false);

		}
		#endregion

  

		private void button2_Click(object sender, System.EventArgs e)
		{
			printDocument1.Print();
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString(DetailsTicket.Text, 
				new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 5,5 );

		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Ticket_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
