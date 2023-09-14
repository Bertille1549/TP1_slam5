namespace TP1
{
    partial class Tableau
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsClients = new BindingSource(components);
            dgvClients = new DataGridView();
            numcliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomcliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prenomcliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adrcliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telcliDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commandesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bsClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // bsClients
            // 
            bsClients.DataSource = typeof(Entities.Client);
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoGenerateColumns = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { numcliDataGridViewTextBoxColumn, nomcliDataGridViewTextBoxColumn, prenomcliDataGridViewTextBoxColumn, adrcliDataGridViewTextBoxColumn, telcliDataGridViewTextBoxColumn, commandesDataGridViewTextBoxColumn });
            dgvClients.DataSource = bsClients;
            dgvClients.Dock = DockStyle.Fill;
            dgvClients.Location = new Point(0, 0);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersWidth = 51;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(700, 338);
            dgvClients.TabIndex = 0;
            // 
            // numcliDataGridViewTextBoxColumn
            // 
            numcliDataGridViewTextBoxColumn.DataPropertyName = "Numcli";
            numcliDataGridViewTextBoxColumn.HeaderText = "Numcli";
            numcliDataGridViewTextBoxColumn.Name = "numcliDataGridViewTextBoxColumn";
            numcliDataGridViewTextBoxColumn.ReadOnly = true;
            numcliDataGridViewTextBoxColumn.Width = 71;
            // 
            // nomcliDataGridViewTextBoxColumn
            // 
            nomcliDataGridViewTextBoxColumn.DataPropertyName = "Nomcli";
            nomcliDataGridViewTextBoxColumn.HeaderText = "Nomcli";
            nomcliDataGridViewTextBoxColumn.Name = "nomcliDataGridViewTextBoxColumn";
            nomcliDataGridViewTextBoxColumn.ReadOnly = true;
            nomcliDataGridViewTextBoxColumn.Width = 71;
            // 
            // prenomcliDataGridViewTextBoxColumn
            // 
            prenomcliDataGridViewTextBoxColumn.DataPropertyName = "Prenomcli";
            prenomcliDataGridViewTextBoxColumn.HeaderText = "Prenomcli";
            prenomcliDataGridViewTextBoxColumn.Name = "prenomcliDataGridViewTextBoxColumn";
            prenomcliDataGridViewTextBoxColumn.ReadOnly = true;
            prenomcliDataGridViewTextBoxColumn.Width = 86;
            // 
            // adrcliDataGridViewTextBoxColumn
            // 
            adrcliDataGridViewTextBoxColumn.DataPropertyName = "Adrcli";
            adrcliDataGridViewTextBoxColumn.HeaderText = "Adrcli";
            adrcliDataGridViewTextBoxColumn.Name = "adrcliDataGridViewTextBoxColumn";
            adrcliDataGridViewTextBoxColumn.ReadOnly = true;
            adrcliDataGridViewTextBoxColumn.Width = 63;
            // 
            // telcliDataGridViewTextBoxColumn
            // 
            telcliDataGridViewTextBoxColumn.DataPropertyName = "Telcli";
            telcliDataGridViewTextBoxColumn.HeaderText = "Telcli";
            telcliDataGridViewTextBoxColumn.Name = "telcliDataGridViewTextBoxColumn";
            telcliDataGridViewTextBoxColumn.ReadOnly = true;
            telcliDataGridViewTextBoxColumn.Width = 58;
            // 
            // commandesDataGridViewTextBoxColumn
            // 
            commandesDataGridViewTextBoxColumn.DataPropertyName = "Commandes";
            commandesDataGridViewTextBoxColumn.HeaderText = "Commandes";
            commandesDataGridViewTextBoxColumn.Name = "commandesDataGridViewTextBoxColumn";
            commandesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Tableau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dgvClients);
            Name = "Tableau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabClient";
            Load += Tableau_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
        private DataGridViewTextBoxColumn numcliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomcliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomcliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adrcliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telcliDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commandesDataGridViewTextBoxColumn;
    }
}