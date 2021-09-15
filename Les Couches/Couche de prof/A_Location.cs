#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_BD_DVD_STORE.MDF.Classes;
#endregion

namespace Projet_BD_DVD_STORE.MDF.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_Location : ADBase
 {
  #region Constructeurs
  public A_Location(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime Loc_DateDeLocation, int Cust_ID)
  {
   CreerCommande("AjouterLocation");
   int res = 0;
   Commande.Parameters.Add("Loc_ID", SqlDbType.Int);
   Direction("Loc_ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Loc_DateDeLocation", Loc_DateDeLocation);
   Commande.Parameters.AddWithValue("@Cust_ID", Cust_ID);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Loc_ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Loc_ID, DateTime Loc_DateDeLocation, int Cust_ID)
  {
   CreerCommande("ModifierLocation");
   int res = 0;
   Commande.Parameters.AddWithValue("@Loc_ID", Loc_ID);
   Commande.Parameters.AddWithValue("@Loc_DateDeLocation", Loc_DateDeLocation);
   Commande.Parameters.AddWithValue("@Cust_ID", Cust_ID);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_Location> Lire(string Index)
  {
   CreerCommande("SelectionnerLocation");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Location> res = new List<C_Location>();
   while (dr.Read())
   {
    C_Location tmp = new C_Location();
    tmp.Loc_ID = int.Parse(dr["Loc_ID"].ToString());
    tmp.Loc_DateDeLocation = DateTime.Parse(dr["Loc_DateDeLocation"].ToString());
    tmp.Cust_ID = int.Parse(dr["Cust_ID"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_Location Lire_ID(int Loc_ID)
  {
   CreerCommande("SelectionnerLocation_ID");
   Commande.Parameters.AddWithValue("@Loc_ID", Loc_ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_Location res = new C_Location();
   while (dr.Read())
   {
    res.Loc_ID = int.Parse(dr["Loc_ID"].ToString());
    res.Loc_DateDeLocation = DateTime.Parse(dr["Loc_DateDeLocation"].ToString());
    res.Cust_ID = int.Parse(dr["Cust_ID"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Loc_ID)
  {
   CreerCommande("SupprimerLocation");
   int res = 0;
   Commande.Parameters.AddWithValue("@Loc_ID", Loc_ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
