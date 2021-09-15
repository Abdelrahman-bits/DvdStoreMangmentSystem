#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace DVD_Classes
{
    /// <summary>
    /// Classe de définition des données
    /// </summary>
    public class C_Client
    {
        #region Données membres
        private int _ID;
        private string _NOM;
        private string _PRE;
        private string _PASS;
        private string _Email;
        private string _adress;
        private int _codePostal;
        private string _Tele;
        private DateTime _DateDeRetour;

        #endregion
        #region Constructeurs
        public C_Client()
        { }
        public C_Client(string NOM_, string PRE_, string PASS_, string Email_, string Adress_, int CodePostal_, string tele_,DateTime DateDeRetour_)
        {
            Cust_Nom = NOM_;
            Cust_PreNom = PRE_;
            Cust_PassWord = PASS_;
            Cust_Email = Email_;
            Cust_Adress = Adress_;
            Cust_CodePostal = CodePostal_;
            Cust_Tele = tele_;
            DateDeRetour = DateDeRetour_;
        }
        public C_Client(int ID_, string NOM_, string PRE_, string PASS_,string Email_, string Adress_, int CodePostal_, string tele_,DateTime DateDeRoutour_)
         : this(NOM_, PRE_, PASS_,Email_,Adress_,CodePostal_,tele_, DateDeRoutour_)
        {
            Cust_ID = ID_;
        }
        #endregion
        #region Accesseurs
        public int Cust_ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string Cust_Nom
        {
            get { return _NOM; }
            set { _NOM = value; }
        }
        public string Cust_PreNom
        {
            get { return _PRE; }
            set { _PRE = value; }
        }
        public string Cust_PassWord
        {
            get { return _PASS; }
            set { _PASS = value; }
        }

        public string Cust_Email { get => _Email; set => _Email = value; }
        public string Cust_Adress { get => _adress; set => _adress = value; }
        public int Cust_CodePostal { get => _codePostal; set => _codePostal = value; }
        public string Cust_Tele { get => _Tele; set => _Tele = value; }
        public DateTime DateDeRetour { get => _DateDeRetour; set => _DateDeRetour = value; }

        #endregion
    }
}
