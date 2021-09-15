#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DVD_Classes;
#endregion

namespace DVD_Acces
{
    /// <summary>
    /// Couche d'accès aux données (Data Access Layer)
    /// </summary>
    public class A_Manager : ADBase
    {
        #region Constructeurs
        public A_Manager(string sChaineConnexion)
            : base(sChaineConnexion)
        { }
        #endregion

        public List<C_Manager> ConsultInLoan(int Cust_ID,int which)
        {
            CreerCommande("DVDSinLoan");
            Commande.Parameters.AddWithValue("@Cust_ID", Cust_ID);
            Commande.Parameters.AddWithValue("@oneORtwo", which);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_Manager> res = new List<C_Manager>();
            while (dr.Read())
            {
                C_Manager tmp = new C_Manager();
                tmp.nbDVDsInLoan = int.Parse(dr["numberofDVDsinLoan"].ToString());
                tmp.IDOfDVDsInLoan = int.Parse(dr["Dvd_ID"].ToString());
                tmp.DVDID = int.Parse(dr["Dvd_ID"].ToString());
                res.Add(tmp);
            }

            dr.Close();
            Commande.Connection.Close();
            return res;
        }
        public List<C_Manager> ConsultClientLoan(int Cust_ID, int which)
        {
            CreerCommande("DVDSinLoan");
            Commande.Parameters.AddWithValue("@Cust_ID", Cust_ID);
            Commande.Parameters.AddWithValue("@oneORtwo", which);
            Commande.Connection.Open();
            SqlDataReader dr = Commande.ExecuteReader();
            List<C_Manager> res = new List<C_Manager>();
            while (dr.Read())
            {
                C_Manager tmp = new C_Manager();
                tmp.IDOfDVDsInLoan = int.Parse(dr["Dvd_ID"].ToString());
                tmp.DateDeRetour = DateTime.Parse(dr["OL_DatePourRetourner"].ToString());
                tmp.DateDeRent = DateTime.Parse(dr["Loc_DateDeLocation"].ToString());
                tmp.ClientID = int.Parse(dr["Cust_ID"].ToString());
                tmp.DVDID = int.Parse(dr["Dvd_ID"].ToString());
                res.Add(tmp);
            }

            dr.Close();
            Commande.Connection.Close();
            return res;
        }
    }
}