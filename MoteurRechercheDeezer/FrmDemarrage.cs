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
using Btssio.Tools;
using Btssio.Deezer;
using Btssio.Musique;


namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    public partial class FrmDemarrage : Form
    {
        FrmPlaylist formulaire = new FrmPlaylist();
        #region Champs
        private Artist selectedArtist = new Artist();
        private Artist selectedArtistDetails = new Artist();
        private Album selectedAlbum = new Album();
        private Track selectedTrack = new Track();
        private const string RECHERCHE_EN_COURS = "Recherche en cours, veuillez patienter...";
        private const string AUCUN_ARTISTE = "Veuillez saisir un artiste à rechercher";
        private const string ARTISTE_INCONNU = "Désolé, l'artiste '#valeur#' est inconnu sur Deezer...";
        private const string EXTRAITS_TROUVES = "Aucun extraits trouvés";
        private const string AUCUNE_DISCOGRAPHIE = "Discographie indisponible";
        private const string TITRE_CONNEXION_INTERNET = "Connexion Internet inactive !";
        private const string MESSAGE_CONNEXION_INTERNET = "La recherche sur le site DEEZER est impossible...";
        private string message;
        private bool isConnected;

        
        #endregion
        //Contient les objets et constantes nécessaires pour l'appli

        #region Constructeurs
        public FrmDemarrage()
        {
            InitializeComponent();  
        }


        private void FrmDemarrage_Load(object sender, EventArgs e)
        {
            if (!NetManager.isConnected()) //Test de la connexion
            {
                
                if ((MessageBox.Show("L'application ne peut fonctionner sans connection internet", "Attention !", MessageBoxButtons.OK) == DialogResult.OK))
                {
                    isConnected = false; //S'il n'y a pas de connection, on affiche un message d'erreur et l'application se ferme

                    Application.Exit();
                }

            }
            else
            {
                isConnected = true;
                txtArtisteRecherche.Focus();//Cette variable boléenne servira pour la confirmation de fermeture
                notifyIconEtat.ShowBalloonTip(10000, "Bienvenue " + Environment.UserName, "Appli ZiK'nCo.DEEZER lancée le " + DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("HH:mm:ss"), ToolTipIcon.Info);
            }



        }

        private void FrmDemarrage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected == true)
            {
                if (MessageBox.Show("Etes-vous sûr de vouloir quitter ?", "ZiK'nCo : question",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
            //Si la variable boléenne est vraie (donc si la connexion existe) on implante un
            //message de confirmation lors de la fermeture de l'application, peu importe le moyen utilisé

        }

        #endregion 
        //Contient les méthodes concernant le formulaire

        #region Recherche
        private void txtArtisteRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) btnRecherche.PerformClick();
            //Permet de lancer la recherche par appui du bouton entrée
        }
        private void btnRecherche_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblMessage.Text = RECHERCHE_EN_COURS;
            lblMessage.Refresh();
            //Lorsque la recherche est lancée, on change la forme du curseur
            //On attribue au message d'attente la constante appropriée
            //On rafraichit le message pour qu'il prenne effectivement la valeur voulue

            if (!NetManager.isConnected()) //Test de la connexion
            {
                System.Media.SystemSounds.Exclamation.Play();
                notifyIconEtat.ShowBalloonTip(10000, TITRE_CONNEXION_INTERNET, MESSAGE_CONNEXION_INTERNET, ToolTipIcon.Error);
            }

            else
            {



                if (txtArtisteRecherche.Text == string.Empty)
                {
                    lblMessage.Text = AUCUN_ARTISTE;
                    erp.SetError(txtArtisteRecherche, "Aucun artiste entré !");
                    //Si le champs de recherche est vide, on en averti l'utilisateur
                }

                else
                    rechercherArtistes();
                //Sinon on effectue la recherche


            }
        }

        private void rechercherArtistes()
        {
            List<Artist> lesArtistes = new List<Artist>();
            string recherche = txtArtisteRecherche.Text;
            lesArtistes = DeezerApi.getAllArtistsByName(recherche);

            //On initialise la liste d'artistes
            //On attribue à la variable recherche le text contenue dans la barre de recherche
            //On demande à Deezer les artistes ayant le nom plus ou moins semblable à la variable recherche



            if (lesArtistes.Count == 0)
            {
                message = ARTISTE_INCONNU.Replace("#valeur#", recherche);
                lblMessage.Text = message;
                erp.SetError(txtArtisteRecherche, message);
                // Si Deezer ne trouve aucun artiste
                //On averti l'utilisateur qu'on ne trouve rien pour ce qu'il a renseigné
            }

            else
            {
                //Sinon
                erp.SetError(txtArtisteRecherche, string.Empty); //On enlève ce qu'il y a dans le message seterror
                lstArtistes.SelectedIndexChanged -= new System.EventHandler(this.lstArtistes_SelectedIndexChanged_1);
                lstArtistes.DataSource = lesArtistes;
                lstArtistes.DisplayMember = "name";
                lstArtistes.SelectedIndexChanged += new System.EventHandler(this.lstArtistes_SelectedIndexChanged_1);
                lstArtistes_SelectedIndexChanged_1(lstArtistes, new EventArgs());
                //On indique à la listbox des artistes d'aller chercher les données dans la liste lesArtistes

                grbArtisteInfos.Visible = true;
                panelDisco.Visible = true;
                lblMessage.Text = string.Empty;
                txtArtisteRecherche.Text = string.Empty;
                //On rend visible la listbox des artistes et de la discographie
                //On enlève ce qu'il y a dans la barre de recherche



            }
        }
        #endregion
        //Contient les méthodes concernant le boutton recherche

        #region ListBox
        private void lstArtistes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            selectedArtist = (Artist)lstArtistes.SelectedItem;
            selectedArtist = DeezerApi.getDetailsArtistById(selectedArtist.id);
            //On définit ce que vaut l'artiste sélectionné
            //Et on demande une recherche de tous ses détails
            //On la stock dans l'objet selectedArtist

            lblArtisteNom.Text = selectedArtist.name;
            picArtiste.ImageLocation = selectedArtist.picture;
            lklDeezerLien.Text = selectedArtist.link;
            string urlWidget = DeezerPlugin.getUrlPluginRadio(selectedArtist.id, wkbRadio.Size.Width, wkbRadio.Size.Height);
            wkbRadio.Navigate(urlWidget);

            //Une fois l'artiste sélectionné
            //On renseigne son nom, sa photo etc... dans les champs prévus à cet effet
            //Et on renseigne les paramètres pour sa radio

            List<Album> lesAlbums = new List<Album>();
            lesAlbums = selectedArtist.getLesAlbums();

            //On demande les albums de l'artiste sélectionné

            if (selectedArtist.getLesAlbums() == null)
            {
                message = AUCUNE_DISCOGRAPHIE;
                lblMessage.Text = message;
                erp.SetError(lstAlbums, message);
                picIpod.Enabled = false;
                //Si on n'en trouve aucun, on affiche un message d'erreur
            }
                

            else
            {
                picIpod.Enabled = true;
                lstAlbums.SelectedIndexChanged -= new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
                lstAlbums.DataSource = lesAlbums;
                lstAlbums.DisplayMember = "title";
                lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
                lstAlbums_SelectedIndexChanged(lstAlbums, new EventArgs());
                //Sinon on indique à la liste des albums sa source de données
            }

            

        }
        private void lstAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedAlbum = (Album)lstAlbums.SelectedItem;

            picArtisteDisco.ImageLocation = selectedAlbum.cover;

            List<Track> lesTracks = new List<Track>();
            lesTracks = selectedAlbum.getLesTracks();

            lstTitres.SelectedIndexChanged -= new System.EventHandler(this.lstTitres_SelectedIndexChanged);
            lstTitres.DataSource = lesTracks;
            lstTitres.DisplayMember = "title";
            lstTitres.SelectedIndexChanged += new System.EventHandler(this.lstTitres_SelectedIndexChanged);
            lstTitres_SelectedIndexChanged(lstTitres, new EventArgs());

            //Même chose que précédemment, on sélectionne un album
            //On renseigne son image de couverture
            //Puis on va chercher les tracks pour l'album sélectionné
            //On va donc renseigner la source de données pour la liste des Tracks


        }
        private void lstAlbums_DoubleClick(object sender, EventArgs e)
        {
            
            List<Track> lesTracks = selectedAlbum.getLesTracks();

            foreach (Track unTrack in lesTracks)
            {
                formulaire.lstGauche.Items.Add(unTrack);
                formulaire.lstGauche.DisplayMember = "name";
            }
            formulaire.Show();
        }

        private void lstTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selectedTrack = (Track)lstTitres.SelectedItem;

            string urlWidget = DeezerPlugin.getUrlPluginTrack(selectedTrack.id);
            wkbDisco.Navigate(urlWidget);

            //Ici même plugin que la radio, mais on écoute cette fois la track sélectionnée
        }
        #endregion
        //Contient les méthodes concernant les différentes listbox de l'appli

        #region Autres
        private void picDeezer_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.deezer.com/fr/");
        }

        private void lklDeezerLien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(lklDeezerLien.Text);
        }

        private void btnEcouterExtraits_Click(object sender, EventArgs e)
        {
            
            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);

            if (selectedArtistDetails == null)
            {
                lblMessage.Text = EXTRAITS_TROUVES;
                erp.SetError(btnEcouterExtraits, EXTRAITS_TROUVES);

            }
            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
                List<Album> lesAlbums = selectedArtistDetails.getLesAlbums();

                foreach (Album unAlbum in lesAlbums)
                {
                    List<Track> lesTracks = unAlbum.getLesTracks();

                    foreach (Track unTrack in lesTracks)
                    {
                        WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                        formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                    }

                }

                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        //Contient diverses méthodes comme les liens externes

        #region Ouverture_Formulaire
        

        private void lecteurMultimédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();
            formulaire.Show();
        }

        private void aproposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPropos formulaire = new FrmPropos();
            formulaire.Show();
        }
        private void rechercheDAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRechercheAlbums formulaire = new FrmRechercheAlbums();
            formulaire.Show();
        }
        #endregion



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCoverFlow formulaire = new frmCoverFlow();
            this.Cursor = Cursors.WaitCursor;
            selectedArtistDetails = DeezerApi.getDetailsArtistById(selectedArtist.id);

            if (selectedArtistDetails == null)
            {
                lblMessage.Text = EXTRAITS_TROUVES;
                erp.SetError(btnEcouterExtraits, EXTRAITS_TROUVES);

            }
            else
            {
                this.Cursor = Cursors.Default;
                formulaire.selectedArtistDetails = this.selectedArtistDetails;
                formulaire.Show();
            }   

        }

        private void menuStripOuvrir_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void menuStripMasquer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void menuStripQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        //Contient les méthodes pour ouvrir d'autres formulaires

    }

}
