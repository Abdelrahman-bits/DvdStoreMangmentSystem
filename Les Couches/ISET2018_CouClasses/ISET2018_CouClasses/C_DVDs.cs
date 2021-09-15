using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Classes
{
    public class C_DVDs
    {
        #region Données membres
        private int _ID;
        private string _NOM;
        private string _CATEGORY;
        private int _nbInStock;
        private float _PRIX;
        private string _Realisateur;
        private string _MaisonDeEdition;

        #endregion
        #region Constructeurs
        public C_DVDs()
        { }
        public C_DVDs(string NOM_, string Category_, string Realisateur_, float prix_, int nbInStock_,string MaisonDeEdition)
        {
            Dvd_Nom = NOM_;
            Dvd_Realisateur = Realisateur_;
            Dvd_Prix = prix_;
            Dvd_Category = Category_;
            Dvd_NumberInStock = nbInStock_;
            MaisonDeEdition = _MaisonDeEdition;

        }
        public C_DVDs(int ID_, string NOM_, string Category_, string Realisateur_, float prix_, int nbInStock_, string MaisonDeEdition)
         : this(NOM_, Category_, Realisateur_, prix_, nbInStock_, MaisonDeEdition)
        {
            Dvd_ID = ID_;
        }
        #endregion
        #region Accesseurs
        public int Dvd_ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Dvd_Nom
        {
            get { return _NOM; }
            set { _NOM = value; }
        }
        public string Dvd_Category
        {
            get { return _CATEGORY; }
            set { _CATEGORY = value; }
        }
        public int Dvd_NumberInStock
        {
            get { return _nbInStock; }
            set { _nbInStock = value; }
        }
        public float Dvd_Prix
        {
            get { return _PRIX; }
            set { _PRIX = value; }
        }
        public string Dvd_Realisateur
        {
            get { return _Realisateur; }
            set { _Realisateur = value; }
        }

        public string MaisonDeEdition { get => _MaisonDeEdition; set => _MaisonDeEdition = value; }

        #endregion
    }
}
