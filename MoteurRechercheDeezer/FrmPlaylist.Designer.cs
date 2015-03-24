namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    partial class FrmPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlaylist));
            this.lstGauche = new System.Windows.Forms.ListBox();
            this.lstDroite = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVersDroiteUn = new System.Windows.Forms.Button();
            this.btnVersDroiteTous = new System.Windows.Forms.Button();
            this.btnVersGaucheUn = new System.Windows.Forms.Button();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.btnVersGaucheTous = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnLectureAleatoire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGauche
            // 
            this.lstGauche.FormattingEnabled = true;
            this.lstGauche.Location = new System.Drawing.Point(12, 29);
            this.lstGauche.Name = "lstGauche";
            this.lstGauche.Size = new System.Drawing.Size(234, 290);
            this.lstGauche.TabIndex = 0;
            this.lstGauche.SelectedIndexChanged += new System.EventHandler(this.lstGauche_SelectedIndexChanged);
            // 
            // lstDroite
            // 
            this.lstDroite.FormattingEnabled = true;
            this.lstDroite.Location = new System.Drawing.Point(333, 29);
            this.lstDroite.Name = "lstDroite";
            this.lstDroite.Size = new System.Drawing.Size(232, 238);
            this.lstDroite.TabIndex = 1;
            this.lstDroite.SelectedIndexChanged += new System.EventHandler(this.lstDroite_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Morceaux de l\'album :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Morceaux choisis (playlist) :";
            // 
            // btnVersDroiteUn
            // 
            this.btnVersDroiteUn.Location = new System.Drawing.Point(252, 69);
            this.btnVersDroiteUn.Name = "btnVersDroiteUn";
            this.btnVersDroiteUn.Size = new System.Drawing.Size(75, 23);
            this.btnVersDroiteUn.TabIndex = 4;
            this.btnVersDroiteUn.Text = "> Un";
            this.btnVersDroiteUn.UseVisualStyleBackColor = true;
            // 
            // btnVersDroiteTous
            // 
            this.btnVersDroiteTous.Location = new System.Drawing.Point(252, 98);
            this.btnVersDroiteTous.Name = "btnVersDroiteTous";
            this.btnVersDroiteTous.Size = new System.Drawing.Size(75, 23);
            this.btnVersDroiteTous.TabIndex = 5;
            this.btnVersDroiteTous.Text = ">> Tous";
            this.btnVersDroiteTous.UseVisualStyleBackColor = true;
            // 
            // btnVersGaucheUn
            // 
            this.btnVersGaucheUn.Location = new System.Drawing.Point(252, 189);
            this.btnVersGaucheUn.Name = "btnVersGaucheUn";
            this.btnVersGaucheUn.Size = new System.Drawing.Size(75, 23);
            this.btnVersGaucheUn.TabIndex = 6;
            this.btnVersGaucheUn.Text = "< Un";
            this.btnVersGaucheUn.UseVisualStyleBackColor = true;
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.Location = new System.Drawing.Point(333, 282);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(183, 37);
            this.btnEcouterExtraits.TabIndex = 7;
            this.btnEcouterExtraits.Text = "Jouer les extraits...";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.btnEcouterExtraits_Click);
            // 
            // btnVersGaucheTous
            // 
            this.btnVersGaucheTous.Location = new System.Drawing.Point(252, 218);
            this.btnVersGaucheTous.Name = "btnVersGaucheTous";
            this.btnVersGaucheTous.Size = new System.Drawing.Size(75, 23);
            this.btnVersGaucheTous.TabIndex = 8;
            this.btnVersGaucheTous.Text = "<< Tous";
            this.btnVersGaucheTous.UseVisualStyleBackColor = true;
            // 
            // erp
            // 
            this.erp.ContainerControl = this;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(253, 301);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 9;
            // 
            // btnLectureAleatoire
            // 
            this.btnLectureAleatoire.Image = ((System.Drawing.Image)(resources.GetObject("btnLectureAleatoire.Image")));
            this.btnLectureAleatoire.Location = new System.Drawing.Point(522, 283);
            this.btnLectureAleatoire.Name = "btnLectureAleatoire";
            this.btnLectureAleatoire.Size = new System.Drawing.Size(43, 36);
            this.btnLectureAleatoire.TabIndex = 10;
            this.btnLectureAleatoire.UseVisualStyleBackColor = true;
            this.btnLectureAleatoire.Click += new System.EventHandler(this.btnLectureAleatoire_Click);
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 327);
            this.Controls.Add(this.btnLectureAleatoire);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnVersGaucheTous);
            this.Controls.Add(this.btnEcouterExtraits);
            this.Controls.Add(this.btnVersGaucheUn);
            this.Controls.Add(this.btnVersDroiteTous);
            this.Controls.Add(this.btnVersDroiteUn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDroite);
            this.Controls.Add(this.lstGauche);
            this.Name = "FrmPlaylist";
            this.Text = "PLAYLIST des Extraits de l\'album ...";
            this.Load += new System.EventHandler(this.FrmPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDroite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVersDroiteUn;
        private System.Windows.Forms.Button btnVersDroiteTous;
        private System.Windows.Forms.Button btnVersGaucheUn;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.Button btnVersGaucheTous;
        public System.Windows.Forms.ListBox lstGauche;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnLectureAleatoire;
    }
}