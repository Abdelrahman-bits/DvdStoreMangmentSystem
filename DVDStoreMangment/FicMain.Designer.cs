
namespace DVDStoreMangment
{
    partial class FicMain
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
            this.btnFrontEnd = new System.Windows.Forms.Button();
            this.btnBackEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFrontEnd
            // 
            this.btnFrontEnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFrontEnd.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrontEnd.Location = new System.Drawing.Point(30, 59);
            this.btnFrontEnd.Name = "btnFrontEnd";
            this.btnFrontEnd.Size = new System.Drawing.Size(110, 59);
            this.btnFrontEnd.TabIndex = 5;
            this.btnFrontEnd.Text = "Louer";
            this.btnFrontEnd.UseVisualStyleBackColor = false;
            this.btnFrontEnd.Click += new System.EventHandler(this.btnFrontEnd_Click);
            // 
            // btnBackEnd
            // 
            this.btnBackEnd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackEnd.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackEnd.Location = new System.Drawing.Point(191, 59);
            this.btnBackEnd.Name = "btnBackEnd";
            this.btnBackEnd.Size = new System.Drawing.Size(115, 59);
            this.btnBackEnd.TabIndex = 6;
            this.btnBackEnd.Text = "Consulter";
            this.btnBackEnd.UseVisualStyleBackColor = false;
            this.btnBackEnd.Click += new System.EventHandler(this.btnBackEnd_Click);
            // 
            // FicMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DVDStoreMangment.Properties.Resources.DvdStore2;
            this.ClientSize = new System.Drawing.Size(350, 163);
            this.Controls.Add(this.btnBackEnd);
            this.Controls.Add(this.btnFrontEnd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicMain";
            this.Text = "Main App";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFrontEnd;
        private System.Windows.Forms.Button btnBackEnd;
    }
}

