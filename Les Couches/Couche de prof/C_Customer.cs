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
 public class C_Customer
 {
  #region Données membres
  private int _Cust_ID;
  private string _Cust_Nom;
  private string _Cust_PreNom;
  private string _Cust_Tele;
  private string _Cust_Email;
  private int _Cust_CodePostal;
  private string _Cust_Adresse;
  private string _Cust_PassWord;
  #endregion
  #region Constructeurs
  public C_Customer()
  { }
  public C_Customer(string Cust_Nom_, string Cust_PreNom_, string Cust_Tele_, string Cust_Email_, int Cust_CodePostal_, string Cust_Adresse_, string Cust_PassWord_)
  {
   Cust_Nom = Cust_Nom_;
   Cust_PreNom = Cust_PreNom_;
   Cust_Tele = Cust_Tele_;
   Cust_Email = Cust_Email_;
   Cust_CodePostal = Cust_CodePostal_;
   Cust_Adresse = Cust_Adresse_;
   Cust_PassWord = Cust_PassWord_;
  }
  public C_Customer(int Cust_ID_, string Cust_Nom_, string Cust_PreNom_, string Cust_Tele_, string Cust_Email_, int Cust_CodePostal_, string Cust_Adresse_, string Cust_PassWord_)
   : this(Cust_Nom_, Cust_PreNom_, Cust_Tele_, Cust_Email_, Cust_CodePostal_, Cust_Adresse_, Cust_PassWord_)
  {
   Cust_ID = Cust_ID_;
  }
  #endregion
  #region Accesseurs
  public int Cust_ID
  {
   get { return _Cust_ID; }
   set { _Cust_ID = value; }
  }
  public string Cust_Nom
  {
   get { return _Cust_Nom; }
   set { _Cust_Nom = value; }
  }
  public string Cust_PreNom
  {
   get { return _Cust_PreNom; }
   set { _Cust_PreNom = value; }
  }
  public string Cust_Tele
  {
   get { return _Cust_Tele; }
   set { _Cust_Tele = value; }
  }
  public string Cust_Email
  {
   get { return _Cust_Email; }
   set { _Cust_Email = value; }
  }
  public int Cust_CodePostal
  {
   get { return _Cust_CodePostal; }
   set { _Cust_CodePostal = value; }
  }
  public string Cust_Adresse
  {
   get { return _Cust_Adresse; }
   set { _Cust_Adresse = value; }
  }
  public string Cust_PassWord
  {
   get { return _Cust_PassWord; }
   set { _Cust_PassWord = value; }
  }
  #endregion
 }
}
