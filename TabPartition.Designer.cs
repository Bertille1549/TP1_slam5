namespace TP1
{
    partial class TabPartition
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
            bsPartition = new BindingSource(components);
            dgvPartition = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsPartition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartition).BeginInit();
            SuspendLayout();
            // 
            // bsPartition
            // 
            bsPartition.DataSource = typeof(Entities.Partition);
            // 
            // dgvPartition
            // 
            dgvPartition.AllowUserToAddRows = false;
            dgvPartition.AllowUserToDeleteRows = false;
            dgvPartition.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPartition.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPartition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartition.Dock = DockStyle.Fill;
            dgvPartition.Location = new Point(0, 0);
            dgvPartition.Name = "dgvPartition";
            dgvPartition.ReadOnly = true;
            dgvPartition.RowHeadersWidth = 51;
            dgvPartition.RowTemplate.Height = 29;
            dgvPartition.Size = new Size(800, 450);
            dgvPartition.TabIndex = 0;
            // 
            // TabPartition
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPartition);
            Name = "TabPartition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabPartition";
            Load += TabPartition_Load;
            ((System.ComponentModel.ISupportInitialize)bsPartition).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartition).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsPartition;
        private DataGridView dgvPartition;
    }
}