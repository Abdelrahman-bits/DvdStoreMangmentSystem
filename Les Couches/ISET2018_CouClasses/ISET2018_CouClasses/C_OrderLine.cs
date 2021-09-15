#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace DVD_Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_OrderLine
 {
  #region Données membres
  private int _OL_ID;
  private int _Loc_ID;
  private int _Dvd_ID;
  private int _OL_PrixTotal;
  private DateTime _OL_DatePourRetourner;
  #endregion
  #region Constructeurs
  public C_OrderLine()
  { }
  public C_OrderLine(int Dvd_ID_, int OL_PrixTotal_, DateTime OL_DatePourRetourner_)
  {
   Dvd_ID = Dvd_ID_;
   OL_PrixTotal = OL_PrixTotal_;
   OL_DatePourRetourner = OL_DatePourRetourner_;
  }
  public C_OrderLine(int OL_ID_, int Loc_ID_, int Dvd_ID_, int OL_PrixTotal_, DateTime OL_DatePourRetourner_)
   : this(Dvd_ID_, OL_PrixTotal_, OL_DatePourRetourner_)
  {
   OL_ID = OL_ID_;
   Loc_ID = Loc_ID_;
  }
  #endregion
  #region Accesseurs
  public int OL_ID
  {
   get { return _OL_ID; }
   set { _OL_ID = value; }
  }
  public int Loc_ID
  {
   get { return _Loc_ID; }
   set { _Loc_ID = value; }
  }
  public int Dvd_ID
  {
   get { return _Dvd_ID; }
   set { _Dvd_ID = value; }
  }
  public int OL_PrixTotal
  {
   get { return _OL_PrixTotal; }
   set { _OL_PrixTotal = value; }
  }
  public DateTime OL_DatePourRetourner
  {
   get { return _OL_DatePourRetourner; }
   set { _OL_DatePourRetourner = value; }
  }
  #endregion
 }
}
