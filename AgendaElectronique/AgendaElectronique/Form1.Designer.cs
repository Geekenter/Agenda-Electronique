namespace AgendaElectronique
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.evenementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerEvenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEvenementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnEvenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerEvenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherEvenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterEvenementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meNotifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evenementsToolStripMenuItem,
            this.meNotifierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // evenementsToolStripMenuItem
            // 
            this.evenementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerEvenementToolStripMenuItem,
            this.listeDesEvenementsToolStripMenuItem,
            this.modifierUnEvenementToolStripMenuItem,
            this.supprimerEvenementToolStripMenuItem,
            this.rechercherEvenementToolStripMenuItem,
            this.exporterEvenementToolStripMenuItem});
            this.evenementsToolStripMenuItem.Name = "evenementsToolStripMenuItem";
            this.evenementsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.evenementsToolStripMenuItem.Text = "Evenements";
            // 
            // creerEvenementToolStripMenuItem
            // 
            this.creerEvenementToolStripMenuItem.Name = "creerEvenementToolStripMenuItem";
            this.creerEvenementToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.creerEvenementToolStripMenuItem.Text = "Créer évenement";
            this.creerEvenementToolStripMenuItem.Click += new System.EventHandler(this.creerEvenementToolStripMenuItem_Click);
            // 
            // listeDesEvenementsToolStripMenuItem
            // 
            this.listeDesEvenementsToolStripMenuItem.Name = "listeDesEvenementsToolStripMenuItem";
            this.listeDesEvenementsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listeDesEvenementsToolStripMenuItem.Text = "Liste des evenements";
            this.listeDesEvenementsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEvenementsToolStripMenuItem_Click);
            // 
            // modifierUnEvenementToolStripMenuItem
            // 
            this.modifierUnEvenementToolStripMenuItem.Name = "modifierUnEvenementToolStripMenuItem";
            this.modifierUnEvenementToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.modifierUnEvenementToolStripMenuItem.Text = "Modifier un evenement";
            this.modifierUnEvenementToolStripMenuItem.Click += new System.EventHandler(this.modifierUnEvenementToolStripMenuItem_Click);
            // 
            // supprimerEvenementToolStripMenuItem
            // 
            this.supprimerEvenementToolStripMenuItem.Name = "supprimerEvenementToolStripMenuItem";
            this.supprimerEvenementToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.supprimerEvenementToolStripMenuItem.Text = "Supprimer evenement";
            this.supprimerEvenementToolStripMenuItem.Click += new System.EventHandler(this.supprimerEvenementToolStripMenuItem_Click);
            // 
            // rechercherEvenementToolStripMenuItem
            // 
            this.rechercherEvenementToolStripMenuItem.Name = "rechercherEvenementToolStripMenuItem";
            this.rechercherEvenementToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rechercherEvenementToolStripMenuItem.Text = "Rechercher evenement";
            this.rechercherEvenementToolStripMenuItem.Click += new System.EventHandler(this.rechercherEvenementToolStripMenuItem_Click);
            // 
            // exporterEvenementToolStripMenuItem
            // 
            this.exporterEvenementToolStripMenuItem.Name = "exporterEvenementToolStripMenuItem";
            this.exporterEvenementToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exporterEvenementToolStripMenuItem.Text = "Exporter evenement";
            this.exporterEvenementToolStripMenuItem.Click += new System.EventHandler(this.exporterEvenementToolStripMenuItem_Click);
            // 
            // meNotifierToolStripMenuItem
            // 
            this.meNotifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parMailToolStripMenuItem,
            this.parSmsToolStripMenuItem});
            this.meNotifierToolStripMenuItem.Name = "meNotifierToolStripMenuItem";
            this.meNotifierToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.meNotifierToolStripMenuItem.Text = "Me notifier";
            // 
            // parMailToolStripMenuItem
            // 
            this.parMailToolStripMenuItem.Name = "parMailToolStripMenuItem";
            this.parMailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parMailToolStripMenuItem.Text = "Par mail";
            // 
            // parSmsToolStripMenuItem
            // 
            this.parSmsToolStripMenuItem.Name = "parSmsToolStripMenuItem";
            this.parSmsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.parSmsToolStripMenuItem.Text = "Par sms";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 328);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LIPROGLAGENDA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evenementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerEvenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesEvenementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnEvenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerEvenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherEvenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterEvenementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meNotifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSmsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

