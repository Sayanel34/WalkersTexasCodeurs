namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    partial class FrmDemarrage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDemarrage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecteurMultimédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recherchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheDAlbumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aproposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBanniere = new System.Windows.Forms.PictureBox();
            this.picDeezer = new System.Windows.Forms.PictureBox();
            this.lblArtisteRecherche = new System.Windows.Forms.Label();
            this.txtArtisteRecherche = new System.Windows.Forms.TextBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.tbc = new System.Windows.Forms.TabControl();
            this.tbpArtiste = new System.Windows.Forms.TabPage();
            this.grbArtisteInfos = new System.Windows.Forms.GroupBox();
            this.picIpod = new System.Windows.Forms.PictureBox();
            this.btnEcouterExtraits = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstArtistes = new System.Windows.Forms.ListBox();
            this.lklDeezerLien = new System.Windows.Forms.LinkLabel();
            this.lblArtisteNom = new System.Windows.Forms.Label();
            this.picArtiste = new System.Windows.Forms.PictureBox();
            this.tbpDiscographie = new System.Windows.Forms.TabPage();
            this.panelDisco = new System.Windows.Forms.Panel();
            this.wkbDisco = new WebKit.WebKitBrowser();
            this.webKitBrowser1 = new WebKit.WebKitBrowser();
            this.lstTitres = new System.Windows.Forms.ListBox();
            this.lblTitres = new System.Windows.Forms.Label();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.lblAlbums = new System.Windows.Forms.Label();
            this.picArtisteDisco = new System.Windows.Forms.PictureBox();
            this.tbpRadio = new System.Windows.Forms.TabPage();
            this.wkbRadio = new WebKit.WebKitBrowser();
            this.lblMessage = new System.Windows.Forms.Label();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipAppli = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIconEtat = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMasquer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).BeginInit();
            this.tbc.SuspendLayout();
            this.tbpArtiste.SuspendLayout();
            this.grbArtisteInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).BeginInit();
            this.tbpDiscographie.SuspendLayout();
            this.panelDisco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtisteDisco)).BeginInit();
            this.tbpRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.contextMenuStripNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.outilsToolStripMenuItem,
            this.recherchesToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecteurMultimédiaToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "&Outils";
            // 
            // lecteurMultimédiaToolStripMenuItem
            // 
            this.lecteurMultimédiaToolStripMenuItem.Name = "lecteurMultimédiaToolStripMenuItem";
            this.lecteurMultimédiaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lecteurMultimédiaToolStripMenuItem.Text = "&Lecteur Multimédia";
            this.lecteurMultimédiaToolStripMenuItem.Click += new System.EventHandler(this.lecteurMultimédiaToolStripMenuItem_Click);
            // 
            // recherchesToolStripMenuItem
            // 
            this.recherchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercheDAlbumsToolStripMenuItem});
            this.recherchesToolStripMenuItem.Name = "recherchesToolStripMenuItem";
            this.recherchesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.recherchesToolStripMenuItem.Text = "&Recherches";
            // 
            // rechercheDAlbumsToolStripMenuItem
            // 
            this.rechercheDAlbumsToolStripMenuItem.Name = "rechercheDAlbumsToolStripMenuItem";
            this.rechercheDAlbumsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.rechercheDAlbumsToolStripMenuItem.Text = "Recherche d\'&Albums";
            this.rechercheDAlbumsToolStripMenuItem.Click += new System.EventHandler(this.rechercheDAlbumsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aproposToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            // 
            // aproposToolStripMenuItem
            // 
            this.aproposToolStripMenuItem.Name = "aproposToolStripMenuItem";
            this.aproposToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aproposToolStripMenuItem.Text = "A &propos...";
            this.aproposToolStripMenuItem.Click += new System.EventHandler(this.aproposToolStripMenuItem_Click);
            // 
            // picBanniere
            // 
            this.picBanniere.Image = ((System.Drawing.Image)(resources.GetObject("picBanniere.Image")));
            this.picBanniere.Location = new System.Drawing.Point(57, 27);
            this.picBanniere.Name = "picBanniere";
            this.picBanniere.Size = new System.Drawing.Size(575, 65);
            this.picBanniere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBanniere.TabIndex = 1;
            this.picBanniere.TabStop = false;
            // 
            // picDeezer
            // 
            this.picDeezer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDeezer.Image = ((System.Drawing.Image)(resources.GetObject("picDeezer.Image")));
            this.picDeezer.Location = new System.Drawing.Point(513, 125);
            this.picDeezer.Name = "picDeezer";
            this.picDeezer.Size = new System.Drawing.Size(119, 53);
            this.picDeezer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDeezer.TabIndex = 2;
            this.picDeezer.TabStop = false;
            this.picDeezer.Click += new System.EventHandler(this.picDeezer_Click);
            // 
            // lblArtisteRecherche
            // 
            this.lblArtisteRecherche.AutoSize = true;
            this.lblArtisteRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.lblArtisteRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteRecherche.ForeColor = System.Drawing.Color.White;
            this.lblArtisteRecherche.Location = new System.Drawing.Point(22, 145);
            this.lblArtisteRecherche.Name = "lblArtisteRecherche";
            this.lblArtisteRecherche.Size = new System.Drawing.Size(93, 13);
            this.lblArtisteRecherche.TabIndex = 3;
            this.lblArtisteRecherche.Text = "Artiste recherché :";
            // 
            // txtArtisteRecherche
            // 
            this.txtArtisteRecherche.Location = new System.Drawing.Point(121, 142);
            this.txtArtisteRecherche.Name = "txtArtisteRecherche";
            this.txtArtisteRecherche.Size = new System.Drawing.Size(161, 20);
            this.txtArtisteRecherche.TabIndex = 4;
            this.txtArtisteRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArtisteRecherche_KeyPress);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Location = new System.Drawing.Point(305, 142);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(78, 20);
            this.btnRecherche.TabIndex = 5;
            this.btnRecherche.Text = "Go !";
            this.btnRecherche.UseVisualStyleBackColor = true;
            this.btnRecherche.Click += new System.EventHandler(this.btnRecherche_Click);
            // 
            // tbc
            // 
            this.tbc.AccessibleName = "";
            this.tbc.Controls.Add(this.tbpArtiste);
            this.tbc.Controls.Add(this.tbpDiscographie);
            this.tbc.Controls.Add(this.tbpRadio);
            this.tbc.Location = new System.Drawing.Point(25, 197);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(664, 228);
            this.tbc.TabIndex = 6;
            this.tbc.Tag = "";
            // 
            // tbpArtiste
            // 
            this.tbpArtiste.Controls.Add(this.grbArtisteInfos);
            this.tbpArtiste.Location = new System.Drawing.Point(4, 22);
            this.tbpArtiste.Name = "tbpArtiste";
            this.tbpArtiste.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArtiste.Size = new System.Drawing.Size(656, 202);
            this.tbpArtiste.TabIndex = 0;
            this.tbpArtiste.Text = "Infos Artiste";
            this.tbpArtiste.UseVisualStyleBackColor = true;
            // 
            // grbArtisteInfos
            // 
            this.grbArtisteInfos.Controls.Add(this.picIpod);
            this.grbArtisteInfos.Controls.Add(this.btnEcouterExtraits);
            this.grbArtisteInfos.Controls.Add(this.label1);
            this.grbArtisteInfos.Controls.Add(this.lstArtistes);
            this.grbArtisteInfos.Controls.Add(this.lklDeezerLien);
            this.grbArtisteInfos.Controls.Add(this.lblArtisteNom);
            this.grbArtisteInfos.Controls.Add(this.picArtiste);
            this.grbArtisteInfos.Location = new System.Drawing.Point(6, 6);
            this.grbArtisteInfos.Name = "grbArtisteInfos";
            this.grbArtisteInfos.Size = new System.Drawing.Size(542, 193);
            this.grbArtisteInfos.TabIndex = 0;
            this.grbArtisteInfos.TabStop = false;
            this.grbArtisteInfos.Text = "Informations DEEZER";
            this.grbArtisteInfos.Visible = false;
            // 
            // picIpod
            // 
            this.picIpod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.erp.SetIconAlignment(this.picIpod, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.picIpod.Image = ((System.Drawing.Image)(resources.GetObject("picIpod.Image")));
            this.picIpod.Location = new System.Drawing.Point(154, 152);
            this.picIpod.Name = "picIpod";
            this.picIpod.Size = new System.Drawing.Size(72, 38);
            this.picIpod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIpod.TabIndex = 10;
            this.picIpod.TabStop = false;
            this.toolTipAppli.SetToolTip(this.picIpod, "Accès au COVER FLOW (type Ipod)");
            this.picIpod.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEcouterExtraits
            // 
            this.btnEcouterExtraits.Location = new System.Drawing.Point(9, 156);
            this.btnEcouterExtraits.Name = "btnEcouterExtraits";
            this.btnEcouterExtraits.Size = new System.Drawing.Size(139, 23);
            this.btnEcouterExtraits.TabIndex = 9;
            this.btnEcouterExtraits.Text = "&Ecouter tous les extraits...";
            this.btnEcouterExtraits.UseVisualStyleBackColor = true;
            this.btnEcouterExtraits.Click += new System.EventHandler(this.btnEcouterExtraits_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Artistes trouvés :";
            // 
            // lstArtistes
            // 
            this.lstArtistes.FormattingEnabled = true;
            this.lstArtistes.Location = new System.Drawing.Point(6, 38);
            this.lstArtistes.Name = "lstArtistes";
            this.lstArtistes.Size = new System.Drawing.Size(187, 108);
            this.lstArtistes.TabIndex = 7;
            this.lstArtistes.SelectedIndexChanged += new System.EventHandler(this.lstArtistes_SelectedIndexChanged_1);
            // 
            // lklDeezerLien
            // 
            this.lklDeezerLien.AutoSize = true;
            this.lklDeezerLien.Location = new System.Drawing.Point(232, 169);
            this.lklDeezerLien.Name = "lklDeezerLien";
            this.lklDeezerLien.Size = new System.Drawing.Size(74, 13);
            this.lklDeezerLien.TabIndex = 4;
            this.lklDeezerLien.TabStop = true;
            this.lklDeezerLien.Text = "Lien DEEZER";
            this.lklDeezerLien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklDeezerLien_LinkClicked);
            // 
            // lblArtisteNom
            // 
            this.lblArtisteNom.AutoSize = true;
            this.lblArtisteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtisteNom.Location = new System.Drawing.Point(232, 10);
            this.lblArtisteNom.Name = "lblArtisteNom";
            this.lblArtisteNom.Size = new System.Drawing.Size(59, 25);
            this.lblArtisteNom.TabIndex = 2;
            this.lblArtisteNom.Text = "Nom";
            // 
            // picArtiste
            // 
            this.picArtiste.InitialImage = ((System.Drawing.Image)(resources.GetObject("picArtiste.InitialImage")));
            this.picArtiste.Location = new System.Drawing.Point(235, 38);
            this.picArtiste.Name = "picArtiste";
            this.picArtiste.Size = new System.Drawing.Size(113, 128);
            this.picArtiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtiste.TabIndex = 0;
            this.picArtiste.TabStop = false;
            // 
            // tbpDiscographie
            // 
            this.tbpDiscographie.Controls.Add(this.panelDisco);
            this.tbpDiscographie.Location = new System.Drawing.Point(4, 22);
            this.tbpDiscographie.Name = "tbpDiscographie";
            this.tbpDiscographie.Size = new System.Drawing.Size(656, 202);
            this.tbpDiscographie.TabIndex = 2;
            this.tbpDiscographie.Text = "Discographie";
            this.tbpDiscographie.UseVisualStyleBackColor = true;
            // 
            // panelDisco
            // 
            this.panelDisco.Controls.Add(this.wkbDisco);
            this.panelDisco.Controls.Add(this.webKitBrowser1);
            this.panelDisco.Controls.Add(this.lstTitres);
            this.panelDisco.Controls.Add(this.lblTitres);
            this.panelDisco.Controls.Add(this.lstAlbums);
            this.panelDisco.Controls.Add(this.lblAlbums);
            this.panelDisco.Controls.Add(this.picArtisteDisco);
            this.panelDisco.Location = new System.Drawing.Point(3, 3);
            this.panelDisco.Name = "panelDisco";
            this.panelDisco.Size = new System.Drawing.Size(650, 199);
            this.panelDisco.TabIndex = 0;
            this.panelDisco.Visible = false;
            // 
            // wkbDisco
            // 
            this.wkbDisco.BackColor = System.Drawing.Color.White;
            this.wkbDisco.Location = new System.Drawing.Point(3, 121);
            this.wkbDisco.Name = "wkbDisco";
            this.wkbDisco.Size = new System.Drawing.Size(644, 75);
            this.wkbDisco.TabIndex = 1;
            this.wkbDisco.Url = null;
            // 
            // webKitBrowser1
            // 
            this.webKitBrowser1.BackColor = System.Drawing.Color.White;
            this.webKitBrowser1.Location = new System.Drawing.Point(-70, 150);
            this.webKitBrowser1.Name = "webKitBrowser1";
            this.webKitBrowser1.Size = new System.Drawing.Size(319, 255);
            this.webKitBrowser1.TabIndex = 5;
            this.webKitBrowser1.Url = null;
            // 
            // lstTitres
            // 
            this.lstTitres.FormattingEnabled = true;
            this.lstTitres.Location = new System.Drawing.Point(341, 20);
            this.lstTitres.Name = "lstTitres";
            this.lstTitres.Size = new System.Drawing.Size(204, 95);
            this.lstTitres.TabIndex = 4;
            this.lstTitres.SelectedIndexChanged += new System.EventHandler(this.lstTitres_SelectedIndexChanged);
            // 
            // lblTitres
            // 
            this.lblTitres.AutoSize = true;
            this.lblTitres.Location = new System.Drawing.Point(338, 3);
            this.lblTitres.Name = "lblTitres";
            this.lblTitres.Size = new System.Drawing.Size(39, 13);
            this.lblTitres.TabIndex = 3;
            this.lblTitres.Text = "Titres :";
            // 
            // lstAlbums
            // 
            this.lstAlbums.FormattingEnabled = true;
            this.lstAlbums.Location = new System.Drawing.Point(125, 19);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(199, 95);
            this.lstAlbums.TabIndex = 2;
            this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
            this.lstAlbums.DoubleClick += new System.EventHandler(this.lstAlbums_DoubleClick);
            // 
            // lblAlbums
            // 
            this.lblAlbums.AutoSize = true;
            this.lblAlbums.Location = new System.Drawing.Point(122, 3);
            this.lblAlbums.Name = "lblAlbums";
            this.lblAlbums.Size = new System.Drawing.Size(47, 13);
            this.lblAlbums.TabIndex = 1;
            this.lblAlbums.Text = "Albums :";
            // 
            // picArtisteDisco
            // 
            this.picArtisteDisco.Location = new System.Drawing.Point(3, 3);
            this.picArtisteDisco.Name = "picArtisteDisco";
            this.picArtisteDisco.Size = new System.Drawing.Size(113, 96);
            this.picArtisteDisco.TabIndex = 0;
            this.picArtisteDisco.TabStop = false;
            // 
            // tbpRadio
            // 
            this.tbpRadio.Controls.Add(this.wkbRadio);
            this.tbpRadio.Location = new System.Drawing.Point(4, 22);
            this.tbpRadio.Name = "tbpRadio";
            this.tbpRadio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRadio.Size = new System.Drawing.Size(656, 202);
            this.tbpRadio.TabIndex = 1;
            this.tbpRadio.Text = "Radio Artiste";
            this.tbpRadio.UseVisualStyleBackColor = true;
            // 
            // wkbRadio
            // 
            this.wkbRadio.BackColor = System.Drawing.Color.White;
            this.wkbRadio.Location = new System.Drawing.Point(6, 6);
            this.wkbRadio.Name = "wkbRadio";
            this.wkbRadio.Size = new System.Drawing.Size(542, 185);
            this.wkbRadio.TabIndex = 0;
            this.wkbRadio.Url = null;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMessage.Location = new System.Drawing.Point(118, 165);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // erp
            // 
            this.erp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.erp.ContainerControl = this;
            // 
            // toolTipAppli
            // 
            this.toolTipAppli.IsBalloon = true;
            this.toolTipAppli.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAppli.ToolTipTitle = "Pour Info :";
            // 
            // notifyIconEtat
            // 
            this.notifyIconEtat.ContextMenuStrip = this.contextMenuStripNotifications;
            this.notifyIconEtat.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconEtat.Icon")));
            this.notifyIconEtat.Text = "ZiK\'nCo - Moteur de recherche DEEZER";
            this.notifyIconEtat.Visible = true;
            // 
            // contextMenuStripNotifications
            // 
            this.contextMenuStripNotifications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripOuvrir,
            this.menuStripMasquer,
            this.toolStripSeparator1,
            this.menuStripQuitter});
            this.contextMenuStripNotifications.Name = "contextMenuStripNotifications";
            this.contextMenuStripNotifications.Size = new System.Drawing.Size(166, 98);
            // 
            // menuStripOuvrir
            // 
            this.menuStripOuvrir.Image = ((System.Drawing.Image)(resources.GetObject("menuStripOuvrir.Image")));
            this.menuStripOuvrir.Name = "menuStripOuvrir";
            this.menuStripOuvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuStripOuvrir.Size = new System.Drawing.Size(165, 22);
            this.menuStripOuvrir.Text = "Ouvrir";
            this.menuStripOuvrir.Click += new System.EventHandler(this.menuStripOuvrir_Click);
            // 
            // menuStripMasquer
            // 
            this.menuStripMasquer.Image = ((System.Drawing.Image)(resources.GetObject("menuStripMasquer.Image")));
            this.menuStripMasquer.Name = "menuStripMasquer";
            this.menuStripMasquer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menuStripMasquer.Size = new System.Drawing.Size(165, 22);
            this.menuStripMasquer.Text = "Masquer";
            this.menuStripMasquer.Click += new System.EventHandler(this.menuStripMasquer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // menuStripQuitter
            // 
            this.menuStripQuitter.Image = ((System.Drawing.Image)(resources.GetObject("menuStripQuitter.Image")));
            this.menuStripQuitter.Name = "menuStripQuitter";
            this.menuStripQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuStripQuitter.Size = new System.Drawing.Size(165, 22);
            this.menuStripQuitter.Text = "Quitter";
            this.menuStripQuitter.Click += new System.EventHandler(this.menuStripQuitter_Click);
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(701, 437);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.txtArtisteRecherche);
            this.Controls.Add(this.lblArtisteRecherche);
            this.Controls.Add(this.picDeezer);
            this.Controls.Add(this.picBanniere);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmDemarrage";
            this.Text = "Moteur de recherche Deezeer : Version 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDemarrage_FormClosing);
            this.Load += new System.EventHandler(this.FrmDemarrage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanniere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeezer)).EndInit();
            this.tbc.ResumeLayout(false);
            this.tbpArtiste.ResumeLayout(false);
            this.grbArtisteInfos.ResumeLayout(false);
            this.grbArtisteInfos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIpod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtiste)).EndInit();
            this.tbpDiscographie.ResumeLayout(false);
            this.panelDisco.ResumeLayout(false);
            this.panelDisco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtisteDisco)).EndInit();
            this.tbpRadio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.contextMenuStripNotifications.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecteurMultimédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aproposToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBanniere;
        private System.Windows.Forms.PictureBox picDeezer;
        private System.Windows.Forms.Label lblArtisteRecherche;
        private System.Windows.Forms.TextBox txtArtisteRecherche;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.TabPage tbpArtiste;
        private System.Windows.Forms.TabPage tbpRadio;
        private System.Windows.Forms.GroupBox grbArtisteInfos;
        private System.Windows.Forms.LinkLabel lklDeezerLien;
        private System.Windows.Forms.Label lblArtisteNom;
        private System.Windows.Forms.PictureBox picArtiste;
        private WebKit.WebKitBrowser wkbRadio;
        private System.Windows.Forms.ListBox lstArtistes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEcouterExtraits;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.TabPage tbpDiscographie;
        private WebKit.WebKitBrowser wkbDisco;
        private System.Windows.Forms.Panel panelDisco;
        private System.Windows.Forms.ListBox lstTitres;
        private System.Windows.Forms.Label lblTitres;
        private System.Windows.Forms.ListBox lstAlbums;
        private System.Windows.Forms.Label lblAlbums;
        private System.Windows.Forms.PictureBox picArtisteDisco;
        private WebKit.WebKitBrowser webKitBrowser1;
        private System.Windows.Forms.ToolStripMenuItem recherchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheDAlbumsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picIpod;
        private System.Windows.Forms.ToolTip toolTipAppli;
        private System.Windows.Forms.NotifyIcon notifyIconEtat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifications;
        private System.Windows.Forms.ToolStripMenuItem menuStripOuvrir;
        private System.Windows.Forms.ToolStripMenuItem menuStripMasquer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuStripQuitter;
    }
}

