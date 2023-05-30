using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurrenncias._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void BtnCharge_Click_1(object sender, EventArgs e)
        {
            LoadingGIF.Visible = true;
            await Task.Delay(5000);
            LoadingGIF.Visible = false;
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
