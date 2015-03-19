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
    public partial class FrmPlaylist : Form
    {
        #region Champs
        private const string AUCUN_TITRE = "Aucun titre dans la playlist !";
        private Track selectedTrack = new Track();
        #endregion

        #region Constructeur
        public FrmPlaylist()
        {
            InitializeComponent();
            btnVersDroiteUn.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersDroiteTous.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersGaucheUn.Click += new System.EventHandler(boutonsTransfert_Click);
            btnVersGaucheTous.Click += new System.EventHandler(boutonsTransfert_Click);
        }
        private void FrmPlaylist_Load(object sender, EventArgs e)
        {
            lstGauche.SelectedIndex = 0;

            btnVersGaucheUn.Enabled = false;
            btnVersGaucheTous.Enabled = false;
        }
        #endregion

        #region Completion des listes
        private void boutonsTransfert_Click(object sender, EventArgs e)
        {
            Button boutonDeclencheur = (Button)(sender);

            switch (boutonDeclencheur.Name)
            {
                case "btnVersDroiteUn":
                    transferer(lstGauche, lstDroite, ModeTransfert.Un);
                    break;
                case "btnVersDroiteTous":
                    transferer(lstGauche, lstDroite, ModeTransfert.Tous);
                    break;
                case "btnVersGaucheUn":
                    transferer(lstDroite, lstGauche, ModeTransfert.Un);
                    break;
                case "btnVersGaucheTous":
                    transferer(lstDroite, lstGauche, ModeTransfert.Tous);
                    break;

            }
        }
        private void transferer(ListBox lstSource, ListBox lstDestination, ModeTransfert mode)
        {
            switch (mode)
            {
                case ModeTransfert.Un: lstDestination.Items.Add(lstSource.SelectedItem);
                    lstSource.Items.Remove(lstSource.SelectedItem);
                    break;

                case ModeTransfert.Tous: foreach (object element in lstSource.Items)
                        lstDestination.Items.Add(element);

                    lstSource.Items.Clear();
                    break;

                case ModeTransfert.Certains: break;
            }
        }
        enum ModeTransfert
        {
            Un,
            Tous,
            Certains
        }

        #endregion

        #region ListBox
        private void lstDroite_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVersDroiteUn.Enabled = false;
            btnVersDroiteTous.Enabled = false;

            if (lstDroite.Items.Count > 0)
            {
                btnVersGaucheUn.Enabled = true;
                btnVersGaucheTous.Enabled = true;
            }

            else
            {
                btnVersGaucheUn.Enabled = false;
                btnVersGaucheTous.Enabled = false;
            }


        }

        private void lstGauche_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVersGaucheUn.Enabled = false;
            btnVersGaucheTous.Enabled = false;

            if (lstGauche.Items.Count > 0)
            {
                btnVersDroiteUn.Enabled = true;
                btnVersDroiteTous.Enabled = true;
            }

            else
            {
                btnVersDroiteUn.Enabled = false;
                btnVersDroiteTous.Enabled = false;
            }
        }
        #endregion

        #region Autres
        private void btnEcouterExtraits_Click(object sender, EventArgs e)
        {
            if (lstDroite.Items.Count == 0)
            {
                erp.SetError(btnEcouterExtraits, AUCUN_TITRE);
            }

            else
            {
                FrmLecteurMultimedia formulaire = new FrmLecteurMultimedia();

                foreach (Track unTrack in lstDroite.Items)
                {
                    WMPLib.IWMPMedia unMedia = formulaire.wmpLecteur.newMedia(unTrack.preview);
                    formulaire.wmpLecteur.currentPlaylist.appendItem(unMedia);
                }

                formulaire.Show();
                formulaire.wmpLecteur.Ctlcontrols.play();


            }
        }
        #endregion

        private void btnLectureAleatoire_Click(object sender, EventArgs e)
        {
               
        }

    }
}
