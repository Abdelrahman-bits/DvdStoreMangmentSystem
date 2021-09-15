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
 public class G_OrderLine : G_Base
 {
  #region Constructeurs
  public G_OrderLine()
   : base()
  { }
  public G_OrderLine(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int Dvd_ID, int OL_PrixTotal, DateTime OL_DatePourRetourner)
  { return new A_OrderLine(ChaineConnexion).Ajouter(Dvd_ID, OL_PrixTotal, OL_DatePourRetourner); }
  public int Modifier(int OL_ID,int Loc_ID, int Dvd_ID, int OL_PrixTotal, DateTime OL_DatePourRetourner)
  { return new A_OrderLine(ChaineConnexion).Modifier(OL_ID,Loc_ID, Dvd_ID, OL_PrixTotal, OL_DatePourRetourner); }
  public List<C_OrderLine> Lire(string Index)
  { return new A_OrderLine(ChaineConnexion).Lire(Index); }
  public C_OrderLine Lire_ID(int Loc_ID)
  { return new A_OrderLine(ChaineConnexion).Lire_ID(Loc_ID); }
  public int Supprimer(int Loc_ID)
  { return new A_OrderLine(ChaineConnexion).Supprimer(Loc_ID); }
 }
}
