using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dllLastFm.Metiers
{
    public class Artist
    {
        #region Champs
        private int _id = 0;
        private string _nom = "Inconnu";
        private string _url = "Inconnu";
        private string _image = "Inconnu";
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
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        private List<Event> LesEvents
        {
            get { return _lesEvents; }
            internal set { _lesEvents = value; }
        }
        #endregion

        #region Constructeur   
        public Artist()
        {
        }
        public Artist(int Id, string Nom, string Url, string Image)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Url = Url;
            this.Image = Image;
        }
        #endregion
        #region Méthodes
        public List<Event> getLesEvents()
        {
            return LesEvents;
        }
        #endregion
    }
}
