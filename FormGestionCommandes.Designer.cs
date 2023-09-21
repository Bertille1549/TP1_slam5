namespace TP1
{
    partial class FormGestionCommandes
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
            textMontant = new TextBox();
            dtpCommande = new DateTimePicker();
            cbListeCli = new ComboBox();
            btnOk = new Button();
            lbl_montant = new Label();
            lbl_client = new Label();
            lbl_date = new Label();
            btn_annuler = new Button();
            btn_fermer = new Button();
            bsClients3 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsClients3).BeginInit();
            SuspendLayout();
            // 
            // textMontant
            // 
            textMontant.Location = new Point(289, 113);
            textMontant.Name = "textMontant";
            textMontant.Size = new Size(125, 27);
            textMontant.TabIndex = 0;
            // 
            // dtpCommande
            // 
            dtpCommande.Location = new Point(289, 153);
            dtpCommande.Name = "dtpCommande";
            dtpCommande.Size = new Size(250, 27);
            dtpCommande.TabIndex = 1;
            dtpCommande.ValueChanged += dtpCommande_ValueChanged;
            // 
            // cbListeCli
            // 
            cbListeCli.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListeCli.FormattingEnabled = true;
            cbListeCli.Location = new Point(289, 201);
            cbListeCli.Name = "cbListeCli";
            cbListeCli.Size = new Size(151, 28);
            cbListeCli.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(279, 285);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lbl_montant
            // 
            lbl_montant.AutoSize = true;
            lbl_montant.Location = new Point(145, 113);
            lbl_montant.Name = "lbl_montant";
            lbl_montant.Size = new Size(72, 20);
            lbl_montant.TabIndex = 4;
            lbl_montant.Text = "Montant :";
            // 
            // lbl_client
            // 
            lbl_client.AutoSize = true;
            lbl_client.Location = new Point(145, 201);
            lbl_client.Name = "lbl_client";
            lbl_client.Size = new Size(54, 20);
            lbl_client.TabIndex = 5;
            lbl_client.Text = "Client :";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(145, 153);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(48, 20);
            lbl_date.TabIndex = 6;
            lbl_date.Text = "Date :";
            // 
            // btn_annuler
            // 
            btn_annuler.Location = new Point(409, 285);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(94, 29);
            btn_annuler.TabIndex = 7;
            btn_annuler.Text = "Annuler";
            btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_fermer
            // 
            btn_fermer.Location = new Point(694, 12);
            btn_fermer.Name = "btn_fermer";
            btn_fermer.Size = new Size(94, 29);
            btn_fermer.TabIndex = 8;
            btn_fermer.Text = "Fermer";
            btn_fermer.UseVisualStyleBackColor = true;
            // 
            // FormGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_fermer);
            Controls.Add(btn_annuler);
            Controls.Add(lbl_date);
            Controls.Add(lbl_client);
            Controls.Add(lbl_montant);
            Controls.Add(btnOk);
            Controls.Add(cbListeCli);
            Controls.Add(dtpCommande);
            Controls.Add(textMontant);
            Name = "FormGestionCommandes";
            Text = "FormGestionCommandes";
            Load += FormGestionCommandes_Load;
            ((System.ComponentModel.ISupportInitialize)bsClients3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textMontant;
        private DateTimePicker dtpCommande;
        private ComboBox cbListeCli;
        private Button btnOk;
        private Label lbl_montant;
        private Label lbl_client;
        private Label lbl_date;
        private Button btn_annuler;
        private Button btn_fermer;
        private BindingSource bsClients3;
    }
}