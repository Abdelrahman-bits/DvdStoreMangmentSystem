#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using DVD_Classes;
using System.Windows;
#endregion

namespace DVD_Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_Client : ADBase
 {
  #region Constructeurs
  public A_Client(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
#endregion
  public List<C_Client> Lire(string Index)
  {
   CreerCommande("SelectionnerClient");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_Client> res = new List<C_Client>();
   while (dr.Read())
   {
	C_Client tmp = new C_Client();
    tmp.Cust_ID = int.Parse(dr["Cust_ID"].ToString());
    tmp.Cust_Nom = dr["Cust_Nom"].ToString();
    tmp.Cust_PreNom = dr["Cust_PreNom"].ToString();
	tmp.Cust_PassWord= dr["Cust_PassWord"].ToString();
	tmp.Cust_Email = dr["Cust_Email"].ToString();
	tmp.Cust_Tele = dr["Cust_Tele"].ToString();
	tmp.Cust_CodePostal = int.Parse(dr["Cust_CodePostal"].ToString());
	tmp.Cust_Adress = dr["Cust_Adresse"].ToString();
    res.Add(tmp);
   }
	dr.Close();
	Commande.Connection.Close();
	return res;
  }

public C_Client Lire_ID(int ID)
  {
   CreerCommande("SelectionnerClient_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
	C_Client res = new C_Client();
   while (dr.Read())
   {
				res.Cust_ID = int.Parse(dr["Cust_ID"].ToString());
				res.Cust_Nom = dr["Cust_Nom"].ToString();
				res.Cust_PreNom = dr["Cust_PreNom"].ToString();
				res.Cust_PassWord = dr["Cust_PassWord"].ToString();
				res.Cust_Email = dr["Cust_Email"].ToString();
				res.Cust_Tele = dr["Cust_Tele"].ToString();
				res.Cust_CodePostal = int.Parse(dr["Cust_CodePostal"].ToString());
				res.Cust_Adress = dr["Cust_Adresse"].ToString();
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}

	public string Louer(float Price, int DVDid, int ClientID)
	{
		CreerCommande("MakeARent");
		int res = 0;
		Commande.Parameters.AddWithValue("@Price", Price);
		Commande.Parameters.AddWithValue("@DvdID", DVDid);
		Commande.Parameters.AddWithValue("@ClientID", ClientID);
		Commande.Parameters.Add("@msg", SqlDbType.VarChar,100);
		Commande.Parameters["@msg"].Direction = ParameterDirection.Output;
		Commande.Connection.Open();
		res = Commande.ExecuteNonQuery();
		string msg = Convert.ToString(Commande.Parameters["@msg"].Value);
		Commande.Connection.Close();
		return msg;
	}
		public string ReturnDVD(int DVDid, int ClientID, DateTime DateRetourn,DateTime DateLoc)
		{
			CreerCommande("RETURNDVD");
			int res = 0;
			Commande.Parameters.AddWithValue("@DvdID", DVDid);
			Commande.Parameters.AddWithValue("@ClientID", ClientID);
			Commande.Parameters.AddWithValue("@DateRetourn", DateRetourn);
			Commande.Parameters.AddWithValue("@DateLoc", DateLoc);
			Commande.Parameters.Add("@msg", SqlDbType.VarChar, 100);
			Commande.Parameters["@msg"].Direction = ParameterDirection.Output;
			Commande.Connection.Open();
			res = Commande.ExecuteNonQuery();
			string msg = Convert.ToString(Commande.Parameters["@msg"].Value);
			Commande.Connection.Close();
			return msg;
		}

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

		public string Supprimer(int Cust_ID)
		{
			CreerCommande("SupprimerClient");
			int res = 0;
			Commande.Parameters.AddWithValue("@ID", Cust_ID);
			Commande.Parameters.Add("@msg", SqlDbType.VarChar, 100);
			Commande.Parameters["@msg"].Direction = ParameterDirection.Output;
			Commande.Connection.Open();
			res = Commande.ExecuteNonQuery();
			string msg = Convert.ToString(Commande.Parameters["@msg"].Value);
			Commande.Connection.Close();
			return msg;
		}
	}
}
