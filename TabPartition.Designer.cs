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
            cbStyle = new ComboBox();
            bsStyle = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsPartition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
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
            dgvPartition.Location = new Point(0, 183);
            dgvPartition.Margin = new Padding(3, 2, 3, 2);
            dgvPartition.Name = "dgvPartition";
            dgvPartition.ReadOnly = true;
            dgvPartition.RowHeadersWidth = 51;
            dgvPartition.RowTemplate.Height = 29;
            dgvPartition.Size = new Size(700, 155);
            dgvPartition.TabIndex = 0;
            // 
            // cbStyle
            // 
            cbStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStyle.FormattingEnabled = true;
            cbStyle.Location = new Point(198, 73);
            cbStyle.Margin = new Padding(3, 2, 3, 2);
            cbStyle.Name = "cbStyle";
            cbStyle.Size = new Size(234, 23);
            cbStyle.TabIndex = 2;
            // 
            // bsStyle
            // 
            bsStyle.DataSource = typeof(Entities.Style);
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // TabPartition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(cbStyle);
            Controls.Add(dgvPartition);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TabPartition";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabPartition";
            Load += TabPartition_Load;
            ((System.ComponentModel.ISupportInitialize)bsPartition).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPartition).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsPartition;
        private DataGridView dgvPartition;
        private ComboBox cbStyle;
        private BindingSource bsStyle;
    }
}