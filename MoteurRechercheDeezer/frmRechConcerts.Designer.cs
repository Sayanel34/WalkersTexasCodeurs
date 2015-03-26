namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    partial class frmRechConcerts
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
            this.cbTypeRech = new System.Windows.Forms.ComboBox();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lstSugestions = new System.Windows.Forms.ListBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.tabConcert = new System.Windows.Forms.TabControl();
            this.tabPageConcert = new System.Windows.Forms.TabPage();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblArtiste = new System.Windows.Forms.Label();
            this.lblConcert = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstConcerts = new System.Windows.Forms.ListBox();
            this.tabPageMeteo = new System.Windows.Forms.TabPage();
            this.tabPageLocalisation = new System.Windows.Forms.TabPage();
            this.iconMeteo = new System.Windows.Forms.PictureBox();
            this.nomConcert = new System.Windows.Forms.Label();
            this.typeMeteo = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.tabConcert.SuspendLayout();
            this.tabPageConcert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageMeteo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMeteo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTypeRech
            // 
            this.cbTypeRech.FormattingEnabled = true;
            this.cbTypeRech.Location = new System.Drawing.Point(13, 80);
            this.cbTypeRech.Name = "cbTypeRech";
            this.cbTypeRech.Size = new System.Drawing.Size(121, 21);
            this.cbTypeRech.TabIndex = 0;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(139, 80);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(140, 20);
            this.txtRecherche.TabIndex = 1;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // lstSugestions
            // 
            this.lstSugestions.FormattingEnabled = true;
            this.lstSugestions.Location = new System.Drawing.Point(139, 106);
            this.lstSugestions.MaximumSize = new System.Drawing.Size(141, 300);
            this.lstSugestions.MinimumSize = new System.Drawing.Size(141, 20);
            this.lstSugestions.Name = "lstSugestions";
            this.lstSugestions.Size = new System.Drawing.Size(141, 56);
            this.lstSugestions.TabIndex = 2;
            this.lstSugestions.Visible = false;
            this.lstSugestions.SelectedIndexChanged += new System.EventHandler(this.lstSugestions_SelectedIndexChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(287, 81);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(46, 19);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "GO !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // tabConcert
            // 
            this.tabConcert.Controls.Add(this.tabPageConcert);
            this.tabConcert.Controls.Add(this.tabPageMeteo);
            this.tabConcert.Controls.Add(this.tabPageLocalisation);
            this.tabConcert.Enabled = false;
            this.tabConcert.Location = new System.Drawing.Point(12, 117);
            this.tabConcert.Name = "tabConcert";
            this.tabConcert.SelectedIndex = 0;
            this.tabConcert.Size = new System.Drawing.Size(702, 278);
            this.tabConcert.TabIndex = 5;
            // 
            // tabPageConcert
            // 
            this.tabPageConcert.Controls.Add(this.lblDebut);
            this.tabPageConcert.Controls.Add(this.lblVille);
            this.tabPageConcert.Controls.Add(this.lblArtiste);
            this.tabPageConcert.Controls.Add(this.lblConcert);
            this.tabPageConcert.Controls.Add(this.pictureBox1);
            this.tabPageConcert.Controls.Add(this.label4);
            this.tabPageConcert.Controls.Add(this.label3);
            this.tabPageConcert.Controls.Add(this.label2);
            this.tabPageConcert.Controls.Add(this.label1);
            this.tabPageConcert.Controls.Add(this.lstConcerts);
            this.tabPageConcert.Location = new System.Drawing.Point(4, 22);
            this.tabPageConcert.Name = "tabPageConcert";
            this.tabPageConcert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConcert.Size = new System.Drawing.Size(694, 252);
            this.tabPageConcert.TabIndex = 0;
            this.tabPageConcert.Text = "Concert";
            this.tabPageConcert.UseVisualStyleBackColor = true;
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Location = new System.Drawing.Point(389, 84);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(35, 13);
            this.lblDebut.TabIndex = 9;
            this.lblDebut.Text = "label8";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(334, 61);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(35, 13);
            this.lblVille.TabIndex = 8;
            this.lblVille.Text = "label7";
            // 
            // lblArtiste
            // 
            this.lblArtiste.AutoSize = true;
            this.lblArtiste.Location = new System.Drawing.Point(394, 38);
            this.lblArtiste.Name = "lblArtiste";
            this.lblArtiste.Size = new System.Drawing.Size(35, 13);
            this.lblArtiste.TabIndex = 7;
            this.lblArtiste.Text = "label6";
            // 
            // lblConcert
            // 
            this.lblConcert.AutoSize = true;
            this.lblConcert.Location = new System.Drawing.Point(394, 15);
            this.lblConcert.Name = "lblConcert";
            this.lblConcert.Size = new System.Drawing.Size(35, 13);
            this.lblConcert.TabIndex = 6;
            this.lblConcert.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(188, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 92);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Heure de début :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ville :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom de l\'artiste :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du concert : ";
            // 
            // lstConcerts
            // 
            this.lstConcerts.FormattingEnabled = true;
            this.lstConcerts.Location = new System.Drawing.Point(6, 6);
            this.lstConcerts.Name = "lstConcerts";
            this.lstConcerts.Size = new System.Drawing.Size(166, 238);
            this.lstConcerts.TabIndex = 0;
            // 
            // tabPageMeteo
            // 
            this.tabPageMeteo.Controls.Add(this.Temperature);
            this.tabPageMeteo.Controls.Add(this.typeMeteo);
            this.tabPageMeteo.Controls.Add(this.nomConcert);
            this.tabPageMeteo.Controls.Add(this.iconMeteo);
            this.tabPageMeteo.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeteo.Name = "tabPageMeteo";
            this.tabPageMeteo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeteo.Size = new System.Drawing.Size(694, 252);
            this.tabPageMeteo.TabIndex = 2;
            this.tabPageMeteo.Text = "Météo";
            this.tabPageMeteo.UseVisualStyleBackColor = true;
            // 
            // tabPageLocalisation
            // 
            this.tabPageLocalisation.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocalisation.Name = "tabPageLocalisation";
            this.tabPageLocalisation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocalisation.Size = new System.Drawing.Size(694, 252);
            this.tabPageLocalisation.TabIndex = 3;
            this.tabPageLocalisation.Text = "Localisation";
            this.tabPageLocalisation.UseVisualStyleBackColor = true;
            // 
            // iconMeteo
            // 
            this.iconMeteo.Location = new System.Drawing.Point(7, 7);
            this.iconMeteo.Name = "iconMeteo";
            this.iconMeteo.Size = new System.Drawing.Size(148, 73);
            this.iconMeteo.TabIndex = 0;
            this.iconMeteo.TabStop = false;
            // 
            // nomConcert
            // 
            this.nomConcert.AutoSize = true;
            this.nomConcert.Location = new System.Drawing.Point(368, 19);
            this.nomConcert.Name = "nomConcert";
            this.nomConcert.Size = new System.Drawing.Size(110, 13);
            this.nomConcert.TabIndex = 1;
            this.nomConcert.Text = "Nom de l\'évènement :";
            // 
            // typeMeteo
            // 
            this.typeMeteo.AutoSize = true;
            this.typeMeteo.Location = new System.Drawing.Point(161, 67);
            this.typeMeteo.Name = "typeMeteo";
            this.typeMeteo.Size = new System.Drawing.Size(33, 13);
            this.typeMeteo.TabIndex = 2;
            this.typeMeteo.Text = "Ciel ?";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(603, 67);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(73, 13);
            this.Temperature.TabIndex = 3;
            this.Temperature.Text = "Température :";
            // 
            // frmRechConcerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 407);
            this.Controls.Add(this.tabConcert);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.lstSugestions);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.cbTypeRech);
            this.Name = "frmRechConcerts";
            this.Text = "frmRechConcerts";
            this.Load += new System.EventHandler(this.frmRechConcerts_Load);
            this.tabConcert.ResumeLayout(false);
            this.tabPageConcert.ResumeLayout(false);
            this.tabPageConcert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageMeteo.ResumeLayout(false);
            this.tabPageMeteo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMeteo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTypeRech;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.ListBox lstSugestions;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TabControl tabConcert;
        private System.Windows.Forms.TabPage tabPageConcert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstConcerts;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblArtiste;
        private System.Windows.Forms.Label lblConcert;
        private System.Windows.Forms.TabPage tabPageMeteo;
        private System.Windows.Forms.TabPage tabPageLocalisation;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label typeMeteo;
        private System.Windows.Forms.Label nomConcert;
        private System.Windows.Forms.PictureBox iconMeteo;
    }
}