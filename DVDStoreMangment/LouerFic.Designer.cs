
namespace DVDStoreMangment
{
    partial class LouerFIc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRent = new System.Windows.Forms.Button();
            this.lbDVD = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.dgvDVDs = new System.Windows.Forms.DataGridView();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbMotPasse = new System.Windows.Forms.Label();
            this.tbMotPasse = new System.Windows.Forms.TextBox();
            this.btnAnuller = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnDVD = new System.Windows.Forms.Button();
            this.btncfrDVD = new System.Windows.Forms.Button();
            this.lbdirec = new System.Windows.Forms.Label();
            this.tbDirecDVD = new System.Windows.Forms.TextBox();
            this.lbCat = new System.Windows.Forms.Label();
            this.tbCategorydvd = new System.Windows.Forms.TextBox();
            this.btnAddDVD = new System.Windows.Forms.Button();
            this.lbtele = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.lbAdress = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lbCodePos = new System.Windows.Forms.Label();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDdvd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomdvd = new System.Windows.Forms.TextBox();
            this.lbPrix = new System.Windows.Forms.Label();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.lbnbSt = new System.Windows.Forms.Label();
            this.tbNbStc = new System.Windows.Forms.TextBox();
            this.btnEditCust = new System.Windows.Forms.Button();
            this.btnEditDVD = new System.Windows.Forms.Button();
            this.btnRefrech = new System.Windows.Forms.Button();
            this.btnDeleteCustomor = new System.Windows.Forms.Button();
            this.btnDeleteDVD = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDVDDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDVDinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaisonDeEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(306, 441);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(204, 27);
            this.btnRent.TabIndex = 9;
            this.btnRent.Text = "Rent DVD";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lbDVD
            // 
            this.lbDVD.AutoSize = true;
            this.lbDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVD.Location = new System.Drawing.Point(468, 6);
            this.lbDVD.Name = "lbDVD";
            this.lbDVD.Size = new System.Drawing.Size(97, 16);
            this.lbDVD.TabIndex = 8;
            this.lbDVD.Text = "Choose DVD";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(12, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(98, 16);
            this.lbUser.TabIndex = 7;
            this.lbUser.Text = "Choose User";
            // 
            // dgvDVDs
            // 
            this.dgvDVDs.AllowUserToAddRows = false;
            this.dgvDVDs.AllowUserToDeleteRows = false;
            this.dgvDVDs.AllowUserToOrderColumns = true;
            this.dgvDVDs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDVDs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDVDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Loc_ID,
            this.quantity,
            this.cDVD,
            this.Category,
            this.cDVDDirector,
            this.Price,
            this.cDVDinStock,
            this.MaisonDeEdition});
            this.dgvDVDs.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDVDs.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDVDs.Location = new System.Drawing.Point(473, 25);
            this.dgvDVDs.MultiSelect = false;
            this.dgvDVDs.Name = "dgvDVDs";
            this.dgvDVDs.ReadOnly = true;
            this.dgvDVDs.RowHeadersVisible = false;
            this.dgvDVDs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDVDs.Size = new System.Drawing.Size(455, 187);
            this.dgvDVDs.TabIndex = 6;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNom,
            this.UserPass});
            this.dgvUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUsers.Location = new System.Drawing.Point(12, 25);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(419, 187);
            this.dgvUsers.TabIndex = 5;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "dpnID";
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 40;
            // 
            // cNom
            // 
            this.cNom.DataPropertyName = "dpnNOM";
            this.cNom.HeaderText = "Nom et PreNom";
            this.cNom.Name = "cNom";
            this.cNom.ReadOnly = true;
            this.cNom.Width = 375;
            // 
            // UserPass
            // 
            this.UserPass.DataPropertyName = "UserPass";
            this.UserPass.HeaderText = "UserPass";
            this.UserPass.Name = "UserPass";
            this.UserPass.ReadOnly = true;
            this.UserPass.Visible = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Firebrick;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(516, 441);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(198, 27);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quit";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.Peru;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(12, 218);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(103, 23);
            this.btnAddCust.TabIndex = 11;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbID.Location = new System.Drawing.Point(12, 264);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(110, 20);
            this.tbID.TabIndex = 12;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(9, 248);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 13);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "ID";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(281, 248);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(49, 13);
            this.lbPrenom.TabIndex = 17;
            this.lbPrenom.Text = "Prenom";
            // 
            // tbPrenom
            // 
            this.tbPrenom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPrenom.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbPrenom.Location = new System.Drawing.Point(284, 264);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(110, 20);
            this.tbPrenom.TabIndex = 16;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(148, 248);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(32, 13);
            this.lbNom.TabIndex = 19;
            this.lbNom.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNom.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbNom.Location = new System.Drawing.Point(151, 264);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(110, 20);
            this.tbNom.TabIndex = 18;
            // 
            // lbMotPasse
            // 
            this.lbMotPasse.AutoSize = true;
            this.lbMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotPasse.Location = new System.Drawing.Point(9, 287);
            this.lbMotPasse.Name = "lbMotPasse";
            this.lbMotPasse.Size = new System.Drawing.Size(86, 13);
            this.lbMotPasse.TabIndex = 21;
            this.lbMotPasse.Text = "Mot De Passe";
            // 
            // tbMotPasse
            // 
            this.tbMotPasse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbMotPasse.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbMotPasse.Location = new System.Drawing.Point(12, 303);
            this.tbMotPasse.Name = "tbMotPasse";
            this.tbMotPasse.PasswordChar = '*';
            this.tbMotPasse.Size = new System.Drawing.Size(110, 20);
            this.tbMotPasse.TabIndex = 20;
            // 
            // btnAnuller
            // 
            this.btnAnuller.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnuller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnuller.Location = new System.Drawing.Point(194, 374);
            this.btnAnuller.Name = "btnAnuller";
            this.btnAnuller.Size = new System.Drawing.Size(171, 28);
            this.btnAnuller.TabIndex = 23;
            this.btnAnuller.Text = "Anuller";
            this.btnAnuller.UseVisualStyleBackColor = false;
            this.btnAnuller.Click += new System.EventHandler(this.btnAnuller_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(20, 374);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(168, 28);
            this.btnConfirmer.TabIndex = 22;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnDVD
            // 
            this.btnAnnDVD.BackColor = System.Drawing.Color.Firebrick;
            this.btnAnnDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnDVD.Location = new System.Drawing.Point(720, 374);
            this.btnAnnDVD.Name = "btnAnnDVD";
            this.btnAnnDVD.Size = new System.Drawing.Size(157, 28);
            this.btnAnnDVD.TabIndex = 25;
            this.btnAnnDVD.Text = "Anuller";
            this.btnAnnDVD.UseVisualStyleBackColor = false;
            this.btnAnnDVD.Click += new System.EventHandler(this.btnAnnDVD_Click);
            // 
            // btncfrDVD
            // 
            this.btncfrDVD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncfrDVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncfrDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncfrDVD.Location = new System.Drawing.Point(541, 374);
            this.btncfrDVD.Name = "btncfrDVD";
            this.btncfrDVD.Size = new System.Drawing.Size(173, 28);
            this.btncfrDVD.TabIndex = 24;
            this.btncfrDVD.Text = "Confirmer";
            this.btncfrDVD.UseVisualStyleBackColor = false;
            this.btncfrDVD.Click += new System.EventHandler(this.btncfrDVD_Click);
            // 
            // lbdirec
            // 
            this.lbdirec.AutoSize = true;
            this.lbdirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdirec.Location = new System.Drawing.Point(468, 287);
            this.lbdirec.Name = "lbdirec";
            this.lbdirec.Size = new System.Drawing.Size(58, 13);
            this.lbdirec.TabIndex = 36;
            this.lbdirec.Text = "Directory";
            // 
            // tbDirecDVD
            // 
            this.tbDirecDVD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDirecDVD.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbDirecDVD.Location = new System.Drawing.Point(471, 303);
            this.tbDirecDVD.Name = "tbDirecDVD";
            this.tbDirecDVD.Size = new System.Drawing.Size(132, 20);
            this.tbDirecDVD.TabIndex = 35;
            // 
            // lbCat
            // 
            this.lbCat.AutoSize = true;
            this.lbCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCat.Location = new System.Drawing.Point(777, 248);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(57, 13);
            this.lbCat.TabIndex = 32;
            this.lbCat.Text = "Category";
            // 
            // tbCategorydvd
            // 
            this.tbCategorydvd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCategorydvd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbCategorydvd.Location = new System.Drawing.Point(778, 264);
            this.tbCategorydvd.Name = "tbCategorydvd";
            this.tbCategorydvd.Size = new System.Drawing.Size(150, 20);
            this.tbCategorydvd.TabIndex = 31;
            // 
            // btnAddDVD
            // 
            this.btnAddDVD.BackColor = System.Drawing.Color.Peru;
            this.btnAddDVD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDVD.Location = new System.Drawing.Point(473, 218);
            this.btnAddDVD.Name = "btnAddDVD";
            this.btnAddDVD.Size = new System.Drawing.Size(104, 23);
            this.btnAddDVD.TabIndex = 26;
            this.btnAddDVD.Text = "Add DVD";
            this.btnAddDVD.UseVisualStyleBackColor = false;
            this.btnAddDVD.Click += new System.EventHandler(this.btnAddDVD_Click);
            // 
            // lbtele
            // 
            this.lbtele.AutoSize = true;
            this.lbtele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtele.Location = new System.Drawing.Point(148, 287);
            this.lbtele.Name = "lbtele";
            this.lbtele.Size = new System.Drawing.Size(67, 13);
            this.lbtele.TabIndex = 38;
            this.lbtele.Text = "Telephone";
            // 
            // tbTelephone
            // 
            this.tbTelephone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTelephone.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbTelephone.Location = new System.Drawing.Point(151, 303);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(110, 20);
            this.tbTelephone.TabIndex = 37;
            // 
            // lbAdress
            // 
            this.lbAdress.AutoSize = true;
            this.lbAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdress.Location = new System.Drawing.Point(281, 287);
            this.lbAdress.Name = "lbAdress";
            this.lbAdress.Size = new System.Drawing.Size(45, 13);
            this.lbAdress.TabIndex = 40;
            this.lbAdress.Text = "Adress";
            // 
            // tbAdress
            // 
            this.tbAdress.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbAdress.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbAdress.Location = new System.Drawing.Point(284, 303);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(110, 20);
            this.tbAdress.TabIndex = 39;
            // 
            // lbCodePos
            // 
            this.lbCodePos.AutoSize = true;
            this.lbCodePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodePos.Location = new System.Drawing.Point(9, 330);
            this.lbCodePos.Name = "lbCodePos";
            this.lbCodePos.Size = new System.Drawing.Size(75, 13);
            this.lbCodePos.TabIndex = 42;
            this.lbCodePos.Text = "Code Postal";
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCodePostal.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbCodePostal.Location = new System.Drawing.Point(12, 346);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(110, 20);
            this.tbCodePostal.TabIndex = 41;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(148, 330);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(37, 13);
            this.lbEmail.TabIndex = 44;
            this.lbEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEmail.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbEmail.Location = new System.Drawing.Point(151, 346);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(243, 20);
            this.tbEmail.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "ID";
            // 
            // tbIDdvd
            // 
            this.tbIDdvd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbIDdvd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbIDdvd.Location = new System.Drawing.Point(473, 264);
            this.tbIDdvd.Name = "tbIDdvd";
            this.tbIDdvd.Size = new System.Drawing.Size(132, 20);
            this.tbIDdvd.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nom";
            // 
            // tbNomdvd
            // 
            this.tbNomdvd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNomdvd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbNomdvd.Location = new System.Drawing.Point(628, 264);
            this.tbNomdvd.Name = "tbNomdvd";
            this.tbNomdvd.Size = new System.Drawing.Size(130, 20);
            this.tbNomdvd.TabIndex = 47;
            // 
            // lbPrix
            // 
            this.lbPrix.AutoSize = true;
            this.lbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrix.Location = new System.Drawing.Point(625, 287);
            this.lbPrix.Name = "lbPrix";
            this.lbPrix.Size = new System.Drawing.Size(28, 13);
            this.lbPrix.TabIndex = 50;
            this.lbPrix.Text = "Prix";
            // 
            // tbPrix
            // 
            this.tbPrix.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPrix.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbPrix.Location = new System.Drawing.Point(628, 303);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(130, 20);
            this.tbPrix.TabIndex = 49;
            // 
            // lbnbSt
            // 
            this.lbnbSt.AutoSize = true;
            this.lbnbSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnbSt.Location = new System.Drawing.Point(775, 287);
            this.lbnbSt.Name = "lbnbSt";
            this.lbnbSt.Size = new System.Drawing.Size(77, 13);
            this.lbnbSt.TabIndex = 52;
            this.lbnbSt.Text = "no. In Stock";
            // 
            // tbNbStc
            // 
            this.tbNbStc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNbStc.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbNbStc.Location = new System.Drawing.Point(778, 303);
            this.tbNbStc.Name = "tbNbStc";
            this.tbNbStc.Size = new System.Drawing.Size(150, 20);
            this.tbNbStc.TabIndex = 51;
            // 
            // btnEditCust
            // 
            this.btnEditCust.BackColor = System.Drawing.Color.Peru;
            this.btnEditCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCust.Location = new System.Drawing.Point(151, 218);
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(125, 23);
            this.btnEditCust.TabIndex = 54;
            this.btnEditCust.Text = "Modify Customer";
            this.btnEditCust.UseVisualStyleBackColor = false;
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // btnEditDVD
            // 
            this.btnEditDVD.BackColor = System.Drawing.Color.Peru;
            this.btnEditDVD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDVD.Location = new System.Drawing.Point(628, 218);
            this.btnEditDVD.Name = "btnEditDVD";
            this.btnEditDVD.Size = new System.Drawing.Size(104, 23);
            this.btnEditDVD.TabIndex = 55;
            this.btnEditDVD.Text = "Modify DVD";
            this.btnEditDVD.UseVisualStyleBackColor = false;
            this.btnEditDVD.Click += new System.EventHandler(this.btnEditDVD_Click);
            // 
            // btnRefrech
            // 
            this.btnRefrech.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRefrech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrech.Location = new System.Drawing.Point(8, 441);
            this.btnRefrech.Name = "btnRefrech";
            this.btnRefrech.Size = new System.Drawing.Size(75, 23);
            this.btnRefrech.TabIndex = 56;
            this.btnRefrech.Text = "Refresh";
            this.btnRefrech.UseVisualStyleBackColor = false;
            this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
            // 
            // btnDeleteCustomor
            // 
            this.btnDeleteCustomor.BackColor = System.Drawing.Color.Peru;
            this.btnDeleteCustomor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteCustomor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomor.Location = new System.Drawing.Point(306, 218);
            this.btnDeleteCustomor.Name = "btnDeleteCustomor";
            this.btnDeleteCustomor.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteCustomor.TabIndex = 57;
            this.btnDeleteCustomor.Text = "Delete Customer";
            this.btnDeleteCustomor.UseVisualStyleBackColor = false;
            this.btnDeleteCustomor.Click += new System.EventHandler(this.btnDeleteCustomor_Click);
            // 
            // btnDeleteDVD
            // 
            this.btnDeleteDVD.BackColor = System.Drawing.Color.Peru;
            this.btnDeleteDVD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDVD.Location = new System.Drawing.Point(773, 218);
            this.btnDeleteDVD.Name = "btnDeleteDVD";
            this.btnDeleteDVD.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteDVD.TabIndex = 58;
            this.btnDeleteDVD.Text = "Delete DVD";
            this.btnDeleteDVD.UseVisualStyleBackColor = false;
            this.btnDeleteDVD.Click += new System.EventHandler(this.btnDeleteDVD_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 30;
            // 
            // Loc_ID
            // 
            this.Loc_ID.DataPropertyName = "Loc_ID";
            this.Loc_ID.HeaderText = "Loc_ID";
            this.Loc_ID.Name = "Loc_ID";
            this.Loc_ID.ReadOnly = true;
            this.Loc_ID.Visible = false;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Visible = false;
            // 
            // cDVD
            // 
            this.cDVD.DataPropertyName = "Name";
            this.cDVD.HeaderText = "DVD";
            this.cDVD.Name = "cDVD";
            this.cDVD.ReadOnly = true;
            this.cDVD.Width = 120;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // cDVDDirector
            // 
            this.cDVDDirector.DataPropertyName = "Director";
            this.cDVDDirector.HeaderText = "Director";
            this.cDVDDirector.Name = "cDVDDirector";
            this.cDVDDirector.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 50;
            // 
            // cDVDinStock
            // 
            this.cDVDinStock.DataPropertyName = "nbInStock";
            this.cDVDinStock.HeaderText = "Number in Stock";
            this.cDVDinStock.Name = "cDVDinStock";
            this.cDVDinStock.ReadOnly = true;
            this.cDVDinStock.Width = 50;
            // 
            // MaisonDeEdition
            // 
            this.MaisonDeEdition.DataPropertyName = "MaisonDeEdition";
            this.MaisonDeEdition.HeaderText = "Maison De Edition";
            this.MaisonDeEdition.Name = "MaisonDeEdition";
            this.MaisonDeEdition.ReadOnly = true;
            // 
            // LouerFIc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(935, 472);
            this.Controls.Add(this.btnDeleteDVD);
            this.Controls.Add(this.btnDeleteCustomor);
            this.Controls.Add(this.btnRefrech);
            this.Controls.Add(this.btnEditDVD);
            this.Controls.Add(this.btnEditCust);
            this.Controls.Add(this.lbnbSt);
            this.Controls.Add(this.tbNbStc);
            this.Controls.Add(this.lbPrix);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomdvd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIDdvd);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbCodePos);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(this.lbAdress);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.lbtele);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.lbdirec);
            this.Controls.Add(this.tbDirecDVD);
            this.Controls.Add(this.lbCat);
            this.Controls.Add(this.tbCategorydvd);
            this.Controls.Add(this.btnAddDVD);
            this.Controls.Add(this.btnAnnDVD);
            this.Controls.Add(this.btncfrDVD);
            this.Controls.Add(this.btnAnuller);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lbMotPasse);
            this.Controls.Add(this.tbMotPasse);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.lbDVD);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.dgvDVDs);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LouerFIc";
            this.Text = "Louer";
            this.Load += new System.EventHandler(this.FrontEnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lbDVD;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.DataGridView dgvDVDs;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbMotPasse;
        private System.Windows.Forms.TextBox tbMotPasse;
        private System.Windows.Forms.Button btnAnuller;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnDVD;
        private System.Windows.Forms.Button btncfrDVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPass;
        private System.Windows.Forms.Label lbdirec;
        private System.Windows.Forms.TextBox tbDirecDVD;
        private System.Windows.Forms.Label lbCat;
        private System.Windows.Forms.TextBox tbCategorydvd;
        private System.Windows.Forms.Button btnAddDVD;
        private System.Windows.Forms.Label lbtele;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label lbAdress;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lbCodePos;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDdvd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomdvd;
        private System.Windows.Forms.Label lbPrix;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label lbnbSt;
        private System.Windows.Forms.TextBox tbNbStc;
        private System.Windows.Forms.Button btnEditCust;
        private System.Windows.Forms.Button btnEditDVD;
        private System.Windows.Forms.Button btnRefrech;
        private System.Windows.Forms.Button btnDeleteCustomor;
        private System.Windows.Forms.Button btnDeleteDVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDVDDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDVDinStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaisonDeEdition;
    }
}