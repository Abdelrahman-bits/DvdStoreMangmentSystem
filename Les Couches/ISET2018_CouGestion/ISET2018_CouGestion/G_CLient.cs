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
 public class G_CLient : G_Base
 {
  #region Constructeurs
  public G_CLient()
   : base()
  { }
  public G_CLient(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
        #endregion//DESKTOP-GAIVTJQ\ABDELRAHMAN
  public List<C_Client> Lire(string Index)
  { return new A_Client(ChaineConnexion).Lire(Index); }
  public C_Client Lire_ID(int ID)
  { return new A_Client(ChaineConnexion).Lire_ID(ID); }
  public string Supprimer(int ID)
  { return new A_Client(ChaineConnexion).Supprimer(ID); }
  public string Louer(float Price, int DVDid, int ClientID)
  { return new A_Client(ChaineConnexion).Louer(Price,DVDid,ClientID); }
   public string ReturnDVD(int DVDid, int ClientID, DateTime DateRetourn, DateTime DateLoc)
  {return new A_Client(ChaineConnexion).ReturnDVD(DVDid, ClientID, DateRetourn, DateLoc);}
  public int Ajouter(string Cust_Nom, string Cust_PreNom, string Cust_Tele, string Cust_Email, int Cust_CodePostal, string Cust_Adresse, string Cust_PassWord)
  { return new A_Client(ChaineConnexion).Ajouter(Cust_Nom, Cust_PreNom, Cust_Tele, Cust_Email, Cust_CodePostal, Cust_Adresse, Cust_PassWord); }
 public int Modifier(int Cust_ID, string Cust_Nom, string Cust_PreNom, string Cust_Tele, string Cust_Email, int Cust_CodePostal, string Cust_Adresse, string Cust_PassWord)
  { return new A_Client(ChaineConnexion).Modifier(Cust_ID, Cust_Nom, Cust_PreNom, Cust_Tele, Cust_Email, Cust_CodePostal, Cust_Adresse, Cust_PassWord); }
 }
}
