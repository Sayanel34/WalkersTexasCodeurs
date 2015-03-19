namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    partial class FrmRechercheAlbums
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
            this.lblAlbumRecherche = new System.Windows.Forms.Label();
            this.grBoxAlbums = new System.Windows.Forms.GroupBox();
            this.lblTitresAlbums = new System.Windows.Forms.Label();
            this.lblAlbumsTrouves = new System.Windows.Forms.Label();
            this.wkbTitreSelectionne = new WebKit.WebKitBrowser();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.lblArtiste = new System.Windows.Forms.Label();
            this.lblTitreAlbum = new System.Windows.Forms.Label();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.txtAlbumsRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.grBoxAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlbumRecherche
            // 
            this.lblAlbumRecherche.AutoSize = true;
            this.lblAlbumRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumRecherche.ForeColor = System.Drawing.Color.White;
            this.lblAlbumRecherche.Location = new System.Drawing.Point(12, 28);
            this.lblAlbumRecherche.Name = "lblAlbumRecherche";
            this.lblAlbumRecherche.Size = new System.Drawing.Size(98, 13);
            this.lblAlbumRecherche.TabIndex = 0;
            this.lblAlbumRecherche.Text = "Album Recherché :";
            // 
            // grBoxAlbums
            // 
            this.grBoxAlbums.BackColor = System.Drawing.Color.White;
            this.grBoxAlbums.Controls.Add(this.lblTitresAlbums);
            this.grBoxAlbums.Controls.Add(this.lblAlbumsTrouves);
            this.grBoxAlbums.Controls.Add(this.wkbTitreSelectionne);
            this.grBoxAlbums.Controls.Add(this.btnEcouterExtraits);
            this.grBoxAlbums.Controls.Add(this.lklDeezerLien);
            this.grBoxAlbums.Controls.Add(this.lblArtiste);
            this.grBoxAlbums.Controls.Add(this.lblTitreAlbum);
            this.grBoxAlbums.Controls.Add(this.picArtiste);
            this.grBoxAlbums.Controls.Add(this.picCover);
            this.grBoxAlbums.Controls.Add(this.lstTitres);
            this.grBoxAlbums.Controls.Add(this.lstAlbums);
            this.grBoxAlbums.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grBoxAlbums.Location = new System.Drawing.Point(12, 79);
            this.grBoxAlbums.Name = "grBoxAlbums";
            this.grBoxAlbums.Size = new System.Drawing.Size(784, 384);
            this.grBoxAlbums.TabIndex = 1;
            this.grBoxAlbums.TabStop = false;
            this.grBoxAlbums.Text = "Informations DEEZER";
            this.grBoxAlbums.Visible = false;
            // 
            // lblTitresAlbums
            // 
            this.lblTitresAlbums.AutoSize = true;
            this.lblTitresAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitresAlbums.Location = new System.Drawing.Point(6, 239);
            this.lblTitresAlbums.Name = "lblTitresAlbums";
            this.lblTitresAlbums.Size = new System.Drawing.Size(108, 13);
            this.lblTitresAlbums.TabIndex = 10;
            this.lblTitresAlbums.Text = "Titres de l\'album :";
            // 
            // lblAlbumsTrouves
            // 
            this.lblAlbumsTrouves.AutoSize = true;
            this.lblAlbumsTrouves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumsTrouves.Location = new System.Drawing.Point(6, 36);
            this.lblAlbumsTrouves.Name = "lblAlbumsTrouves";
            this.lblAlbumsTrouves.Size = new System.Drawing.Size(101, 13);
            this.lblAlbumsTrouves.TabIndex = 9;
            this.lblAlbumsTrouves.Text = "Albums trouvés :";
            // 
            // wkbTitreSelectionne
            // 
            this.wkbTitreSelectionne.BackColor = System.Drawing.Color.White;
            this.wkbTitreSelectionne.Location = new System.Drawing.Point(299, 255);
            this.wkbTitreSelectionne.Name = "wkbTitreSelectionne";
            this.wkbTitreSelectionne.Size = new System.Drawing.Size(479, 123);
            this.wkbTitreSelectionne.TabIndex = 8;
            this.wkbTitreSelectionne.Url = null;
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.Location = new System.Drawing.Point(299, 209);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(280, 26);
            this.btnEcouterExtraits.TabIndex = 7;
            this.btnEcouterExtraits.Text = "Ecouter tous les extraits de l\'album...";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.btnEcouterExtraits_Click);
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Location = new System.Drawing.Point(296, 183);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(0, 13);
            this.lklDeezerLien.TabIndex = 6;
            // 
            // lblArtiste
            // 
            this.lblArtiste.AutoSize = true;
            this.lblArtiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtiste.Location = new System.Drawing.Point(423, 79);
            this.lblArtiste.Name = "lblArtiste";
            this.lblArtiste.Size = new System.Drawing.Size(0, 13);
            this.lblArtiste.TabIndex = 5;
            // 
            // lblTitreAlbum
            // 
            this.lblTitreAlbum.AutoSize = true;
            this.lblTitreAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAlbum.Location = new System.Drawing.Point(296, 36);
            this.lblTitreAlbum.Name = "lblTitreAlbum";
            this.lblTitreAlbum.Size = new System.Drawing.Size(0, 13);
            this.lblTitreAlbum.TabIndex = 4;
            // 
            // picArtiste
            // 
            this.picArtiste.Location = new System.Drawing.Point(426, 95);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(100, 85);
            this.picArtiste.TabIndex = 3;
            this.picArtiste.TabStop = false;
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(299, 62);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(100, 118);
            this.picCover.TabIndex = 2;
            this.picCover.TabStop = false;
            // 
            // lstTitres
            // 
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(6, 255);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(281, 121);
            this.lstTitres.TabIndex = 1;
            this.lstTitres.SelectedIndexChanged += new System.EventHandler(this.lstTitres_SelectedIndexChanged);
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.Location = new System.Drawing.Point(9, 62);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(278, 173);
            this.lstAlbums.TabIndex = 0;
            this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
            // 
            // txtAlbumsRecherche
            // 
            this.txtAlbumsRecherche.Location = new System.Drawing.Point(116, 25);
            this.txtAlbumsRecherche.Name = "txtAlbumsRecherche";
            this.txtAlbumsRecherche.Size = new System.Drawing.Size(164, 20);
            this.txtAlbumsRecherche.TabIndex = 2;
            this.txtAlbumsRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlbumsRecherche_KeyPress);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(320, 23);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Go !";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(90, 52);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 4;
            // 
            // FrmRechercheAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(808, 475);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtAlbumsRecherche);
            this.Controls.Add(this.grBoxAlbums);
            this.Controls.Add(this.lblAlbumRecherche);
            this.Name = "FrmRechercheAlbums";
            this.Text = "Recherche d\'Albums";
            this.Activated += new System.EventHandler(this.FrmRechercheAlbums_Activated);
            this.grBoxAlbums.ResumeLayout(false);
            this.grBoxAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlbumRecherche;
        private System.Windows.Forms.GroupBox grBoxAlbums;
        private WebKit.WebKitBrowser wkbTitreSelectionne;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label lblArtiste;
        private System.Windows.Forms.Label lblTitreAlbum;
        private System.Windows.Forms.PictureBox picArtiste;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.ListBox lstAlbums;
        private System.Windows.Forms.TextBox txtAlbumsRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblTitresAlbums;
        private System.Windows.Forms.Label lblAlbumsTrouves;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblMessage;
    }
}