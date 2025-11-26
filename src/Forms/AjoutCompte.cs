using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Transacts
{
	/// <summary>
	/// Summary description for AjoutCompte.
	/// </summary>
	public class AjoutCompte : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private int NumClient;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AjoutCompte(int NumClient)
		{
			//
			// Required for Windows Form Designer support
			//
			this.NumClient=NumClient;
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
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Compte crée le";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(128, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = ":";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.textBox1.Location = new System.Drawing.Point(136, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 26);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label3.Location = new System.Drawing.Point(8, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Numéro Compte";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(120, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 24);
			this.label4.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 24);
			this.label5.TabIndex = 5;
			this.label5.Text = "Code Client";
			// 
			// button39
			// 
			this.button39.BackColor = System.Drawing.Color.Cornsilk;
			this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button39.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button39.Location = new System.Drawing.Point(216, 120);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(72, 104);
			this.button39.TabIndex = 112;
			this.button39.Text = "0";
			this.button39.Click += new System.EventHandler(this.button39_Click);
			// 
			// button30
			// 
			this.button30.BackColor = System.Drawing.Color.Cornsilk;
			this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button30.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button30.Location = new System.Drawing.Point(160, 232);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(50, 50);
			this.button30.TabIndex = 111;
			this.button30.Text = "3";
			this.button30.Click += new System.EventHandler(this.button39_Click);
			// 
			// button31
			// 
			this.button31.BackColor = System.Drawing.Color.Cornsilk;
			this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button31.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button31.Location = new System.Drawing.Point(104, 232);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(50, 50);
			this.button31.TabIndex = 110;
			this.button31.Text = "2";
			this.button31.Click += new System.EventHandler(this.button39_Click);
			// 
			// button32
			// 
			this.button32.BackColor = System.Drawing.Color.Cornsilk;
			this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button32.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button32.Location = new System.Drawing.Point(48, 232);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(50, 50);
			this.button32.TabIndex = 109;
			this.button32.Text = "1";
			this.button32.Click += new System.EventHandler(this.button39_Click);
			// 
			// button33
			// 
			this.button33.BackColor = System.Drawing.Color.Cornsilk;
			this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button33.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button33.Location = new System.Drawing.Point(160, 176);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(50, 50);
			this.button33.TabIndex = 108;
			this.button33.Text = "6";
			this.button33.Click += new System.EventHandler(this.button39_Click);
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.Cornsilk;
			this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button34.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button34.Location = new System.Drawing.Point(104, 176);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(50, 50);
			this.button34.TabIndex = 107;
			this.button34.Text = "5";
			this.button34.Click += new System.EventHandler(this.button39_Click);
			// 
			// button35
			// 
			this.button35.BackColor = System.Drawing.Color.Cornsilk;
			this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button35.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button35.Location = new System.Drawing.Point(48, 176);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(50, 50);
			this.button35.TabIndex = 106;
			this.button35.Text = "4";
			this.button35.Click += new System.EventHandler(this.button39_Click);
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.Cornsilk;
			this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button36.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button36.Location = new System.Drawing.Point(160, 120);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(50, 50);
			this.button36.TabIndex = 105;
			this.button36.Text = "9";
			this.button36.Click += new System.EventHandler(this.button39_Click);
			// 
			// button37
			// 
			this.button37.BackColor = System.Drawing.Color.Cornsilk;
			this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button37.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button37.Location = new System.Drawing.Point(104, 120);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(50, 50);
			this.button37.TabIndex = 104;
			this.button37.Text = "8";
			this.button37.Click += new System.EventHandler(this.button39_Click);
			// 
			// button38
			// 
			this.button38.BackColor = System.Drawing.Color.Cornsilk;
			this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button38.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button38.Location = new System.Drawing.Point(48, 120);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(50, 50);
			this.button38.TabIndex = 103;
			this.button38.Text = "7";
			this.button38.Click += new System.EventHandler(this.button39_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Cornsilk;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(8, 296);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 40);
			this.button1.TabIndex = 113;
			this.button1.Text = "Annuler";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Cornsilk;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button2.Location = new System.Drawing.Point(168, 296);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 40);
			this.button2.TabIndex = 114;
			this.button2.Text = "Valider";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Cornsilk;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold);
			this.button3.Location = new System.Drawing.Point(216, 232);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(72, 50);
			this.button3.TabIndex = 115;
			this.button3.Text = "Eff";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// AjoutCompte
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 342);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button3,
																		  this.button2,
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
																		  this.button38,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.textBox1,
																		  this.label2,
																		  this.label1});
			this.Name = "AjoutCompte";
			this.Text = "AjoutCompte";
			this.Load += new System.EventHandler(this.AjoutCompte_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void button39_Click(object sender, System.EventArgs e)
		{
			textBox1.Text+=sender.ToString().Substring(sender.ToString().Length-1,1);
		}
		string strconn="Provider=Microsoft.Jet.OLEDB.4.0;Data source=ZenithPlage.mdb";
		OleDbConnection conn;
		string STRSQL;
		private void button2_Click(object sender, System.EventArgs e)
		{
			OleDbCommand CommandSql;
			conn =new OleDbConnection(strconn);
			
			try
			{
				conn.Open();
			}
			catch(Exception Ex){MessageBox.Show("");}
			
			try
			{
				STRSQL="Insert into CompteJournalier (NumCompteJournalier,RefClient,DateOuvertureCompte) "+ 
					"values ("+
					System.Convert.ToInt64(textBox1.Text)+","+
					System.Convert.ToInt64(label4.Text)+","+
					"'"+System.Convert.ToDateTime(label2.Text).ToString()+"'"+
					" )";
				CommandSql = new OleDbCommand(STRSQL,conn);
				CommandSql.ExecuteNonQuery();
			}
		
			catch(Exception Ex){MessageBox.Show(Ex.ToString());}
			this.Close();
		}

		private void AjoutCompte_Load(object sender, System.EventArgs e)
		{
			label4.Text=NumClient.ToString();
			label2.Text=DateTime.Now.ToString();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			textBox1.Text="";
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
