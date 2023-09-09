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
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { numcliDataGridViewTextBoxColumn, nomcliDataGridViewTextBoxColumn, prenomcliDataGridViewTextBoxColumn, adrcliDataGridViewTextBoxColumn, commandesDataGridViewTextBoxColumn });
            dgvClients.DataSource = bsClients;
            dgvClients.Dock = DockStyle.Fill;
            dgvClients.Location = new Point(0, 0);
            dgvClients.Margin = new Padding(3, 4, 3, 4);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersWidth = 51;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(800, 450);
            dgvClients.TabIndex = 0;
            // 
            // numcliDataGridViewTextBoxColumn
            // 
            numcliDataGridViewTextBoxColumn.DataPropertyName = "Numcli";
            numcliDataGridViewTextBoxColumn.HeaderText = "Numcli";
            numcliDataGridViewTextBoxColumn.MinimumWidth = 6;
            numcliDataGridViewTextBoxColumn.Name = "numcliDataGridViewTextBoxColumn";
            numcliDataGridViewTextBoxColumn.ReadOnly = true;
            numcliDataGridViewTextBoxColumn.Width = 85;
            // 
            // nomcliDataGridViewTextBoxColumn
            // 
            nomcliDataGridViewTextBoxColumn.DataPropertyName = "Nomcli";
            nomcliDataGridViewTextBoxColumn.HeaderText = "Nomcli";
            nomcliDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomcliDataGridViewTextBoxColumn.Name = "nomcliDataGridViewTextBoxColumn";
            nomcliDataGridViewTextBoxColumn.ReadOnly = true;
            nomcliDataGridViewTextBoxColumn.Width = 86;
            // 
            // prenomcliDataGridViewTextBoxColumn
            // 
            prenomcliDataGridViewTextBoxColumn.DataPropertyName = "Prenomcli";
            prenomcliDataGridViewTextBoxColumn.HeaderText = "Prenomcli";
            prenomcliDataGridViewTextBoxColumn.MinimumWidth = 6;
            prenomcliDataGridViewTextBoxColumn.Name = "prenomcliDataGridViewTextBoxColumn";
            prenomcliDataGridViewTextBoxColumn.ReadOnly = true;
            prenomcliDataGridViewTextBoxColumn.Width = 104;
            // 
            // adrcliDataGridViewTextBoxColumn
            // 
            adrcliDataGridViewTextBoxColumn.DataPropertyName = "Adrcli";
            adrcliDataGridViewTextBoxColumn.HeaderText = "Adrcli";
            adrcliDataGridViewTextBoxColumn.MinimumWidth = 6;
            adrcliDataGridViewTextBoxColumn.Name = "adrcliDataGridViewTextBoxColumn";
            adrcliDataGridViewTextBoxColumn.ReadOnly = true;
            adrcliDataGridViewTextBoxColumn.Width = 77;
            // 
            // commandesDataGridViewTextBoxColumn
            // 
            commandesDataGridViewTextBoxColumn.DataPropertyName = "Commandes";
            commandesDataGridViewTextBoxColumn.HeaderText = "Commandes";
            commandesDataGridViewTextBoxColumn.MinimumWidth = 6;
            commandesDataGridViewTextBoxColumn.Name = "commandesDataGridViewTextBoxColumn";
            commandesDataGridViewTextBoxColumn.ReadOnly = true;
            commandesDataGridViewTextBoxColumn.Width = 121;
            // 
            // Tableau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClients);
            Margin = new Padding(3, 4, 3, 4);
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
        private DataGridViewTextBoxColumn commandesDataGridViewTextBoxColumn;
    }
}