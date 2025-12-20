using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graphism;

namespace Transacts
{
    /// <summary>
    /// Modernized TransatPrincipal form for beach chair management
    /// </summary>
    public partial class TransatPrincipalModern : Form
    {
        #region Constants
        private const int MaxTransats = 300;
        private const int TransatWidth = 42;
        private const int TransatHeight = 70;
        private const string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=ZenithPlage.mdb";
        #endregion

        #region Private Fields
        private readonly List<Transat> transats = new List<Transat>();
        private readonly HashSet<int> selectedTransatIndices = new HashSet<int>();
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private dsReservTransats reservationDataSet;
        private int transatCount;
        private Point lastMousePosition;
        private bool isDragging;
        #endregion

        #region UI Controls
        private Panel panelTransats;
        private PictureBox pictureBoxTransats;
        private DataGridView dataGridReservations;
        private ListBox listBoxSelection;
        private GroupBox groupBoxLocation;
        private GroupBox groupBoxReservation;
        private Button btnLocation;
        private Button btnReservation;
        private Button btnReturn;
        private Button btnNewLocation;
        private Button btnCloseLocation;
        private Button btnAddOption;
        private Button btnReturnLocation;
        private CheckBox chkLockLocation;
        private Button btnNewReservation;
        private Button btnModifyReservation;
        private Button btnDeleteReservation;
        private Button btnReturnReservation;
        private CheckBox chkLockReservation;
        private Label lblSelectedTransats;
        private Button btnDeleteTransat;
        private Button btnSearchTransat;
        #endregion

        #region Constructor
        public TransatPrincipalModern()
        {
            InitializeComponent();
            InitializeData();
            SetupEventHandlers();
        }
        #endregion

        #region Initialization Methods
        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            // Form properties
            this.Text = "Gestion Des Transats - Version Modernisée";
            this.Size = new Size(800, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9F);
            
            CreateControls();
            LayoutControls();
            
            this.ResumeLayout(false);
        }

        private void CreateControls()
        {
            // Main panel for transats
            panelTransats = new Panel
            {
                Name = "panelTransats",
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };

            pictureBoxTransats = new PictureBox
            {
                Name = "pictureBoxTransats",
                BackColor = SystemColors.HighlightText,
                SizeMode = PictureBoxSizeMode.AutoSize
            };

            // Data grid for reservations
            dataGridReservations = new DataGridView
            {
                Name = "dataGridReservations",
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                BackgroundColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 9F)
            };

            // Selection list
            listBoxSelection = new ListBox
            {
                Name = "listBoxSelection",
                Font = new Font("Segoe UI", 10F),
                SelectionMode = SelectionMode.MultiExtended,
                Sorted = true
            };

            // Group boxes
            groupBoxLocation = new GroupBox
            {
                Name = "groupBoxLocation",
                Text = "Location",
                Font = new Font("Segoe UI", 10F),
                Visible = false
            };

            groupBoxReservation = new GroupBox
            {
                Name = "groupBoxReservation",
                Text = "Réservation",
                Font = new Font("Segoe UI", 10F),
                Visible = false
            };

            // Main buttons
            btnLocation = CreateButton("btnLocation", "Location");
            btnReservation = CreateButton("btnReservation", "Réservation");
            btnReturn = CreateButton("btnReturn", "Retour");

            // Location buttons
            btnNewLocation = CreateButton("btnNewLocation", "Nouvelle Location");
            btnCloseLocation = CreateButton("btnCloseLocation", "Clôturer Location");
            btnAddOption = CreateButton("btnAddOption", "Ajouter Option");
            btnReturnLocation = CreateButton("btnReturnLocation", "Retour");
            chkLockLocation = new CheckBox { Text = "Verrouiller", Name = "chkLockLocation" };

            // Reservation buttons
            btnNewReservation = CreateButton("btnNewReservation", "Nouvelle Réservation");
            btnModifyReservation = CreateButton("btnModifyReservation", "Modifier Réservation");
            btnDeleteReservation = CreateButton("btnDeleteReservation", "Supprimer Réservation");
            btnReturnReservation = CreateButton("btnReturnReservation", "Retour");
            chkLockReservation = new CheckBox { Text = "Verrouiller", Name = "chkLockReservation" };

