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
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { commandesDataGridViewTextBoxColumn });
            dgvClients.DataSource = bsClients;
            dgvClients.Dock = DockStyle.Fill;
            dgvClients.Location = new Point(0, 0);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowTemplate.Height = 25;
            dgvClients.Size = new Size(800, 450);
            dgvClients.TabIndex = 0;
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
            ClientSize = new Size(800, 450);
            Controls.Add(dgvClients);
            Name = "Tableau";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bsClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsClients;
        private DataGridView dgvClients;
        private DataGridViewTextBoxColumn commandesDataGridViewTextBoxColumn;
    }
}