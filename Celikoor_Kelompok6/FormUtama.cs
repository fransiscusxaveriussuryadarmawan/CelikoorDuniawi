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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            FormLogin frmLogin = new FormLogin();
            frmLogin.Owner = this;
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AturMenu(string peran)
        {
            if(peran == "konsumens")
            {
                akunToolStripMenuItem.Enabled = true;
                masterToolStripMenuItem.Enabled = false;
                laporanToolStripMenuItem.Enabled = false;
                pemesananTiketToolStripMenuItem.Enabled = true;
                penjualanTiketToolStripMenuItem.Enabled = false;
            }
            else if(peran == "pegawais")
            {
                akunToolStripMenuItem.Enabled = true;
                masterToolStripMenuItem.Enabled = true;
                laporanToolStripMenuItem.Enabled = true;
                pemesananTiketToolStripMenuItem.Enabled = false;
                penjualanTiketToolStripMenuItem.Enabled = true;
            }
        }
    }
}
