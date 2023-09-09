namespace TP1
{
    partial class TabAuteur
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
            bsAuteur = new BindingSource(components);
            dgvAuteur = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsAuteur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuteur).BeginInit();
            SuspendLayout();
            // 
            // bsAuteur
            // 
            bsAuteur.DataSource = typeof(Entities.Auteur);
            // 
            // dgvAuteur
            // 
            dgvAuteur.AllowUserToAddRows = false;
            dgvAuteur.AllowUserToDeleteRows = false;
            dgvAuteur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAuteur.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAuteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuteur.Dock = DockStyle.Fill;
            dgvAuteur.Location = new Point(0, 0);
            dgvAuteur.Name = "dgvAuteur";
            dgvAuteur.ReadOnly = true;
            dgvAuteur.RowHeadersWidth = 51;
            dgvAuteur.RowTemplate.Height = 29;
            dgvAuteur.Size = new Size(800, 450);
            dgvAuteur.TabIndex = 0;
            // 
            // TabAuteur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAuteur);
            Name = "TabAuteur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabAuteur";
            Load += TabAuteur_Load;
            ((System.ComponentModel.ISupportInitialize)bsAuteur).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuteur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsAuteur;
        private DataGridView dgvAuteur;
    }
}