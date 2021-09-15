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
 public class C_t_soigner
 {
  #region Données membres
  private  _IDSoi;
  private int _IDMed;
  private int _IDPat;
  private DateTime _DateOperation;
  private DateTime _DateAuthorisationSortie;
  private int? _PrixOperation;
  #endregion
  #region Constructeurs
  public C_t_soigner()
  { }
  public C_t_soigner(int IDMed_, int IDPat_, DateTime DateOperation_, DateTime DateAuthorisationSortie_, int? PrixOperation_)
  {
   IDMed = IDMed_;
   IDPat = IDPat_;
   DateOperation = DateOperation_;
   DateAuthorisationSortie = DateAuthorisationSortie_;
   PrixOperation = PrixOperation_;
  }
  public C_t_soigner( IDSoi_, int IDMed_, int IDPat_, DateTime DateOperation_, DateTime DateAuthorisationSortie_, int? PrixOperation_)
   : this(IDMed_, IDPat_, DateOperation_, DateAuthorisationSortie_, PrixOperation_)
  {
   IDSoi = IDSoi_;
  }
  #endregion
  #region Accesseurs
  public  IDSoi
  {
   get { return _IDSoi; }
   set { _IDSoi = value; }
  }
  public int IDMed
  {
   get { return _IDMed; }
   set { _IDMed = value; }
  }
  public int IDPat
  {
   get { return _IDPat; }
   set { _IDPat = value; }
  }
  public DateTime DateOperation
  {
   get { return _DateOperation; }
   set { _DateOperation = value; }
  }
  public DateTime DateAuthorisationSortie
  {
   get { return _DateAuthorisationSortie; }
   set { _DateAuthorisationSortie = value; }
  }
  public int? PrixOperation
  {
   get { return _PrixOperation; }
   set { _PrixOperation = value; }
  }
  #endregion
 }
}
