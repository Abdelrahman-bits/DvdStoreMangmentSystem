#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using DVD_Classes;
using DVD_Acces;
#endregion

namespace DVD_Gestion
{
    /// <summary>
    /// Couche intermédiaire de gestion (Business Layer)
    /// </summary>
    public class G_Manager : G_Base
    {
        #region Constructeurs
        public G_Manager()
         : base()
        { }
        public G_Manager(string sChaineConnexion)
         : base(sChaineConnexion)
        { }
        #endregion
        public List<C_Manager> ConsultInLoan(int CustID, int which)
        { 
            return new A_Manager(ChaineConnexion).ConsultInLoan(CustID,which); 
        }
        public List<C_Manager> ConsultClientLoan(int CustID, int which)
        {
            return new A_Manager(ChaineConnexion).ConsultClientLoan(CustID, which);
        }
    }


}
