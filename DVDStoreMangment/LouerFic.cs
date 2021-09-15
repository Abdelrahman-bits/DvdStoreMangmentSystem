using System;
using System.Collections.Generic;
using System.Data;
using DVD_Classes;
using DVD_Gestion;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DVDStoreMangment
{
    public partial class LouerFIc : Form
    {
        string Sconnexion;
        private DataTable dtClients;
        private BindingSource bsCLients;
        private DataTable dtDVD;
        private BindingSource bsDVD;
        public LouerFIc()
        {
            InitializeComponent();
        }
        private void RemplirDGVClient()
        {
            dtClients = new DataTable();
            dtClients.Columns.Add(new DataColumn("dpnID", System.Type.GetType("System.Int32")));
            dtClients.Columns.Add(new DataColumn("dpnNOM"));
            dtClients.Columns.Add(new DataColumn("UserPass"));
            //List<C_Client> ltmp = new G_CLient(Sconnexion).Lire("NOM");
            List<C_Client> ltmp = new G_CLient(Sconnexion).Lire("");
            foreach (C_Client C in ltmp)
                dtClients.Rows.Add(C.Cust_ID, C.Cust_PreNom + " " + C.Cust_Nom, C.Cust_PassWord); 
            bsCLients = new BindingSource();
            bsCLients.DataSource = dtClients;
            dgvUsers.DataSource = bsCLients;
        }
        private void RemplirDGVDvd()
        {
            dtDVD = new DataTable();
            dtDVD.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtDVD.Columns.Add(new DataColumn("Name"));
            dtDVD.Columns.Add(new DataColumn("Category"));
            dtDVD.Columns.Add(new DataColumn("Director"));
            dtDVD.Columns.Add(new DataColumn("Price", System.Type.GetType("System.Single")));
            dtDVD.Columns.Add(new DataColumn("nbInStock", System.Type.GetType("System.Int32")));
            dtDVD.Columns.Add(new DataColumn("Loc_ID", System.Type.GetType("System.Int32")));
            dtDVD.Columns.Add(new DataColumn("quantity", System.Type.GetType("System.Int32")));
            dtDVD.Columns.Add(new DataColumn("MaisonDeEdition"));
            List<C_DVDs> ltmp = new G_DVDs(Sconnexion).Lire("");
            //List<C_DVDs> ltmp = new G_DVDs(Sconnexion).Lire("NOM");
            foreach (C_DVDs C in ltmp)
                dtDVD.Rows.Add(C.Dvd_ID, C.Dvd_Nom,C.Dvd_Category,C.Dvd_Realisateur, C.Dvd_Prix,C.Dvd_NumberInStock,0,0,C.MaisonDeEdition);
            bsDVD = new BindingSource();
            bsDVD.DataSource = dtDVD;
            dgvDVDs.DataSource = bsDVD;
        }
        private void FrontEnd_Load(object sender, EventArgs e)
        {
            Sconnexion = ConfigurationManager.ConnectionStrings["DVDStoreMangment.Properties.Settings.Connetion_String_DVD"].ConnectionString;
            RemplirDGVClient();
            RemplirDGVDvd();
            if (dgvUsers.Rows.Count > 0)
            {
                ActiverClient(true);
                ActiverDVD(true);
            }
            else
            {
                ActiverClient(false);
                ActiverDVD(false);
            }
            if (dgvDVDs.Rows.Count > 0)
            {
                ActiverDVD(true);
            }
            else
            {
                ActiverDVD(false);
            }
        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            if ( (dgvUsers.SelectedRows.Count > 0) && (dgvDVDs.SelectedRows.Count > 0) )
            {
               string passCheck = Interaction.InputBox("What is your PassWord?", "PassWord Check", "PassWord"); //Reference Microsoft.VisualBasic.dll and using Microsoft.VisualBasic
                if (passCheck == (string)(dgvUsers.SelectedRows[0].Cells["UserPass"].Value))
                {
                    MessageBox.Show("PassWord Okay!");
                    float Prix = (float)dgvDVDs.SelectedRows[0].Cells["Price"].Value;
                    int DvdID = (int)dgvDVDs.SelectedRows[0].Cells["ID"].Value;
                    int ClientID = (int)dgvUsers.SelectedRows[0].Cells["cID"].Value;
                    // int quantity = (int)dgvDVDs.SelectedRows[0].Cells["quantity"].Value;
                    string msg = new G_CLient(Sconnexion).Louer(Prix, DvdID, ClientID);
                    if (msg == "you are overdue, you can not Loan.")
                    MessageBox.Show(msg, "Transaction", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    else MessageBox.Show(msg, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemplirDGVDvd();
                }
                else MessageBox.Show("PassWord Not Okay! Please Try Again","Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
               MessageBox.Show("Please select your User and the DVD");
            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ActiverClient(bool lPrincipal)
        {
            btnAddCust.Enabled = lPrincipal;
            tbID.Enabled = tbPrenom.Enabled = tbNom.Enabled = tbMotPasse.Enabled = tbAdress.Enabled = tbEmail.Enabled = tbTelephone.Enabled = tbCodePostal.Enabled = !lPrincipal;
            btnConfirmer.Enabled = btnAnuller.Enabled = !lPrincipal;
        }
        private void ActiverDVD(bool lPrincipal)
        {
            btnAddDVD.Enabled = lPrincipal;
            tbIDdvd.Enabled = tbNbStc.Enabled = tbNomdvd.Enabled = tbPrix.Enabled = tbCategorydvd.Enabled = tbDirecDVD.Enabled  = !lPrincipal;
            btncfrDVD.Enabled = btnAnnDVD.Enabled = !lPrincipal;
        }
        
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            tbID.Text = tbPrenom.Text = tbNom.Text = tbEmail.Text = tbCodePostal.Text = tbTelephone.Text = tbAdress.Text = tbMotPasse.Text = "";
            ActiverClient(false);
            tbNom.Focus();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Trim() == "")
                MessageBox.Show("Put a Client");
            else
             if (tbID.Text == "") //ajout
             {
                int iID = new G_CLient(Sconnexion).Ajouter(tbNom.Text, tbPrenom.Text,tbTelephone.Text,tbEmail.Text, int.Parse(tbCodePostal.Text),tbAdress.Text, tbMotPasse.Text);
                tbID.Text = iID.ToString();
                dtClients.Rows.Add(iID, tbPrenom.Text + " " + tbNom.Text);
             }
            else //modif
            {
                new G_CLient(Sconnexion).Modifier(int.Parse(tbID.Text),tbNom.Text, tbPrenom.Text, tbTelephone.Text, tbEmail.Text, int.Parse(tbCodePostal.Text), tbAdress.Text, tbMotPasse.Text);
                bsCLients.EndEdit();
            }
            ActiverClient(true);
        }

        private void btnAnuller_Click(object sender, EventArgs e)
        {
            ActiverClient(true);
        }

        private void btnAddDVD_Click(object sender, EventArgs e)
        {
            tbIDdvd.Text = tbNbStc.Text = tbNomdvd.Text = tbPrix.Text = tbCategorydvd.Text = tbDirecDVD.Text = "";
            ActiverDVD(false);
            tbNomdvd.Focus();
        }

        private void btncfrDVD_Click(object sender, EventArgs e)
        {
            if (tbNomdvd.Text.Trim() == "")
                MessageBox.Show("Put a DVD");
            else
            if (tbIDdvd.Text == "") //ajout
            {
                int iID = new G_DVDs(Sconnexion).Ajouter(tbNomdvd.Text, tbCategorydvd.Text, int.Parse(tbNbStc.Text), float.Parse(tbPrix.Text), tbDirecDVD.Text);
                tbIDdvd.Text = iID.ToString();
                dtDVD.Rows.Add(iID, tbPrenom.Text + " " + tbNom.Text);
            }
            else //modif
            {
                new G_DVDs(Sconnexion).Modifier(int.Parse(tbIDdvd.Text), tbNomdvd.Text, tbCategorydvd.Text, int.Parse(tbNbStc.Text), float.Parse(tbPrix.Text), tbDirecDVD.Text);
                bsDVD.EndEdit();
            }
            ActiverDVD(true);
        }

        private void btnAnnDVD_Click(object sender, EventArgs e)
        {
            ActiverDVD(true);
        }


        private void btnEditCust_Click(object sender, EventArgs e)
        {

            if (dgvUsers.SelectedRows.Count > 0)
            {
                tbID.Text = dgvUsers.SelectedRows[0].Cells["cID"].Value.ToString();
                C_Client pTmp = new G_CLient(Sconnexion).Lire_ID(int.Parse(tbID.Text));
                tbPrenom.Text = pTmp.Cust_PreNom;
                tbNom.Text = pTmp.Cust_Nom;
                tbEmail.Text = pTmp.Cust_Email;
                if (int.TryParse(tbCodePostal.Text, out int result))
                    result = pTmp.Cust_CodePostal;
                tbAdress.Text = pTmp.Cust_Adress;
                tbTelephone.Text = pTmp.Cust_Tele;
                tbMotPasse.Text = pTmp.Cust_PassWord;
                ActiverClient(false);
            }
            else
                MessageBox.Show("Please select a Row");
        }

        private void btnEditDVD_Click(object sender, EventArgs e)
        {
            if (dgvDVDs.SelectedRows.Count > 0)
            {
                tbIDdvd.Text = dgvDVDs.SelectedRows[0].Cells["ID"].Value.ToString();
                C_DVDs pTmp = new G_DVDs(Sconnexion).Lire_ID(int.Parse(tbIDdvd.Text));
                if (int.TryParse(tbNbStc.Text, out int result))
                result = pTmp.Dvd_NumberInStock;
                tbNomdvd.Text = pTmp.Dvd_Nom;
                if (float.TryParse(tbPrix.Text, out float resultP))
                resultP = pTmp.Dvd_Prix;
                tbDirecDVD.Text = pTmp.Dvd_Realisateur;
                tbCategorydvd.Text = pTmp.Dvd_Category;
                ActiverDVD(false);
            }
            else
                MessageBox.Show("Please select a Row");
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            RemplirDGVClient();
            RemplirDGVDvd();
        }

        private void btnDeleteCustomor_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are You Sure you want to delete This Client?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int ClientID = (int)dgvUsers.SelectedRows[0].Cells["cID"].Value;
                    string msg = new G_CLient(Sconnexion).Supprimer(ClientID);
                    if (msg == "This Customer Has already rented a DVD, He must return it first")
                        MessageBox.Show(msg, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show(msg, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bsCLients.RemoveCurrent();
                    }
                }
            }
            else
                MessageBox.Show("Please select a Row");
        }

        private void btnDeleteDVD_Click(object sender, EventArgs e)
        {
            if (dgvDVDs.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are You Sure you want to delete This DVD?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int DVDid = (int)dgvDVDs.SelectedRows[0].Cells["ID"].Value;
                    string msg = new G_DVDs(Sconnexion).Supprimer(DVDid);
                    if (msg == "This DVD is in Loan, It needs To be returned First")
                        MessageBox.Show(msg, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show(msg, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bsDVD.RemoveCurrent();
                    }
                }
            }
            else
                MessageBox.Show("Please select a Row");
        }
    }
}
