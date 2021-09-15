using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_Classes
{
    public class C_Manager
    {
        #region Données membres
        private int _nbDVDsInLoan;
        private int _IDOfDVDsInLoan;
        private DateTime _DateDeRetour;
        private DateTime _DateDeRent;
        private int _ClientID;
        private int _DVDID;

        #endregion
        public C_Manager()
        {
        }
        public C_Manager(int dvdOut, int iDdvdOut, DateTime DateDeRetour_,int ClientID_,int DVDid_, DateTime DateDeRent_)
        {
            nbDVDsInLoan = dvdOut;
            IDOfDVDsInLoan = iDdvdOut;
            DateDeRetour = DateDeRetour_;
            ClientID = ClientID_;
            DVDID = DVDid_;
            DateDeRent = DateDeRent_;
        }



        public int nbDVDsInLoan { get => _nbDVDsInLoan; set => _nbDVDsInLoan = value; }
        public int IDOfDVDsInLoan { get => _IDOfDVDsInLoan; set => _IDOfDVDsInLoan = value; }
        public DateTime DateDeRetour { get => _DateDeRetour; set => _DateDeRetour = value; }
        public int ClientID { get => _ClientID; set => _ClientID = value; }
        public int DVDID { get => _DVDID; set => _DVDID = value; }
        public DateTime DateDeRent { get => _DateDeRent; set => _DateDeRent = value; }
    }
}
