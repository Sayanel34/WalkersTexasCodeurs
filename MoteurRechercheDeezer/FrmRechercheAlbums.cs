using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Btssio.Musique;
using Btssio.Deezer;
using Btssio.Tools;

namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    public partial class FrmRechercheAlbums : Form
    {

        #region Champs
        private Album selectedAlbum = new Album();
        private Track selectedTrack = new Track();
        private Album selectedAlbumDetails = new Album();
        private const string RECHERCHE_EN_COURS = "Recherche en cours, veuillez patienter...";
        private const string AUCUN_ALBUM = "Veuillez saisir un album à rechercher";
        private const string ALBUM_INCONNU = "Désolé, l'album '#valeur#' est inconnu sur Deezer...";
        private const string EXTRAITS_TROUVES = "Aucun extraits trouvés";
        private const string AUCUNE_PISTE = "Pistes indisponibles";
        private string message;
        #endregion

        #region Constructeur
        public FrmRechercheAlbums()
        {
            InitializeComponent();
        }

        private void FrmRechercheAlbums_Activated(object sender, EventArgs e)
        {
            txtAlbumsRecherche.Focus();
        }



        #endregion

        #region Recherche
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblMessage.Text = RECHERCHE_EN_COURS;
            lblMessage.Refresh();
            if (txtAlbumsRecherche.Text == string.Empty)
            {
                lblMessage.Text = AUCUN_ALBUM;
                erp.SetError(txtAlbumsRecherche, "Aucun artiste entré !");
            }

            else
            {
                rechercherAlbums();
            }



        }

        private void rechercherAlbums()
        {
            List<Album> lesAlbums = new List<Album>();
            string recherche = txtAlbumsRecherche.Text;
            lesAlbums = DeezerApi.getAllAlbumsByName(recherche);

            if (lesAlbums.Count == 0)
            {
                message = ALBUM_INCONNU.Replace("#valeur#", recherche);
                lblMessage.Text = message;
                erp.SetError(txtAlbumsRecherche, message);
            }

            else
            {
                erp.SetError(txtAlbumsRecherche, string.Empty);
                lstAlbums.SelectedIndexChanged -= new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
                lstAlbums.DataSource = lesAlbums;
                lstAlbums.DisplayMember = "name";
                lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
                lstAlbums_SelectedIndexChanged(lstAlbums, new EventArgs());

                grBoxAlbums.Visible = true;
                txtAlbumsRecherche.Text = string.Empty;
                lblMessage.Text = string.Empty;
            }




        }

        private void txtAlbumsRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRechercher.PerformClick();
        }

        #endregion

        #region Listbox
        private void lstAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAlbum = (Album)lstAlbums.SelectedItem;
            selectedAlbum = DeezerApi.getDetailsAlbumById(selectedAlbum.id);

            lblTitreAlbum.Text = selectedAlbum.title;
            picCover.ImageLocation = selectedAlbum.cover;
            lklDeezerLien.Text = selectedAlbum.link;

            Artist monArtiste = new Artist();
            monArtiste = selectedAlbum.theArtist;
            lblArtiste.Text = monArtiste.name;
            picArtiste.ImageLocation = monArtiste.picture;

            List<Track> lesTracks = new List<Track>();
            lesTracks = selectedAlbum.getLesTracks();

            if (selectedAlbum.getLesTracks() == null)
            {
                message = AUCUNE_PISTE;
                lblMessage.Text = message;
                erp.SetError(lstAlbums, message);
            }

            else
            {
                lstTitres.SelectedIndexChanged -= new System.EventHandler(this.lstTitres_SelectedIndexChanged);
                lstTitres.DataSource = lesTracks;
                lstTitres.DisplayMember = "title";
                lstTitres.SelectedIndexChanged += new System.EventHandler(this.lstTitres_SelectedIndexChanged);
                lstTitres_SelectedIndexChanged(lstTitres, new EventArgs());
            }

        }

        private void lstTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTrack = (Track)lstTitres.SelectedItem;
            string urlWidget = DeezerPlugin.getUrlPluginTrack(selectedTrack.id);
            wkbTitreSelectionne.Navigate(urlWidget);
        }
        #endregion

        #region Autres
        private void btnEcouterExtraits_Click(object sender, EventArgs e)
        {

            
            selectedAlbumDetails = DeezerApi.getDetailsAlbumById(selectedAlbum.id);

            if (selectedAlbumDetails == null)
            {
                lblMessage.Text = EXTRAITS_TROUVES;
                erp.SetError(btnEcouterExtraits, EXTRAITS_TROUVES);

            }

            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                List<Track> lesTracks = selectedAlbumDetails.getLesTracks();

                foreach (Track unTrack in lesTracks)
                {
                    WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                    formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                }
                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();
            }
            
        }
        #endregion

        }
    }

