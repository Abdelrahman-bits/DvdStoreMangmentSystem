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
    public partial class WebPage : Form
    {
        public WebPage()
        {
            InitializeComponent();
            webBrowser1.Navigate("file:///D:/Bloc%202/2eme%20quadri/progra.%20m%20Alex/DVDStoreMangment/LeStock.html");
        }


    }
}
