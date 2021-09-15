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
 public class G_DVDs : G_Base
 {
  #region Constructeurs
  public G_DVDs()
   : base()
  { }
  public G_DVDs(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Dvd_Nom, string Dvd_Category, int? Dvd_NumberInStock, double? Dvd_Prix, string Dvd_Realisateur)
  { return new A_DVDs(ChaineConnexion).Ajouter(Dvd_Nom, Dvd_Category, Dvd_NumberInStock, Dvd_Prix, Dvd_Realisateur); }
  public int Modifier(int Dvd_ID, string Dvd_Nom, string Dvd_Category, int? Dvd_NumberInStock, double? Dvd_Prix, string Dvd_Realisateur)
  { return new A_DVDs(ChaineConnexion).Modifier(Dvd_ID, Dvd_Nom, Dvd_Category, Dvd_NumberInStock, Dvd_Prix, Dvd_Realisateur); }
  public List<C_DVDs> Lire(string Index)
  { return new A_DVDs(ChaineConnexion).Lire(Index); }
  public C_DVDs Lire_ID(int Dvd_ID)
  { return new A_DVDs(ChaineConnexion).Lire_ID(Dvd_ID); }
  public int Supprimer(int Dvd_ID)
  { return new A_DVDs(ChaineConnexion).Supprimer(Dvd_ID); }
 }
}
