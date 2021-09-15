
namespace DVDStoreMangment
{
    partial class FicConsulter
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
            this.dgvDatas = new System.Windows.Forms.DataGridView();
            this.lbStockLoan = new System.Windows.Forms.Label();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.lbCus = new System.Windows.Forms.Label();
            this.dgvCustDates = new System.Windows.Forms.DataGridView();
            this.btnRefrech = new System.Windows.Forms.Button();
            this.btnBordeau = new System.Windows.Forms.Button();
            this.btnDvdConsultInStock = new System.Windows.Forms.Button();
            this.btnRtrnDVD = new System.Windows.Forms.Button();
            this.FicLoucateurEtDVDs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustDates)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatas
            // 
            this.dgvDatas.AllowUserToAddRows = false;
            this.dgvDatas.AllowUserToDeleteRows = false;
            this.dgvDatas.AllowUserToOrderColumns = true;
            this.dgvDatas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatas.Location = new System.Drawing.Point(13, 191);
            this.dgvDatas.MultiSelect = false;
            this.dgvDatas.Name = "dgvDatas";
            this.dgvDatas.ReadOnly = true;
            this.dgvDatas.RowHeadersVisible = false;
            this.dgvDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatas.Size = new System.Drawing.Size(406, 164);
            this.dgvDatas.TabIndex = 7;
            // 
            // lbStockLoan
            // 
            this.lbStockLoan.AutoSize = true;
            this.lbStockLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockLoan.Location = new System.Drawing.Point(10, 163);
            this.lbStockLoan.Name = "lbStockLoan";
            this.lbStockLoan.Size = new System.Drawing.Size(258, 24);
            this.lbStockLoan.TabIndex = 8;
            this.lbStockLoan.Text = "DVDs In Stock and in Loan";
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.AllowUserToOrderColumns = true;
            this.dgvCust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Location = new System.Drawing.Point(12, 40);
            this.dgvCust.MultiSelect = false;
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.RowHeadersVisible = false;
            this.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCust.Size = new System.Drawing.Size(406, 115);
            this.dgvCust.TabIndex = 9;
            this.dgvCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCust_CellClick);
            // 
            // lbCus
            // 
            this.lbCus.AutoSize = true;
            this.lbCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCus.Location = new System.Drawing.Point(9, 4);
            this.lbCus.Name = "lbCus";
            this.lbCus.Size = new System.Drawing.Size(277, 24);
            this.lbCus.TabIndex = 10;
            this.lbCus.Text = "Customers in order And Late";
            // 
            // dgvCustDates
            // 
            this.dgvCustDates.AllowUserToAddRows = false;
            this.dgvCustDates.AllowUserToDeleteRows = false;
            this.dgvCustDates.AllowUserToOrderColumns = true;
            this.dgvCustDates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCustDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustDates.Location = new System.Drawing.Point(437, 40);
            this.dgvCustDates.Name = "dgvCustDates";
            this.dgvCustDates.ReadOnly = true;
            this.dgvCustDates.RowHeadersVisible = false;
            this.dgvCustDates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustDates.Size = new System.Drawing.Size(403, 115);
            this.dgvCustDates.TabIndex = 11;
            // 
            // btnRefrech
            // 
            this.btnRefrech.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefrech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrech.Location = new System.Drawing.Point(760, 12);
            this.btnRefrech.Name = "btnRefrech";
            this.btnRefrech.Size = new System.Drawing.Size(75, 23);
            this.btnRefrech.TabIndex = 12;
            this.btnRefrech.Text = "Refresh";
            this.btnRefrech.UseVisualStyleBackColor = false;
            this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
            // 
            // btnBordeau
            // 
            this.btnBordeau.BackColor = System.Drawing.Color.Firebrick;
            this.btnBordeau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBordeau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBordeau.Location = new System.Drawing.Point(440, 161);
            this.btnBordeau.Name = "btnBordeau";
            this.btnBordeau.Size = new System.Drawing.Size(204, 42);
            this.btnBordeau.TabIndex = 13;
            this.btnBordeau.Text = "Imprimer bordereau d\'emprunt Pour Ce Client";
            this.btnBordeau.UseVisualStyleBackColor = false;
            this.btnBordeau.Click += new System.EventHandler(this.btnBordeau_Click);
            // 
            // btnDvdConsultInStock
            // 
            this.btnDvdConsultInStock.BackColor = System.Drawing.Color.Firebrick;
            this.btnDvdConsultInStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDvdConsultInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDvdConsultInStock.Location = new System.Drawing.Point(650, 161);
            this.btnDvdConsultInStock.Name = "btnDvdConsultInStock";
            this.btnDvdConsultInStock.Size = new System.Drawing.Size(190, 42);
            this.btnDvdConsultInStock.TabIndex = 14;
            this.btnDvdConsultInStock.Text = "DVD constituant notre stock";
            this.btnDvdConsultInStock.UseVisualStyleBackColor = false;
            this.btnDvdConsultInStock.Click += new System.EventHandler(this.btnDvdConsultInStock_Click);
            // 
            // btnRtrnDVD
            // 
            this.btnRtrnDVD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRtrnDVD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRtrnDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRtrnDVD.Location = new System.Drawing.Point(437, 246);
            this.btnRtrnDVD.Name = "btnRtrnDVD";
            this.btnRtrnDVD.Size = new System.Drawing.Size(398, 109);
            this.btnRtrnDVD.TabIndex = 54;
            this.btnRtrnDVD.Text = "Return DVD";
            this.btnRtrnDVD.UseVisualStyleBackColor = false;
            this.btnRtrnDVD.Click += new System.EventHandler(this.btnRtrnDVD_Click);
            // 
            // FicLoucateurEtDVDs
            // 
            this.FicLoucateurEtDVDs.BackColor = System.Drawing.Color.Firebrick;
            this.FicLoucateurEtDVDs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FicLoucateurEtDVDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FicLoucateurEtDVDs.Location = new System.Drawing.Point(437, 209);
            this.FicLoucateurEtDVDs.Name = "FicLoucateurEtDVDs";
            this.FicLoucateurEtDVDs.Size = new System.Drawing.Size(403, 31);
            this.FicLoucateurEtDVDs.TabIndex = 55;
            this.FicLoucateurEtDVDs.Text = " DVDs avec les loueurs";
            this.FicLoucateurEtDVDs.UseVisualStyleBackColor = false;
            this.FicLoucateurEtDVDs.Click += new System.EventHandler(this.FicLoucateurEtDVDs_Click);
            // 
            // FicConsulter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(847, 367);
            this.Controls.Add(this.FicLoucateurEtDVDs);
            this.Controls.Add(this.btnRtrnDVD);
            this.Controls.Add(this.btnDvdConsultInStock);
            this.Controls.Add(this.btnBordeau);
            this.Controls.Add(this.btnRefrech);
            this.Controls.Add(this.dgvCustDates);
            this.Controls.Add(this.lbCus);
            this.Controls.Add(this.dgvCust);
            this.Controls.Add(this.lbStockLoan);
            this.Controls.Add(this.dgvDatas);
            this.Name = "FicConsulter";
            this.Text = "Consulter";
            this.Load += new System.EventHandler(this.BackEnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustDates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatas;
        private System.Windows.Forms.Label lbStockLoan;
        private System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.Label lbCus;
        private System.Windows.Forms.DataGridView dgvCustDates;
        private System.Windows.Forms.Button btnRefrech;
        private System.Windows.Forms.Button btnBordeau;
        private System.Windows.Forms.Button btnDvdConsultInStock;
        private System.Windows.Forms.Button btnRtrnDVD;
        private System.Windows.Forms.Button FicLoucateurEtDVDs;
    }
}