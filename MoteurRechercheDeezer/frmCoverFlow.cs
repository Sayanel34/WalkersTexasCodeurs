using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Tools;
using Btssio.Deezer;
using Btssio.Musique;
using CDI.IndexCard3D;

namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    public partial class frmCoverFlow : Form
    {
        #region Champs
        private List<Album> lesAlbums = new List<Album>();
        private List<Track> lesTracks = new List<Track>();
        public Artist selectedArtistDetails = new Artist();

        #endregion

        #region Constructeur
        public frmCoverFlow()
        {
            InitializeComponent();
        }

        private void frmCoverFlow_Load(object sender, EventArgs e)
        {
            lesAlbums = selectedArtistDetails.getLesAlbums();

            WebClient wClient = new WebClient();
            string nomImage;
            int i;

            for (i = 0; i < lesAlbums.Count; i++)
            {
                nomImage = "image" + i + ".jpg";
                wClient.DownloadFile(lesAlbums[i].cover, nomImage);
                Card c = new Card(lesAlbums[i].title, nomImage);
                ICD3.IndexCards.Add(c);
            }

            ICD3.IndexCards.LoadTexturesToMemory();
            chargerTitresSelectedAlbum();

        }
        #endregion

        #region Affichage
        private void ICD3_RenderText(object sender, EventArgs e)
        {
            Font fntNom = new Font("Arial", 30, FontStyle.Regular, GraphicsUnit.Pixel);
            Font fntTitre = new Font("Arial", 20, FontStyle.Italic, GraphicsUnit.Pixel);

            string titre = ICD3.IndexCards.ElementAt(ICD3.ActiveCard - 1).Title;

            ICD3.DrawText(0, ICD3.Height - 75, selectedArtistDetails.name, IC3D.TextAlignment.Center, fntNom, Color.FloralWhite);
            ICD3.DrawText(0, ICD3.Height - 45, titre, IC3D.TextAlignment.Center, fntTitre, Color.Wheat);
        }
        private void ICD3_IndexCardChanged(object sender, IndexCardEventArgs e)
        {
            chargerTitresSelectedAlbum();
        }
        private void lblXsurY_MouseHover(object sender, EventArgs e)
        {
            panListeTitres.Visible = true;
        }

        private void lstTitres_MouseLeave(object sender, EventArgs e)
        {
            panListeTitres.Visible = false;
        }
        #endregion

        #region ListBox
        private void chargerTitresSelectedAlbum()
        {
            int indexTitre = 1;
            Album selectedAlbum = lesAlbums.ElementAt(ICD3.ActiveCard - 1);

            lesTracks = selectedAlbum.getLesTracks();
            this.wmpLecteur.currentPlaylist.clear();
            this.wmpLecteur.CurrentItemChange -= new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpLecteur_CurrentItemChange);
            foreach (Track unTrack in lesTracks)
            {

                WMPLib.IWMPMedia unMedia = this.wmpLecteur.newMedia(unTrack.preview);
                unMedia.setItemInfo("nomTitre", unTrack.title);
                unMedia.setItemInfo("xSurY", indexTitre.ToString());
                indexTitre++;
                
                this.wmpLecteur.currentPlaylist.appendItem(unMedia);
                
            }
            this.wmpLecteur.CurrentItemChange += new AxWMPLib._WMPOCXEvents_CurrentItemChangeEventHandler(this.wmpLecteur_CurrentItemChange);
            lstTitres.DataSource = lesTracks;
            lstTitres.DisplayMember = "title";
        }

        private void wmpLecteur_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            lblTitre.Text = wmpLecteur.currentMedia.getItemInfo("nomTitre");
            lblXsurY.Text = wmpLecteur.currentMedia.getItemInfo("xSurY");
            lstTitres.SelectedIndex = Convert.ToInt32(lblXsurY.Text) - 1;
        }
        private void lstTitres_Click(object sender, EventArgs e)
        {
            WMPLib.IWMPMedia unMedia = wmpLecteur.currentPlaylist.get_Item(lstTitres.SelectedIndex);
            wmpLecteur.Ctlcontrols.playItem(unMedia);
        }
        #endregion
    }
}
