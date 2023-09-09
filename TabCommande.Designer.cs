namespace TP1
{
    partial class TabCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bsCommande = new BindingSource(components);
            dgvCommande = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            SuspendLayout();
            // 
            // bsCommande
            // 
            bsCommande.DataSource = typeof(Entities.Commande);
            // 
            // dgvCommande
            // 
            dgvCommande.AllowUserToAddRows = false;
            dgvCommande.AllowUserToDeleteRows = false;
            dgvCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommande.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommande.Dock = DockStyle.Fill;
            dgvCommande.Location = new Point(0, 0);
            dgvCommande.Name = "dgvCommande";
            dgvCommande.ReadOnly = true;
            dgvCommande.RowHeadersWidth = 51;
            dgvCommande.RowTemplate.Height = 29;
            dgvCommande.Size = new Size(800, 450);
            dgvCommande.TabIndex = 0;
            // 
            // TabCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCommande);
            Name = "TabCommande";
            Text = "TabCommande";
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsCommande;
        private DataGridView dgvCommande;
    }
}