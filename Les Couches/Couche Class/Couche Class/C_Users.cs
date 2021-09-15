#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Couche_Class
{
   public class C_Users
    {
            #region Données membres
            private int _ID;
            private string _NOM;
            private string _PRE;
            private string _PASS;
            
            #endregion
            #region Constructeurs
            public C_Users()
            { }
            public C_Users(string NOM_, string PRE_, string PASS_)
            {
                NOM = NOM_;
                PRE = PRE_;
                PASS = PASS_;
            }
            public C_Users(int ID_, string NOM_, string PRE_, string PASS_)
             : this(NOM_, PRE_, PASS_)
            {
                ID = ID_;
            }
            #endregion
            #region Accesseurs
            public int ID
            {
                get { return _ID; }
                set { _ID = value; }
            }
            public string NOM
            {
                get { return _NOM; }
                set { _NOM = value; }
            }
            public string PRE
            {
                get { return _PRE; }
                set { _PRE = value; }
            }
            public string PASS
            {
                get { return _PASS; }
                set { _PASS = value; }
            }
            #endregion
   }
}
