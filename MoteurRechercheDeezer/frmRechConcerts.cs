using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiKnCo.MoteurRechercheDeezer_V3
{
    public partial class frmRechConcerts : Form
    {
        public frmRechConcerts()
        {
            InitializeComponent();
        }

        private void frmRechConcerts_Load(object sender, EventArgs e)
        {
            cbTypeRech.Items.Add("Recherche par ville.");
            cbTypeRech.Items.Add("Recherche par artiste.");
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            if(cbTypeRech.SelectedText == "Recherche par ville.")
            {

            }
            else//recherche ici par artiste
            {

            }

            try
            {
                tabConcert.Enabled = true;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            lstSugestions.Visible = true;
            lstSugestions.BringToFront();
            //Remplir la lstSuggestions
            //Afficher la lstSuggestions en premier plan

            //Puis effectuer les traitements sur la lstSuggestions pour que l'item selectioné remplisse la txtRecherche.
        }

        private void lstSugestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRecherche.Text = Convert.ToString(lstSugestions.SelectedItem);
            lstSugestions.Visible = false;
        }
    }
}
