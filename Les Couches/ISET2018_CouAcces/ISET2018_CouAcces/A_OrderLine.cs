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
 public class A_OrderLine : ADBase
 {
  #region Constructeurs
  public A_OrderLine(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int Dvd_ID, int OL_PrixTotal, DateTime OL_DatePourRetourner)
  {
   CreerCommande("AjouterOrderLine");
   int res = 0;
   Commande.Parameters.Add("OL_ID", SqlDbType.Int);
   Direction("OL_ID", ParameterDirection.Output);
   Commande.Parameters.Add("Loc_ID", SqlDbType.Int);
   Direction("Loc_ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Dvd_ID", Dvd_ID);
   Commande.Parameters.AddWithValue("@OL_PrixTotal", OL_PrixTotal);
   Commande.Parameters.AddWithValue("@OL_DatePourRetourner", OL_DatePourRetourner);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Loc_ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int OL_ID, int Loc_ID, int Dvd_ID, int OL_PrixTotal, DateTime OL_DatePourRetourner)
  {
   CreerCommande("ModifierOrderLine");
   int res = 0;
   Commande.Parameters.AddWithValue("@OL_ID", OL_ID);
   Commande.Parameters.AddWithValue("@Loc_ID", Loc_ID);
   Commande.Parameters.AddWithValue("@Dvd_ID", Dvd_ID);
   Commande.Parameters.AddWithValue("@OL_PrixTotal", OL_PrixTotal);
   Commande.Parameters.AddWithValue("@OL_DatePourRetourner", OL_DatePourRetourner);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_OrderLine> Lire(string Index)
  {
   CreerCommande("SelectionnerOrderLine");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_OrderLine> res = new List<C_OrderLine>();
   while (dr.Read())
   {
    C_OrderLine tmp = new C_OrderLine();
    tmp.OL_ID = int.Parse(dr["OL_ID"].ToString());
    tmp.Loc_ID = int.Parse(dr["Loc_ID"].ToString());
    tmp.Dvd_ID = int.Parse(dr["Dvd_ID"].ToString());
    tmp.OL_PrixTotal = int.Parse(dr["OL_PrixTotal"].ToString());
    tmp.OL_DatePourRetourner = DateTime.Parse(dr["OL_DatePourRetourner"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_OrderLine Lire_ID(int Loc_ID)
  {
   CreerCommande("SelectionnerOrderLine_ID");
   Commande.Parameters.AddWithValue("@Loc_ID", Loc_ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_OrderLine res = new C_OrderLine();
   while (dr.Read())
   {
    res.OL_ID = int.Parse(dr["OL_ID"].ToString());
    res.Loc_ID = int.Parse(dr["Loc_ID"].ToString());
    res.Dvd_ID = int.Parse(dr["Dvd_ID"].ToString());
    res.OL_PrixTotal = int.Parse(dr["OL_PrixTotal"].ToString());
    res.OL_DatePourRetourner = DateTime.Parse(dr["OL_DatePourRetourner"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Loc_ID)
  {
   CreerCommande("SupprimerOrderLine");
   int res = 0;
   Commande.Parameters.AddWithValue("@Loc_ID", Loc_ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
