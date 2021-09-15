#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_BD_DVD_STORE.MDF.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_DVDs
 {
  #region Données membres
  private int _Dvd_ID;
  private string _Dvd_Nom;
  private string _Dvd_Category;
  private int? _Dvd_NumberInStock;
  private double? _Dvd_Prix;
  private string _Dvd_Realisateur;
  #endregion
  #region Constructeurs
  public C_DVDs()
  { }
  public C_DVDs(string Dvd_Nom_, string Dvd_Category_, int? Dvd_NumberInStock_, double? Dvd_Prix_, string Dvd_Realisateur_)
  {
   Dvd_Nom = Dvd_Nom_;
   Dvd_Category = Dvd_Category_;
   Dvd_NumberInStock = Dvd_NumberInStock_;
   Dvd_Prix = Dvd_Prix_;
   Dvd_Realisateur = Dvd_Realisateur_;
  }
  public C_DVDs(int Dvd_ID_, string Dvd_Nom_, string Dvd_Category_, int? Dvd_NumberInStock_, double? Dvd_Prix_, string Dvd_Realisateur_)
   : this(Dvd_Nom_, Dvd_Category_, Dvd_NumberInStock_, Dvd_Prix_, Dvd_Realisateur_)
  {
   Dvd_ID = Dvd_ID_;
  }
  #endregion
  #region Accesseurs
  public int Dvd_ID
  {
   get { return _Dvd_ID; }
   set { _Dvd_ID = value; }
  }
  public string Dvd_Nom
  {
   get { return _Dvd_Nom; }
   set { _Dvd_Nom = value; }
  }
  public string Dvd_Category
  {
   get { return _Dvd_Category; }
   set { _Dvd_Category = value; }
  }
  public int? Dvd_NumberInStock
  {
   get { return _Dvd_NumberInStock; }
   set { _Dvd_NumberInStock = value; }
  }
  public double? Dvd_Prix
  {
   get { return _Dvd_Prix; }
   set { _Dvd_Prix = value; }
  }
  public string Dvd_Realisateur
  {
   get { return _Dvd_Realisateur; }
   set { _Dvd_Realisateur = value; }
  }
  #endregion
 }
}
