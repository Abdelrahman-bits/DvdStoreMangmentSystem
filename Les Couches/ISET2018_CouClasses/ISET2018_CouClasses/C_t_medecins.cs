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
 public class C_t_medecins
 {
  #region Données membres
  private int _IDMed;
  private string _NomMed;
  private string _PrenomMed;
  private int _GSMMed;
  private int _IDSpe;
  #endregion
  #region Constructeurs
  public C_t_medecins()
  { }
  public C_t_medecins(string NomMed_, string PrenomMed_, int GSMMed_, int IDSpe_)
  {
   NomMed = NomMed_;
   PrenomMed = PrenomMed_;
   GSMMed = GSMMed_;
   IDSpe = IDSpe_;
  }
  public C_t_medecins(int IDMed_, string NomMed_, string PrenomMed_, int GSMMed_, int IDSpe_)
   : this(NomMed_, PrenomMed_, GSMMed_, IDSpe_)
  {
   IDMed = IDMed_;
  }
  #endregion
  #region Accesseurs
  public int IDMed
  {
   get { return _IDMed; }
   set { _IDMed = value; }
  }
  public string NomMed
  {
   get { return _NomMed; }
   set { _NomMed = value; }
  }
  public string PrenomMed
  {
   get { return _PrenomMed; }
   set { _PrenomMed = value; }
  }
  public int GSMMed
  {
   get { return _GSMMed; }
   set { _GSMMed = value; }
  }
  public int IDSpe
  {
   get { return _IDSpe; }
   set { _IDSpe = value; }
  }
  #endregion
 }
}
