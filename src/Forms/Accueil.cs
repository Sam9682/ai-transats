using System.Runtime.CompilerServices;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Diagnostics;
namespace Transacts
{
	/// <summary>
	/// Summary description for Accueil.
	/// </summary>
	public class Accueil : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button40;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private Transacts.dsRoles dsRoles1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Accueil()
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dsRoles1 = new Transacts.dsRoles();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button40 = new System.Windows.Forms.Button();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.dsRoles1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.textBox1.Location = new System.Drawing.Point(184, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(192, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.textBox2.Location = new System.Drawing.Point(184, 80);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(192, 26);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "";
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.dsRoles1.Employe;
			this.comboBox1.DisplayMember = "Alias";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.comboBox1.Location = new System.Drawing.Point(184, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(192, 26);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dsRoles1
			// 
			this.dsRoles1.DataSetName = "dsRoles";
			this.dsRoles1.Locale = new System.Globalization.CultureInfo("fr-FR");
			this.dsRoles1.Namespace = "http://www.tempuri.org/dsRoles.xsd";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 24);
			this.label1.TabIndex = 95;
			this.label1.Text = "Choisir Rôle";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label2.Location = new System.Drawing.Point(24, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 24);
			this.label2.TabIndex = 96;
			this.label2.Text = "Nom d\'utilisateur";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
			this.label3.Location = new System.Drawing.Point(24, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 24);
			this.label3.TabIndex = 97;
			this.label3.Text = "Votre Mot De Passe";
			// 
			// button40
			// 
			this.button40.BackColor = System.Drawing.Color.Cornsilk;
			this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button40.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button40.Location = new System.Drawing.Point(392, 16);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(112, 96);
			this.button40.TabIndex = 99;
			this.button40.Text = "Entrée";
			this.button40.Click += new System.EventHandler(this.button40_Click);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Employe", new System.Data.Common.DataColumnMapping[] {
																																																				   new System.Data.Common.DataColumnMapping("Alias", "Alias")})});
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbDeleteCommand1
			// 
			this.oleDbDeleteCommand1.CommandText = "DELETE FROM Employe WHERE (NumEmploye = ?) AND (Alias = ? OR ? IS NULL AND Alias " +
				"IS NULL)";
			this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "NumEmploye", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Alias", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Alias", System.Data.DataRowVersion.Original, null));
			this.oleDbDeleteCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Alias1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Alias", System.Data.DataRowVersion.Original, null));
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=ZenithPlage.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False";
			// 
			// oleDbInsertCommand1
			// 
			this.oleDbInsertCommand1.CommandText = "INSERT INTO Employe(Alias, NumEmploye) VALUES (?, ?)";
			this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Alias", System.Data.OleDb.OleDbType.VarWChar, 50, "Alias"));
			this.oleDbInsertCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "NumEmploye", System.Data.DataRowVersion.Current, null));
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT Alias, NumEmploye FROM Employe";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbUpdateCommand1
			// 
			this.oleDbUpdateCommand1.CommandText = "UPDATE Employe SET Alias = ?, NumEmploye = ? WHERE (NumEmploye = ?) AND (Alias = " +
				"? OR ? IS NULL AND Alias IS NULL)";
			this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Alias", System.Data.OleDb.OleDbType.VarWChar, 50, "Alias"));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "NumEmploye", System.Data.DataRowVersion.Current, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_NumEmploye", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, false, ((System.Byte)(5)), ((System.Byte)(0)), "NumEmploye", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Alias", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Alias", System.Data.DataRowVersion.Original, null));
			this.oleDbUpdateCommand1.Parameters.Add(new System.Data.OleDb.OleDbParameter("Original_Alias1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Alias", System.Data.DataRowVersion.Original, null));
			// 
			// Accueil
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(530, 128);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button40,
																		  this.label3,
																		  this.label2,
																		  this.label1,
																		  this.comboBox1,
																		  this.textBox2,
																		  this.textBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Accueil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Accueil";
			this.Load += new System.EventHandler(this.Accueil_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsRoles1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			Application.Run(new Accueil());
		}
		
		

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			
			Clavier clavier= new Clavier();
			clavier.ShowDialog(this);
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			
			
		}

		private void textBox2_Enter(object sender, System.EventArgs e)
		{
			
			Clavier clavier= new Clavier();
			clavier.ShowDialog(this);
		}

		string strconn="Provider=Microsoft.Jet.OLEDB.4.0;Data source=ZenithPlage.mdb";
		OleDbConnection conn;
		string STRSQL;
		private void Accueil_Load(object sender, System.EventArgs e)
		{
			//Obtient le processus en cours de l'application 
			Process Proc_EnCours = Process.GetCurrentProcess(); 
			//Collection des processus actuellement lancés 
			Process[] Les_Proc = Process.GetProcesses(); 
			//Pour chaque processus lancé 
			foreach (Process Processus in Les_Proc) 
				/*Il ne faut pas comparer par rapport à cette instance 
					du programme mais une autre (grâce à l'ID)*/ 
				if (Proc_EnCours.Id != Processus.Id) 
					//Si les ID sont différents mais de même nom ==> 2 fois le même programme 
					if (Proc_EnCours.ProcessName == Processus.ProcessName) 
					{ 
						MessageBox.Show("Le programme ne peut pas être lancé 2 fois!"); 
						this.Close(); 
					} 
			textBox1.Focus();
			textBox1.SelectAll();
			oleDbDataAdapter1.Fill(dsRoles1);
		}

		private void button14_MouseHover(object sender, System.EventArgs e)
		{
			
		}

		private void button30_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
		
		}


		private void button40_Click(object sender, System.EventArgs e)
		{
			

			if(textBox1.Text=="")
			{
				textBox1.Select();
				return;
			}
			
			if(textBox2.Text=="")
			{
				textBox2.Select();
				return;
			}

			conn =new OleDbConnection(strconn);
			
				try
				{
					conn.Open();
				}
				catch(Exception ex) 
				{
					MessageBox.Show(ex.ToString());
				}
				OleDbCommand CommandSql;
				STRSQL= "Select count(*) from Employe Where (Alias = \""+textBox1.Text +
					"\" And MotDePasse = \""+textBox2.Text+"\")" ;
				int user=0;
				try
				{
					CommandSql = new OleDbCommand(STRSQL,conn);
				
					user=(int)CommandSql.ExecuteScalar();
				}
				catch(Exception ex){MessageBox.Show(STRSQL+ex.ToString());}

				if(user>0) 
				{
					Generale Gen = new Generale("");
					Gen.Show();
					this.Hide();
					
				}
				else
				{
					textBox1.Text="";
					textBox2.Text="";
					MessageBox.Show("Echec lors de la tentative de connexion Vérifier votre nom d'utilisateur et votre mot de passe","Gestion de plages",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				}
			
		}

		private void comboBox1_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			textBox1.Text=comboBox1.Text;
		}


	}
}
