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
 public class A_Customer : ADBase
 {
  #region Constructeurs
  public A_Customer(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Cust_Nom, string Cust_PreNom, string Cust_Tele, string Cust_Email, int Cust_CodePostal, string Cust_Adresse, string Cust_PassWord)
  {
   CreerCommande("AjouterCustomer");
   int res = 0;
   Commande.Parameters.Add("Cust_ID", SqlDbType.Int);
   Direction("Cust_ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Cust_Nom", Cust_Nom);
   Commande.Parameters.AddWithValue("@Cust_PreNom", Cust_PreNom);
   Commande.Parameters.AddWithValue("@Cust_Tele", Cust_Tele);
   Commande.Parameters.AddWithValue("@Cust_Email", Cust_Email);
   Commande.Parameters.AddWithValue("@Cust_CodePostal", Cust_CodePostal);
   Commande.Parameters.AddWithValue("@Cust_Adresse", Cust_Adresse);
   Commande.Parameters.AddWithValue("@Cust_PassWord", Cust_PassWord);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("Cust_ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int Cust_ID, string Cust_Nom, string Cust_PreNom, string Cust_Tele, string Cust_Email, int Cust_CodePostal, string Cust_Adresse, string Cust_PassWord)
  {
   CreerCommande("ModifierCustomer");
   int res = 0;
   Commande.Parameters.AddWithValue("@Cust_ID", Cust_ID);
   Commande.Parameters.AddWithValue("@Cust_Nom", Cust_Nom);
   Commande.Parameters.AddWithValue("@Cust_PreNom", Cust_PreNom);
   Commande.Parameters.AddWithValue("@Cust_Tele", Cust_Tele);
   Commande.Parameters.AddWithValue("@Cust_Email", Cust_Email);
   Commande.Parameters.AddWithValue("@Cust_CodePostal", Cust_CodePostal);
   Commande.Parameters.AddWithValue("@Cust_Adresse", Cust_Adresse);
   Commande.Parameters.AddWithValue("@Cust_PassWord", Cust_PassWord);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_Customer> Lire(string Index)
  {
   CreerCommande("SelectionnerCustomer");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Customer> res = new List<C_Customer>();
   while (dr.Read())
   {
    C_Customer tmp = new C_Customer();
    tmp.Cust_ID = int.Parse(dr["Cust_ID"].ToString());
    tmp.Cust_Nom = dr["Cust_Nom"].ToString();
    tmp.Cust_PreNom = dr["Cust_PreNom"].ToString();
    tmp.Cust_Tele = dr["Cust_Tele"].ToString();
    tmp.Cust_Email = dr["Cust_Email"].ToString();
    tmp.Cust_CodePostal = int.Parse(dr["Cust_CodePostal"].ToString());
    tmp.Cust_Adresse = dr["Cust_Adresse"].ToString();
    tmp.Cust_PassWord = dr["Cust_PassWord"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_Customer Lire_ID(int Cust_ID)
  {
   CreerCommande("SelectionnerCustomer_ID");
   Commande.Parameters.AddWithValue("@Cust_ID", Cust_ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_Customer res = new C_Customer();
   while (dr.Read())
   {
    res.Cust_ID = int.Parse(dr["Cust_ID"].ToString());
    res.Cust_Nom = dr["Cust_Nom"].ToString();
    res.Cust_PreNom = dr["Cust_PreNom"].ToString();
    res.Cust_Tele = dr["Cust_Tele"].ToString();
    res.Cust_Email = dr["Cust_Email"].ToString();
    res.Cust_CodePostal = int.Parse(dr["Cust_CodePostal"].ToString());
    res.Cust_Adresse = dr["Cust_Adresse"].ToString();
    res.Cust_PassWord = dr["Cust_PassWord"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int Cust_ID)
  {
   CreerCommande("SupprimerCustomer");
   int res = 0;
   Commande.Parameters.AddWithValue("@Cust_ID", Cust_ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
