using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDStoreMangment
{
    public partial class FicMain : Form
    {
        public FicMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFrontEnd_Click(object sender, EventArgs e)
        {
            LouerFIc fe = new LouerFIc();
            fe.Show();
        }

        private void btnBackEnd_Click(object sender, EventArgs e)
        {
            FicConsulter be = new FicConsulter();
            be.Show();
        }
    }
}
