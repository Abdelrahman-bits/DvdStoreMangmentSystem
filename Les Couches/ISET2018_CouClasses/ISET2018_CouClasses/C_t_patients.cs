#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_BD_Hopital.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_t_patients
 {
  #region Données membres
  private  _IDPat;
  private string _NomPat;
  private string _PrenomPat;
  private string _AdressePat;
  private int _GSMPat;
  #endregion
  #region Constructeurs
  public C_t_patients()
  { }
  public C_t_patients(string NomPat_, string PrenomPat_, string AdressePat_, int GSMPat_)
  {
   NomPat = NomPat_;
   PrenomPat = PrenomPat_;
   AdressePat = AdressePat_;
   GSMPat = GSMPat_;
  }
  public C_t_patients( IDPat_, string NomPat_, string PrenomPat_, string AdressePat_, int GSMPat_)
   : this(NomPat_, PrenomPat_, AdressePat_, GSMPat_)
  {
   IDPat = IDPat_;
  }
  #endregion
  #region Accesseurs
  public  IDPat
  {
   get { return _IDPat; }
   set { _IDPat = value; }
  }
  public string NomPat
  {
   get { return _NomPat; }
   set { _NomPat = value; }
  }
  public string PrenomPat
  {
   get { return _PrenomPat; }
   set { _PrenomPat = value; }
  }
  public string AdressePat
  {
   get { return _AdressePat; }
   set { _AdressePat = value; }
  }
  public int GSMPat
  {
   get { return _GSMPat; }
   set { _GSMPat = value; }
  }
  #endregion
 }
}
