namespace TP1
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            commande = new ToolStripMenuItem();
            client = new ToolStripMenuItem();
            partition = new ToolStripMenuItem();
            auteur = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { commande, client, partition, auteur });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // commande
            // 
            commande.Name = "commande";
            commande.Size = new Size(100, 24);
            commande.Text = "Commande";
            commande.Click += commande_Click;
            // 
            // client
            // 
            client.Name = "client";
            client.Size = new Size(61, 24);
            client.Text = "Client";
            client.Click += client_Click;
            // 
            // partition
            // 
            partition.Name = "partition";
            partition.Size = new Size(78, 24);
            partition.Text = "Partition";
            partition.Click += partition_Click;
            // 
            // auteur
            // 
            auteur.Name = "auteur";
            auteur.Size = new Size(67, 24);
            auteur.Text = "Auteur";
            auteur.Click += auteur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem commande;
        private ToolStripMenuItem client;
        private ToolStripMenuItem partition;
        private ToolStripMenuItem auteur;
    }
}