using System;
using System.Collections.Generic;
using System.Data;
using DVD_Classes;
using DVD_Gestion;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace DVDStoreMangment
{
    public partial class FicConsulter : Form
    {
        string Sconnexion;
        private DataTable dtDatas;
        private BindingSource bsDatas;
        private DataTable dtClients;
        private BindingSource bsClients;
        private DataTable dtClientDates;
        private BindingSource bsClientDates;
        public FicConsulter()
        {
            InitializeComponent();
        }
        private void RemplirDGVDatas()
        {
            dtDatas = new DataTable();
            dtDatas.Columns.Add(new DataColumn("DVD ID", System.Type.GetType("System.Int32")));
            dtDatas.Columns.Add(new DataColumn("DVDs Present"));
            dtDatas.Columns.Add(new DataColumn("Number Of DVDs Present", System.Type.GetType("System.Int32")));
            dtDatas.Columns.Add(new DataColumn("DVDs In Loan"));
            dtDatas.Columns.Add(new DataColumn("Number Of DVDs In Loan", System.Type.GetType("System.Int32")));
            //List<C_Client> ltmp = new G_CLient(Sconnexion).Lire("NOM");
            List<C_DVDs> ltmp = new G_DVDs(Sconnexion).Lire("");
            foreach (C_DVDs C in ltmp)
                dtDatas.Rows.Add(C.Dvd_ID, C.Dvd_Nom, C.Dvd_NumberInStock, C.Dvd_Nom);
            List<C_Manager> Mtmp = new G_Manager(Sconnexion).ConsultInLoan(0, 2);
            foreach (C_Manager M in Mtmp)
            {
                dtDatas.Rows[M.IDOfDVDsInLoan - 1][4] = M.nbDVDsInLoan;
            }
            bsDatas = new BindingSource();
            bsDatas.DataSource = dtDatas;
            dgvDatas.DataSource = bsDatas;
            dgvDatas.Columns[0].Width = 20;
        }
        private void RemplirDGVCust()
        {
            dtClients = new DataTable();
            dtClients.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtClients.Columns.Add(new DataColumn("NOM"));
            //List<C_Client> ltmp = new G_CLient(Sconnexion).Lire("NOM");
            List<C_Client> ltmp = new G_CLient(Sconnexion).Lire("");
            foreach (C_Client C in ltmp)
                dtClients.Rows.Add(C.Cust_ID, C.Cust_PreNom + " " + C.Cust_Nom);
            bsClients = new BindingSource();
            bsClients.DataSource = dtClients;
            dgvCust.DataSource = bsClients;
            dgvCust.Columns[1].Width = 300;
            //int iID;
            // return iID = (int)dgvCust.SelectedRows[0].Cells["ID"].Value;
        }
        public void remplirDVGCustDates(int ID)
        {
            dtClientDates = new DataTable();
            dtClientDates.Columns.Add(new DataColumn("DVD", System.Type.GetType("System.Int32")));
            dtClientDates.Columns.Add(new DataColumn("Date Of Rent", System.Type.GetType("System.DateTime"))); 
            dtClientDates.Columns.Add(new DataColumn("Date To Return", System.Type.GetType("System.DateTime"))); 
            dtClientDates.Columns.Add(new DataColumn("Dead Line"));
            dtClientDates.Columns.Add(new DataColumn("Fines"));
            List<C_Manager> Mtmp = new G_Manager(Sconnexion).ConsultClientLoan(ID, 1);
            foreach (C_Manager M in Mtmp)
            {
                string DeadLine;
                string fines;
                if (M.DateDeRetour.Date < DateTime.Now.Date)
                {
                    DeadLine = "Passed";
                    fines = "+10$";
                }
                else
                {
                    DeadLine = "Not Passed";
                    fines = "+0$";
                }

                dtClientDates.Rows.Add(M.DVDID,M.DateDeRent.ToShortDateString(), M.DateDeRetour.ToShortDateString(), DeadLine, fines);
            }
            bsClientDates = new BindingSource();
            bsClientDates.DataSource = dtClientDates;
            dgvCustDates.DataSource = bsClientDates;
        }
        int custid;
        private void dgvCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            remplirDVGCustDates((int)dgvCust.SelectedRows[0].Cells["ID"].Value);
            custid = (int)dgvCust.SelectedRows[0].Cells["ID"].Value;
        }
        private void BackEnd_Load(object sender, EventArgs e)
        {
            Sconnexion = ConfigurationManager.ConnectionStrings["DVDStoreMangment.Properties.Settings.Connetion_String_DVD"].ConnectionString;
            RemplirDGVDatas();
            RemplirDGVCust();
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            RemplirDGVDatas();
            RemplirDGVCust();
        }

        private void btnBordeau_Click(object sender, EventArgs e)
        {
                string filePath = @"D:\Bloc 2\2eme quadri\progra. m Alex\DVDStoreMangment";

                List<C_Manager> Mtmp = new G_Manager(Sconnexion).ConsultClientLoan(custid, 1);
                List<string> stringlist = new List<string>();
                stringlist.Add("-------------------------------------Imprimer bordereau d'emprunt--------------------------------------");
                stringlist.Add($"CLient Numero{custid} : ");
                foreach (C_Manager M in Mtmp)
                {
                    string DeadLine;
                    string fines;
                    if (M.DateDeRetour < DateTime.Now.Date)
                    {
                        DeadLine = "Passed";
                        fines = "+10$";
                    }
                    else
                    {
                        DeadLine = "Not Passed";
                        fines = "+0$";
                    }

                    string Datas = M.DVDID.ToString() + "               " + M.DateDeRetour.ToString() + "      " + DeadLine + "        " + fines;
                    // Create a string array with the lines of text

                    stringlist.Add("DVD ID         Date Pour Retourner         DeadLine        Fines ");
                    stringlist.Add(M.DVDID.ToString() + "               " + M.DateDeRetour.ToString() + "     " + DeadLine + "        " + fines);
                    // Write the string array to a new file named "WriteLines.txt".
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, $"Borderue{custid}.txt")))
                    {
                        foreach (string line in stringlist)
                            outputFile.WriteLine(line);
                    }
                }
        }

        private void btnDvdConsultInStock_Click(object sender, EventArgs e)
        {
            // List<string> stringlist = new List<string>();
            string stringlist = "<!DOCTYPE html><html><head> <meta charset ='utf-8'/><title> Le Stock </title> </head> <style>table, th, td {border: 1px solid black;border - collapse: collapse;}</style> <body> <h2 style = 'color:orange'> Notre Stock </h2> <table style = 'width:100%; background-color:#b8bafd'><tr><th> DVD ID </th><th> DVDs Present </th><th> Number In Stock</th></tr>";

            List<C_DVDs> ltmp = new G_DVDs(Sconnexion).Lire("");
            foreach (C_DVDs C in ltmp)
            {
                stringlist += "<tr>";
                stringlist += $"<td>{C.Dvd_ID}</td>";
                stringlist += $"<td>{C.Dvd_Nom}</td>";
                stringlist += $"<td>{C.Dvd_NumberInStock}</td>";
                stringlist += "</tr>";
            }
            stringlist += "</table>";
            stringlist += "</body>";
            stringlist += "</html>";

            File.WriteAllText(@"D:\Bloc 2\2eme quadri\progra. m Alex\DVDStoreMangment\LeStock.html", stringlist);
            WebPage wb = new WebPage();
            wb.ShowDialog();
        }

        private void btnRtrnDVD_Click(object sender, EventArgs e)
        {
            if ((dgvCust.SelectedRows.Count > 0) && (dgvCustDates.SelectedRows.Count > 0))
            {
                    int DvdID = (int)dgvCustDates.SelectedRows[0].Cells["DVD"].Value;
                    int ClientID = (int)dgvCust.SelectedRows[0].Cells["ID"].Value;
                    DateTime dateDeRetour = (DateTime)dgvCustDates.SelectedRows[0].Cells["Date To Return"].Value;
                    DateTime dateDeLocation = (DateTime)dgvCustDates.SelectedRows[0].Cells["Date Of Rent"].Value;

                // int quantity = (int)dgvDVDs.SelectedRows[0].Cells["quantity"].Value;
                string msg = new G_CLient(Sconnexion).ReturnDVD(DvdID, ClientID, dateDeRetour, dateDeLocation);
                    if (msg == "THERE IS NOTHING")
                        MessageBox.Show(msg, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show(msg, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please select the User and the DVD");
        }

        private void FicLoucateurEtDVDs_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\Bloc 2\2eme quadri\progra. m Alex\DVDStoreMangment";
                List<string> stringlist = new List<string>();
                stringlist.Add("-------------------------------------DVDs Et Louers--------------------------------------");
            for (int i = 1; i <= 10; i++)
            {
                List<C_Manager> Mtmp = new G_Manager(Sconnexion).ConsultClientLoan(i, 1);
                stringlist.Add("                ======================================================================================================                      ");
                stringlist.Add($"CLient Numero{i} : ");
                C_Client pTmp = new G_CLient(Sconnexion).Lire_ID(i);
                string Client_info0 = "Customer PreNom: " + pTmp.Cust_PreNom + " Cust Nom: " + pTmp.Cust_Nom;
                string Client_Add = "Customer Adresse: " + pTmp.Cust_Adress + "  " + pTmp.Cust_CodePostal;
                string Client_Email = "Customer Email: " + pTmp.Cust_Email;
                string Client_pass = "Customer Pass: " + pTmp.Cust_PassWord;
                stringlist.Add(Client_info0); stringlist.Add(Client_Add); stringlist.Add(Client_Email); stringlist.Add(Client_pass);

                foreach (C_Manager M in Mtmp)
                {
                    string DeadLine;
                    string fines;
                    if (M.DateDeRetour < DateTime.Now.Date)
                    {
                        DeadLine = "Passed";
                        fines = "+10$";
                    }
                    else
                    {
                        DeadLine = "Not Passed";
                        fines = "+0$";
                    }

                    string Datas = M.DVDID.ToString() + "               " + M.DateDeRetour.ToString() + "      " + DeadLine + "        " + fines;
                    // Create a string array with the lines of text
                    stringlist.Add("DVD ID         Date Pour Retourner         DeadLine        Fines ");
                    stringlist.Add(M.DVDID.ToString() + "               " + M.DateDeRetour.ToString() + "     " + DeadLine + "        " + fines);
                    // Write the string array to a new file named "WriteLines.txt".
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(filePath, "DVD et Louers.txt")))
                    {
                        foreach (string line in stringlist)
                        outputFile.WriteLine(line);
                    }
                }
   
            }
        }
    }
}



