using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dllLastFm.Metiers
{
    public class Venue
    {
        #region Champs
        private int _id = 0;
        private string _nom = "Inconnu";
        private string _ville = "Inconnu";
        private string _pays = "Inconnu";
        private string _adresse = "Inconnu";
        private string _codePostal = "Inconnu";
        private string _latitude = "Inconnu";
        private string _longitude = "Inconnu";
        private List<Event> _lesEvents = new List<Event>();
        #endregion

        #region Propriétés
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Ville
        {
            get { return _ville; }
            set { _ville = value; }
        }
        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public string CodePostal
        {
            get { return _codePostal; }
            set { _codePostal = value; }
        }
        public string Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        public string Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        private List<Event> LesEvents
        {
            get { return _lesEvents; }
            internal set { _lesEvents = value; }
        }

        #endregion

        #region Méthodes
        public Venue()
        {
        }

        public Venue(int id, string nom, string pays, string ville, string codePostal, string adresse, string latitude, string longitude)
        {
            this.Id = id;
            this.Nom = nom;
            this.Ville = ville;
            this.CodePostal = codePostal;
            this.Adresse = adresse;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public List<Event> getLesEvents()
        {
            return LesEvents;
        }
        #endregion
    }
}