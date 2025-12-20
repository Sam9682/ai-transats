using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Transacts
{
	/// <summary>
	/// Summary description for EcranReservation.
	/// </summary>
	public class EcranReservation : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EcranReservation()
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
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.monthCalendar1.Location = new System.Drawing.Point(8, 32);
			this.monthCalendar1.MaxSelectionCount = 1;
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(8, 288);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(168, 56);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label1.Location = new System.Drawing.Point(8, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 19);
			this.label1.TabIndex = 8;
			this.label1.Text = "Date de Réservation";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label2.Location = new System.Drawing.Point(16, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(242, 19);
			this.label2.TabIndex = 9;
			this.label2.Text = "Selectionner la date de réservation";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button1.Location = new System.Drawing.Point(184, 272);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 32);
			this.button1.TabIndex = 16;
			this.button1.Text = "Valider";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.button2.Location = new System.Drawing.Point(184, 312);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 32);
			this.button2.TabIndex = 17;
			this.button2.Text = "Annuler";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// EcranReservation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(274, 352);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.button1,
																		  this.label2,
																		  this.label1,
																		  this.textBox1,
																		  this.monthCalendar1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "EcranReservation";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Ecran Reservation";
			this.Load += new System.EventHandler(this.EcranReservation_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void monthCalendar1_DateChanged(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			
		}

		private void monthCalendar1_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
		textBox1.Text= "Date de réservation du " + e.Start.ToShortDateString().ToString() + " Au "+ 
			e.End.ToShortDateString().ToString();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{

		}
		
		public string datereserv;
		
		private void EcranReservation_Load(object sender, System.EventArgs e)
		{datereserv=monthCalendar1.SelectionStart.ToShortDateString();
			textBox1.Text= "Date de réservation " + monthCalendar1.SelectionStart.ToShortDateString().ToString();
			
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			
			this.Close();
			NouvelleReservation  NlleRes = new NouvelleReservation();
			NlleRes.ShowDialog();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}
	}
}
