using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Kelompok6
{
    public partial class FormSplashScreenUtama : Form
    {
        public FormSplashScreenUtama()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            timerLoading.Enabled = true;
            progressBarLoading.Increment(4);
            if (progressBarLoading.Value == 100)
            {
                timerLoading.Enabled = false;
                FormUtama formUtama = new FormUtama();
                this.Hide();
                formUtama.ShowDialog();
            }
        }
    }
}
