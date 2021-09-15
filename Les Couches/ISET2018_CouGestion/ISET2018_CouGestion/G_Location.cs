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
 public class G_Location : G_Base
 {
  #region Constructeurs
  public G_Location()
   : base()
  { }
  public G_Location(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(DateTime Loc_DateDeLocation, int Cust_ID)
  { return new A_Location(ChaineConnexion).Ajouter(Loc_DateDeLocation, Cust_ID); }
  public int Modifier(int Loc_ID, DateTime Loc_DateDeLocation, int Cust_ID)
  { return new A_Location(ChaineConnexion).Modifier(Loc_ID, Loc_DateDeLocation, Cust_ID); }
  public List<C_Location> Lire(string Index)
  { return new A_Location(ChaineConnexion).Lire(Index); }
  public C_Location Lire_ID(int Loc_ID)
  { return new A_Location(ChaineConnexion).Lire_ID(Loc_ID); }
  public int Supprimer(int Loc_ID)
  { return new A_Location(ChaineConnexion).Supprimer(Loc_ID); }
 }
}
