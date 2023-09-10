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
            cbClients = new ComboBox();
            bsClients2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).BeginInit();
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
            dgvCommande.Location = new Point(0, 218);
            dgvCommande.Name = "dgvCommande";
            dgvCommande.ReadOnly = true;
            dgvCommande.RowHeadersWidth = 51;
            dgvCommande.RowTemplate.Height = 29;
            dgvCommande.Size = new Size(623, 231);
            dgvCommande.TabIndex = 0;
            // 
            // cbClients
            // 
            cbClients.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClients.FormattingEnabled = true;
            cbClients.Location = new Point(198, 66);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(267, 28);
            cbClients.TabIndex = 1;
            // 
            // bsClients2
            // 
            bsClients2.DataSource = typeof(Entities.Client);
            bsClients2.CurrentChanged += bsClients2_CurrentChanged;
            // 
            // TabCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbClients);
            Controls.Add(dgvCommande);
            Name = "TabCommande";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabCommande";
            Load += TabCommande_Load;
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsClients2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsCommande;
        private DataGridView dgvCommande;
        private ComboBox cbClients;
        private BindingSource bsClients2;
    }
}