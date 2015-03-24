namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    partial class frmCoverFlow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoverFlow));
            this.ICD3 = new CDI.IndexCard3D.IC3D();
            this.lblXsurY = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.wmpLecteur = new AxWMPLib.AxWindowsMediaPlayer();
            this.panListeTitres = new System.Windows.Forms.Panel();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.lblTitres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).BeginInit();
            this.panListeTitres.SuspendLayout();
            this.SuspendLayout();
            // 
            // ICD3
            // 
            this.ICD3.DisplayCards = 8;
            this.ICD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICD3.Location = new System.Drawing.Point(0, -100);
            this.ICD3.Name = "ICD3";
            this.ICD3.Size = new System.Drawing.Size(598, 390);
            this.ICD3.TabIndex = 0;
            this.ICD3.RenderText += new CDI.IndexCard3D.IC3D.RenderTextHander(this.ICD3_RenderText);
            this.ICD3.IndexCardChanged += new CDI.IndexCard3D.IC3D.IndexCardChangedHander(this.ICD3_IndexCardChanged);
            // 
            // lblXsurY
            // 
            this.lblXsurY.AutoSize = true;
            this.lblXsurY.Location = new System.Drawing.Point(531, 275);
            this.lblXsurY.Name = "lblXsurY";
            this.lblXsurY.Size = new System.Drawing.Size(41, 13);
            this.lblXsurY.TabIndex = 1;
            this.lblXsurY.Text = "X sur Y";
            this.lblXsurY.MouseHover += new System.EventHandler(this.lblXsurY_MouseHover);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitre.Location = new System.Drawing.Point(9, 275);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(33, 13);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Titre";
            // 
            // wmpLecteur
            // 
            this.wmpLecteur.Enabled = true;
            this.wmpLecteur.Location = new System.Drawing.Point(-2, 305);
            this.wmpLecteur.Name = "wmpLecteur";
            this.wmpLecteur.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpLecteur.OcxState")));
            this.wmpLecteur.Size = new System.Drawing.Size(609, 45);
            this.wmpLecteur.TabIndex = 3;
            this.wmpLecteur.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpLecteur_CurrentItemChange);
            // 
            // panListeTitres
            // 
            this.panListeTitres.Controls.Add(this.lblTitres);
            this.panListeTitres.Controls.Add(this.lstTitres);
            this.panListeTitres.Location = new System.Drawing.Point(448, 3);
            this.panListeTitres.Name = "panListeTitres";
            this.panListeTitres.Size = new System.Drawing.Size(148, 269);
            this.panListeTitres.TabIndex = 4;
            this.panListeTitres.Visible = false;
            // 
            // lstTitres
            // 
            this.lstTitres.ForeColor = System.Drawing.Color.SteelBlue;
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(3, 28);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(142, 238);
            this.lstTitres.TabIndex = 0;
            this.lstTitres.Click += new System.EventHandler(this.lstTitres_Click);
            this.lstTitres.MouseLeave += new System.EventHandler(this.lstTitres_MouseLeave);
            // 
            // lblTitres
            // 
            this.lblTitres.AutoSize = true;
            this.lblTitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitres.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitres.Location = new System.Drawing.Point(23, 6);
            this.lblTitres.Name = "lblTitres";
            this.lblTitres.Size = new System.Drawing.Size(101, 13);
            this.lblTitres.TabIndex = 5;
            this.lblTitres.Text = "Titres de l\'Album";
            // 
            // frmCoverFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 362);
            this.Controls.Add(this.panListeTitres);
            this.Controls.Add(this.wmpLecteur);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblXsurY);
            this.Controls.Add(this.ICD3);
            this.Name = "frmCoverFlow";
            this.Text = "frmCoverFlow";
            this.Load += new System.EventHandler(this.frmCoverFlow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpLecteur)).EndInit();
            this.panListeTitres.ResumeLayout(false);
            this.panListeTitres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDI.IndexCard3D.IC3D ICD3;
        private System.Windows.Forms.Label lblXsurY;
        private System.Windows.Forms.Label lblTitre;
        private AxWMPLib.AxWindowsMediaPlayer wmpLecteur;
        private System.Windows.Forms.Panel panListeTitres;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Label lblTitres;
    }
}