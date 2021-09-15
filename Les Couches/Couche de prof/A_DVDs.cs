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
 public class A_DVDs : ADBase
 {
  #region Constructeurs
  public A_DVDs(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Dvd_Nom, string Dvd_Category, int? Dvd_NumberInStock, double? Dvd_Prix, string Dvd_Realisateur)
  {
   CreerCommande("AjouterDVDs");
   int res = 0;
   Commande.Parameters.Add("Dvd_ID", SqlDbType.Int);
   Direction("Dvd_ID", ParameterDirection.Output);
   if(Dvd_Nom == null) Commande.Parameters.AddWithValue("@Dvd_Nom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_Nom", Dvd_Nom);
   if(Dvd_Category == null) Commande.Parameters.AddWithValue("@Dvd_Category", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_Category", Dvd_Category);
   if(Dvd_NumberInStock == null) Commande.Parameters.AddWithValue("@Dvd_NumberInStock", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_NumberInStock", Dvd_NumberInStock);
   if(Dvd_Prix == null) Commande.Parameters.AddWithValue("@Dvd_Prix", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_Prix", Dvd_Prix);
   if(Dvd_Realisateur == null) Commande.Parameters.AddWithValue("@Dvd_Realisateur", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_Realisateur", Dvd_Realisateur);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Dvd_ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Dvd_ID, string Dvd_Nom, string Dvd_Category, int? Dvd_NumberInStock, double? Dvd_Prix, string Dvd_Realisateur)
  {
   CreerCommande("ModifierDVDs");
   int res = 0;
   Commande.Parameters.AddWithValue("@Dvd_ID", Dvd_ID);
   if(Dvd_Nom == null) Commande.Parameters.AddWithValue("@Dvd_Nom", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_Nom", Dvd_Nom);
   if(Dvd_Category == null) Commande.Parameters.AddWithValue("@Dvd_Category", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_Category", Dvd_Category);
   if(Dvd_NumberInStock == null) Commande.Parameters.AddWithValue("@Dvd_NumberInStock", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_NumberInStock", Dvd_NumberInStock);
   if(Dvd_Prix == null) Commande.Parameters.AddWithValue("@Dvd_Prix", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_Prix", Dvd_Prix);
   if(Dvd_Realisateur == null) Commande.Parameters.AddWithValue("@Dvd_Realisateur", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Dvd_Realisateur", Dvd_Realisateur);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_DVDs> Lire(string Index)
  {
   CreerCommande("SelectionnerDVDs");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_DVDs> res = new List<C_DVDs>();
   while (dr.Read())
   {
    C_DVDs tmp = new C_DVDs();
    tmp.Dvd_ID = int.Parse(dr["Dvd_ID"].ToString());
    tmp.Dvd_Nom = dr["Dvd_Nom"].ToString();
    tmp.Dvd_Category = dr["Dvd_Category"].ToString();
   if(dr["Dvd_NumberInStock"] != DBNull.Value) tmp.Dvd_NumberInStock = int.Parse(dr["Dvd_NumberInStock"].ToString());
   if(dr["Dvd_Prix"] != DBNull.Value) tmp.Dvd_Prix = double.Parse(dr["Dvd_Prix"].ToString());
    tmp.Dvd_Realisateur = dr["Dvd_Realisateur"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_DVDs Lire_ID(int Dvd_ID)
  {
   CreerCommande("SelectionnerDVDs_ID");
   Commande.Parameters.AddWithValue("@Dvd_ID", Dvd_ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_DVDs res = new C_DVDs();
   while (dr.Read())
   {
    res.Dvd_ID = int.Parse(dr["Dvd_ID"].ToString());
    res.Dvd_Nom = dr["Dvd_Nom"].ToString();
    res.Dvd_Category = dr["Dvd_Category"].ToString();
   if(dr["Dvd_NumberInStock"] != DBNull.Value) res.Dvd_NumberInStock = int.Parse(dr["Dvd_NumberInStock"].ToString());
   if(dr["Dvd_Prix"] != DBNull.Value) res.Dvd_Prix = double.Parse(dr["Dvd_Prix"].ToString());
    res.Dvd_Realisateur = dr["Dvd_Realisateur"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Dvd_ID)
  {
   CreerCommande("SupprimerDVDs");
   int res = 0;
   Commande.Parameters.AddWithValue("@Dvd_ID", Dvd_ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
