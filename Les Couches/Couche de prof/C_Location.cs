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
 public class C_Location
 {
  #region Données membres
  private int _Loc_ID;
  private DateTime _Loc_DateDeLocation;
  private int _Cust_ID;
  #endregion
  #region Constructeurs
  public C_Location()
  { }
  public C_Location(DateTime Loc_DateDeLocation_, int Cust_ID_)
  {
   Loc_DateDeLocation = Loc_DateDeLocation_;
   Cust_ID = Cust_ID_;
  }
  public C_Location(int Loc_ID_, DateTime Loc_DateDeLocation_, int Cust_ID_)
   : this(Loc_DateDeLocation_, Cust_ID_)
  {
   Loc_ID = Loc_ID_;
  }
  #endregion
  #region Accesseurs
  public int Loc_ID
  {
   get { return _Loc_ID; }
   set { _Loc_ID = value; }
  }
  public DateTime Loc_DateDeLocation
  {
   get { return _Loc_DateDeLocation; }
   set { _Loc_DateDeLocation = value; }
  }
  public int Cust_ID
  {
   get { return _Cust_ID; }
   set { _Cust_ID = value; }
  }
  #endregion
 }
}
