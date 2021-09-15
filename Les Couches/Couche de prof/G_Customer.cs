#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_BD_DVD_STORE.MDF.Classes;
using Projet_BD_DVD_STORE.MDF.Acces;
#endregion

namespace Projet_BD_DVD_STORE.MDF.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_Customer : G_Base
 {
  #region Constructeurs
  public G_Customer()
   : base()
  { }
  public G_Customer(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Cust_Nom, string Cust_PreNom, string Cust_Tele, string Cust_Email, int Cust_CodePostal, string Cust_Adresse, string Cust_PassWord)
  { return new A_Customer(ChaineConnexion).Ajouter(Cust_Nom, Cust_PreNom, Cust_Tele, Cust_Email, Cust_CodePostal, Cust_Adresse, Cust_PassWord); }
  public int Modifier(int Cust_ID, string Cust_Nom, string Cust_PreNom, string Cust_Tele, string Cust_Email, int Cust_CodePostal, string Cust_Adresse, string Cust_PassWord)
  { return new A_Customer(ChaineConnexion).Modifier(Cust_ID, Cust_Nom, Cust_PreNom, Cust_Tele, Cust_Email, Cust_CodePostal, Cust_Adresse, Cust_PassWord); }
  public List<C_Customer> Lire(string Index)
  { return new A_Customer(ChaineConnexion).Lire(Index); }
  public C_Customer Lire_ID(int Cust_ID)
  { return new A_Customer(ChaineConnexion).Lire_ID(Cust_ID); }
  public int Supprimer(int Cust_ID)
  { return new A_Customer(ChaineConnexion).Supprimer(Cust_ID); }
 }
}