            // Other controls
            lblSelectedTransats = new Label
            {
                Text = "Transat(s) Sélectionné(s)",
                Font = new Font("Segoe UI", 10F),
                Name = "lblSelectedTransats"
            };

            btnDeleteTransat = CreateButton("btnDeleteTransat", "Supprimer Transat");
            btnSearchTransat = CreateButton("btnSearchTransat", "Rechercher Transat");

            // Add controls to containers
            panelTransats.Controls.Add(pictureBoxTransats);
            
            groupBoxLocation.Controls.AddRange(new Control[] {
                btnNewLocation, btnCloseLocation, btnAddOption, btnReturnLocation, chkLockLocation
            });

            groupBoxReservation.Controls.AddRange(new Control[] {
                btnNewReservation, btnModifyReservation, btnDeleteReservation, btnReturnReservation, chkLockReservation
            });

            this.Controls.AddRange(new Control[] {
                panelTransats, dataGridReservations, listBoxSelection, groupBoxLocation, groupBoxReservation,
                btnLocation, btnReservation, btnReturn, lblSelectedTransats, btnDeleteTransat, btnSearchTransat
            });
        }

        private Button CreateButton(string name, string text)
        {
            return new Button
            {
                Name = name,
                Text = text,
                Font = new Font("Segoe UI", 9F),
                UseVisualStyleBackColor = true,
                FlatStyle = FlatStyle.System
            };
        }

        private void LayoutControls()
        {
            // Main panel
            panelTransats.SetBounds(10, 10, 450, 430);
            pictureBoxTransats.SetBounds(5, 5, 440, 420);

            // Data grid
            dataGridReservations.SetBounds(470, 10, 300, 200);

            // Selection list and label
            lblSelectedTransats.SetBounds(470, 220, 200, 25);
            listBoxSelection.SetBounds(470, 250, 300, 120);

            // Action buttons
            btnDeleteTransat.SetBounds(470, 380, 140, 35);
            btnSearchTransat.SetBounds(620, 380, 150, 35);

            // Main control buttons
            btnLocation.SetBounds(10, 450, 100, 35);
            btnReservation.SetBounds(120, 450, 120, 35);
            btnReturn.SetBounds(670, 450, 100, 35);

            // Group boxes
            groupBoxLocation.SetBounds(10, 500, 760, 80);
            groupBoxReservation.SetBounds(10, 500, 760, 80);

            LayoutGroupBoxControls();
        }

        private void LayoutGroupBoxControls()
        {
            // Location group controls
            btnNewLocation.SetBounds(10, 25, 140, 40);
            btnAddOption.SetBounds(160, 25, 140, 40);
            btnCloseLocation.SetBounds(310, 25, 140, 40);
            btnReturnLocation.SetBounds(460, 25, 100, 40);
            chkLockLocation.SetBounds(580, 35, 100, 20);

            // Reservation group controls
            btnNewReservation.SetBounds(10, 25, 140, 40);
            btnModifyReservation.SetBounds(160, 25, 140, 40);
            btnDeleteReservation.SetBounds(310, 25, 140, 40);
            btnReturnReservation.SetBounds(460, 25, 100, 40);
            chkLockReservation.SetBounds(580, 35, 100, 20);
        }

        private void InitializeData()
        {
            // Initialize transats collection
            for (int i = 0; i < MaxTransats; i++)
            {
                transats.Add(new Transat());
            }

            // Initialize database connection
            connection = new OleDbConnection(ConnectionString);
            reservationDataSet = new dsReservTransats();
            
            InitializeDataAdapter();
        }

        private void InitializeDataAdapter()
        {
            dataAdapter = new OleDbDataAdapter();
            
            // Select command
            dataAdapter.SelectCommand = new OleDbCommand(
                "SELECT NumTransat AS [Numéro Transat], NumClient AS [Identificateur Client], " +
                "DateReservation AS [Date Réservation], NumReservation FROM ReservTransat", 
                connection);

            // Insert command
            dataAdapter.InsertCommand = new OleDbCommand(
                "INSERT INTO ReservTransat(NumTransat, NumClient, DateReservation, NumReservation) VALUES (?, ?, ?, ?)", 
                connection);

            // Update command
            dataAdapter.UpdateCommand = new OleDbCommand(
                "UPDATE ReservTransat SET NumTransat = ?, NumClient = ?, DateReservation = ?, NumReservation = ? " +
                "WHERE (NumReservation = ?) AND (DateReservation = ? OR ? IS NULL AND DateReservation IS NULL)", 
                connection);

            // Delete command
            dataAdapter.DeleteCommand = new OleDbCommand(
                "DELETE FROM ReservTransat WHERE (NumReservation = ?) AND (DateReservation = ? OR ? IS NULL AND DateReservation IS NULL)", 
                connection);
        }

        private void SetupEventHandlers()
        {
            // Form events
            this.Load += TransatPrincipalModern_Load;
            this.FormClosing += TransatPrincipalModern_FormClosing;

            // Main button events
            btnLocation.Click += BtnLocation_Click;
            btnReservation.Click += BtnReservation_Click;
            btnReturn.Click += BtnReturn_Click;

            // Location button events
            btnNewLocation.Click += BtnNewLocation_Click;
            btnCloseLocation.Click += BtnCloseLocation_Click;
            btnAddOption.Click += BtnAddOption_Click;
            btnReturnLocation.Click += BtnReturnLocation_Click;

            // Reservation button events
            btnNewReservation.Click += BtnNewReservation_Click;
            btnModifyReservation.Click += BtnModifyReservation_Click;
            btnDeleteReservation.Click += BtnDeleteReservation_Click;
            btnReturnReservation.Click += BtnReturnReservation_Click;

            // Transat interaction events
            pictureBoxTransats.MouseDown += PictureBoxTransats_MouseDown;
            pictureBoxTransats.MouseUp += PictureBoxTransats_MouseUp;
            pictureBoxTransats.MouseMove += PictureBoxTransats_MouseMove;

            // Other events
            btnDeleteTransat.Click += BtnDeleteTransat_Click;
            btnSearchTransat.Click += BtnSearchTransat_Click;
        }
        #endregion

        #region Event Handlers
        private async void TransatPrincipalModern_Load(object sender, EventArgs e)
        {
            try
            {
                await OpenConnectionAsync();
                await LoadTransatDataAsync();
                await LoadReservationDataAsync();
                RenderTransats();
            }
            catch (Exception ex)
            {
                ShowError("Erreur lors du chargement des données", ex);
            }
        }

        private void TransatPrincipalModern_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection?.Close();
            connection?.Dispose();
        }

        private void BtnLocation_Click(object sender, EventArgs e)
        {
            ShowLocationPanel();
        }

        private void BtnReservation_Click(object sender, EventArgs e)
        {
            ShowReservationPanel();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            var generale = new Generale("");
            this.Hide();
            generale.Show();
        }

        private void BtnReturnLocation_Click(object sender, EventArgs e)
        {
            HideLocationPanel();
        }

        private void BtnReturnReservation_Click(object sender, EventArgs e)
        {
            HideReservationPanel();
        }

        private async void BtnNewLocation_Click(object sender, EventArgs e)
        {
            if (!HasSelectedTransats())
            {
                MessageBox.Show("Veuillez sélectionner au moins un transat.", "Aucune sélection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var locationForm = new NouvelleLocation();
                if (locationForm.ShowDialog() == DialogResult.OK)
                {
                    await UpdateTransatStatusAsync(GetSelectedTransatNumbers(), 2); // 2 = occupied
                    await LoadTransatDataAsync();
                    RenderTransats();
                    ClearSelection();
                }
            }
            catch (Exception ex)
            {
                ShowError("Erreur lors de la création de la location", ex);
            }
        }

        private async void BtnCloseLocation_Click(object sender, EventArgs e)
        {
            if (!HasSelectedTransats())
            {
                MessageBox.Show("Veuillez sélectionner au moins un transat.", "Aucune sélection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await UpdateTransatStatusAsync(GetSelectedTransatNumbers(), 0); // 0 = available
                await LoadTransatDataAsync();
                RenderTransats();
                ClearSelection();
            }
            catch (Exception ex)
            {
                ShowError("Erreur lors de la clôture de la location", ex);
            }
        }

        private void BtnAddOption_Click(object sender, EventArgs e)
        {
            var optionForm = new AjouterOption();
            optionForm.ShowDialog();
        }

        private async void BtnNewReservation_Click(object sender, EventArgs e)
        {
            if (!HasSelectedTransats())
            {
                MessageBox.Show("Veuillez sélectionner au moins un transat.", "Aucune sélection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var reservationForm = new NouvelleReservation();
                if (reservationForm.ShowDialog() == DialogResult.OK)
                {
                    await CreateReservationAsync(GetSelectedTransatNumbers().First(), reservationForm);
                    await LoadReservationDataAsync();
                    ClearSelection();
                }
            }
            catch (Exception ex)
            {
                ShowError("Erreur lors de la création de la réservation", ex);
            }
        }

        private void BtnModifyReservation_Click(object sender, EventArgs e)
        {
            // Implementation for modifying reservation
            MessageBox.Show("Fonctionnalité de modification en cours de développement.", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void BtnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (!HasSelectedTransats())
            {
                MessageBox.Show("Veuillez sélectionner au moins un transat.", "Aucune sélection", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Confirmer la suppression de la réservation ?", 
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    await UpdateTransatStatusAsync(GetSelectedTransatNumbers(), 0); // 0 = available
                    await LoadTransatDataAsync();
                    await LoadReservationDataAsync();
                    RenderTransats();
                    ClearSelection();
                }
                catch (Exception ex)
                {
                    ShowError("Erreur lors de la suppression de la réservation", ex);
                }
            }
        }

        private void BtnDeleteTransat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité de suppression de transat en cours de développement.", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSearchTransat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité de recherche en cours de développement.", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBoxTransats_MouseDown(object sender, MouseEventArgs e)
        {
            lastMousePosition = e.Location;
            var transatIndex = GetTransatAtPosition(e.Location);
            
            if (transatIndex >= 0)
            {
                isDragging = true;
                SelectTransat(transatIndex, Control.ModifierKeys.HasFlag(Keys.Control));
            }
            else
            {
                // Create new transat
                if (MessageBox.Show("Créer un transat ici ?", "Nouveau transat", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var ajouTable = new AjouTable();
                    if (ajouTable.ShowDialog() == DialogResult.OK)
                    {
                        CreateTransatAsync(e.Location, ajouTable.numeroTable);
                    }
                }
            }
        }

        private async void PictureBoxTransats_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging && lastMousePosition != e.Location)
            {
                var sourceIndex = GetTransatAtPosition(lastMousePosition);
                var targetIndex = GetTransatAtPosition(e.Location);
                
                if (sourceIndex >= 0 && targetIndex >= 0 && sourceIndex != targetIndex)
                {
                    await SwapTransatPositionsAsync(sourceIndex, targetIndex);
                }
            }
            
            isDragging = false;
            pictureBoxTransats.Cursor = Cursors.Default;
        }

        private void PictureBoxTransats_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                pictureBoxTransats.Cursor = Cursors.Hand;
            }
        }
        #endregion

        #region Data Methods
        private async Task OpenConnectionAsync()
        {
            if (connection.State != ConnectionState.Open)
            {
                await Task.Run(() => connection.Open());
            }
        }

        private async Task LoadTransatDataAsync()
        {
            try
            {
                await OpenConnectionAsync();
                
                var command = new OleDbCommand("SELECT * FROM Transat ORDER BY NumTransat", connection);
                var dataSet = new DataSet();
                var adapter = new OleDbDataAdapter(command);
                
                await Task.Run(() => adapter.Fill(dataSet, "Transat"));
                
                transatCount = dataSet.Tables[0].Rows.Count;
                
                for (int i = 0; i < transatCount && i < transats.Count; i++)
                {
                    var row = dataSet.Tables[0].Rows[i];
                    transats[i].SetNumTransat(Convert.ToInt32(row[0]));
                    transats[i].SetPosX(Convert.ToInt32(row[1]));
                    transats[i].SetPosY(Convert.ToInt32(row[2]));
                    transats[i].SetEtatCourant(Convert.ToInt32(row[3]));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors du chargement des données des transats", ex);
            }
        }

        private async Task LoadReservationDataAsync()
        {
            try
            {
                await OpenConnectionAsync();
                reservationDataSet.Clear();
                await Task.Run(() => dataAdapter.Fill(reservationDataSet));
                dataGridReservations.DataSource = reservationDataSet.ReservTransat;
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors du chargement des réservations", ex);
            }
        }

        private async Task UpdateTransatStatusAsync(IEnumerable<int> transatNumbers, int newStatus)
        {
            await OpenConnectionAsync();
            
            foreach (var transatNumber in transatNumbers)
            {
                var command = new OleDbCommand(
                    "UPDATE Transat SET EtatCourant = ? WHERE NumTransat = ?", connection);
                command.Parameters.AddWithValue("@status", newStatus);
                command.Parameters.AddWithValue("@number", transatNumber);
                
                await Task.Run(() => command.ExecuteNonQuery());
                
                // Update local data
                var transat = transats.FirstOrDefault(t => t.GetNumTransat() == transatNumber);
                transat?.SetEtatCourant(newStatus);
            }
        }

        private async Task CreateReservationAsync(int transatNumber, NouvelleReservation reservationForm)
        {
            await OpenConnectionAsync();
            
            var command = new OleDbCommand(
                "INSERT INTO ReservTransat (NumTransat, NumClient, DateReservation) VALUES (?, ?, ?)", 
                connection);
            command.Parameters.AddWithValue("@transat", transatNumber);
            command.Parameters.AddWithValue("@client", reservationForm.NumClient);
            command.Parameters.AddWithValue("@date", reservationForm.DateRes);
            
            await Task.Run(() => command.ExecuteNonQuery());
        }

        private async Task CreateTransatAsync(Point position, int transatNumber)
        {
            var gridX = (position.X / TransatWidth) + 1;
            var gridY = (position.Y / TransatHeight) + 1;
            
            await OpenConnectionAsync();
            
            var command = new OleDbCommand(
                "INSERT INTO Transat (NumTransat, PosX, PosY, EtatCourant) VALUES (?, ?, ?, 0)", 
                connection);
            command.Parameters.AddWithValue("@number", transatNumber);
            command.Parameters.AddWithValue("@x", gridX);
            command.Parameters.AddWithValue("@y", gridY);
            
            await Task.Run(() => command.ExecuteNonQuery());
            await LoadTransatDataAsync();
            RenderTransats();
        }

        private async Task SwapTransatPositionsAsync(int index1, int index2)
        {
            var transat1 = transats[index1];
            var transat2 = transats[index2];
            
            // Swap positions
            var tempX = transat1.GetPosX();
            var tempY = transat1.GetPosY();
            
            transat1.SetPosX(transat2.GetPosX());
            transat1.SetPosY(transat2.GetPosY());
            transat2.SetPosX(tempX);
            transat2.SetPosY(tempY);
            
            await OpenConnectionAsync();
            
            // Update database
            var command1 = new OleDbCommand(
                "UPDATE Transat SET PosX = ?, PosY = ? WHERE NumTransat = ?", connection);
            command1.Parameters.AddWithValue("@x", transat1.GetPosX());
            command1.Parameters.AddWithValue("@y", transat1.GetPosY());
            command1.Parameters.AddWithValue("@number", transat1.GetNumTransat());
            
            var command2 = new OleDbCommand(
                "UPDATE Transat SET PosX = ?, PosY = ? WHERE NumTransat = ?", connection);
            command2.Parameters.AddWithValue("@x", transat2.GetPosX());
            command2.Parameters.AddWithValue("@y", transat2.GetPosY());
            command2.Parameters.AddWithValue("@number", transat2.GetNumTransat());
            
            await Task.Run(() =>
            {
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            });
            
            RenderTransats();
        }
        #endregion

        #region UI Helper Methods
        private void ShowLocationPanel()
        {
            groupBoxLocation.Visible = true;
            groupBoxReservation.Visible = false;
        }

        private void ShowReservationPanel()
        {
            groupBoxReservation.Visible = true;
            groupBoxLocation.Visible = false;
        }

        private void HideLocationPanel()
        {
            groupBoxLocation.Visible = false;
            chkLockLocation.Checked = false;
        }

        private void HideReservationPanel()
        {
            groupBoxReservation.Visible = false;
            chkLockReservation.Checked = false;
        }

        private void RenderTransats()
        {
            if (transatCount == 0) return;

            var maxX = transats.Take(transatCount).Max(t => t.GetPosX());
            var maxY = transats.Take(transatCount).Max(t => t.GetPosY());
            
            var bitmap = new Bitmap(TransatWidth * maxX + 50, TransatHeight * maxY + 150);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                
                var renderer = new Class1();
                renderer.BackGround(graphics, Color.Beige, 0, 0, bitmap.Width, bitmap.Height);
                
                for (int i = 0; i < transatCount; i++)
                {
                    var transat = transats[i];
                    var color = GetTransatColor(transat.GetEtatCourant());
                    var isSelected = selectedTransatIndices.Contains(i);
                    
                    if (isSelected)
                    {
                        color = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                    }
                    
                    var x = TransatWidth * (transat.GetPosX() - 1);
                    var y = TransatHeight * (transat.GetPosY() - 1);
                    
                    renderer.SkyScraper(graphics, x, y, 30, 45, 3, 3, color, transat.GetNumTransat(), 17);
                }
            }
            
            pictureBoxTransats.Image?.Dispose();
            pictureBoxTransats.Image = bitmap;
            pictureBoxTransats.Size = new Size(bitmap.Width, bitmap.Height);
        }

        private Color GetTransatColor(int status)
        {
            return status switch
            {
                0 => Color.Green,      // Available
                1 => Color.GreenYellow, // Reserved
                2 => Color.Red,        // Occupied
                _ => Color.Gray
            };
        }

        private int GetTransatAtPosition(Point position)
        {
            var gridX = (position.X / TransatWidth) + 1;
            var gridY = (position.Y / TransatHeight) + 1;
            
            for (int i = 0; i < transatCount; i++)
            {
                if (transats[i].GetPosX() == gridX && transats[i].GetPosY() == gridY)
                {
                    return i;
                }
            }
            
            return -1;
        }

        private void SelectTransat(int index, bool multiSelect)
        {
            if (!multiSelect && !chkLockLocation.Checked && !chkLockReservation.Checked)
            {
                selectedTransatIndices.Clear();
                listBoxSelection.Items.Clear();
            }
            
            if (selectedTransatIndices.Contains(index))
            {
                selectedTransatIndices.Remove(index);
                var itemToRemove = $"Transat {transats[index].GetNumTransat()}";
                listBoxSelection.Items.Remove(itemToRemove);
            }
            else
            {
                selectedTransatIndices.Add(index);
                listBoxSelection.Items.Add($"Transat {transats[index].GetNumTransat()}");
            }
            
            RenderTransats();
        }

        private bool HasSelectedTransats()
        {
            return selectedTransatIndices.Count > 0;
        }

        private IEnumerable<int> GetSelectedTransatNumbers()
        {
            return selectedTransatIndices.Select(i => transats[i].GetNumTransat());
        }

        private void ClearSelection()
        {
            selectedTransatIndices.Clear();
            listBoxSelection.Items.Clear();
            RenderTransats();
        }

        private void ShowError(string message, Exception ex)
        {
            var fullMessage = $"{message}\n\nDétails: {ex.Message}";
            MessageBox.Show(fullMessage, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region IDisposable
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                connection?.Dispose();
                dataAdapter?.Dispose();
                reservationDataSet?.Dispose();
                pictureBoxTransats?.Image?.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}