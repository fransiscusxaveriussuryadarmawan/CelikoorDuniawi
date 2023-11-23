using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Kelompok6
{
    public partial class FormCheckProfile : Form
    {
        //User yang login
        public Konsumen userCheckKonsumen { get; set; }
        public Pegawai userCheckPegawai { get; set; }


        public FormCheckProfile()
        {
            InitializeComponent();
        }

        private void FormCheckProfile_Load(object sender, EventArgs e)
        {
            if (userCheckKonsumen != null)
            {
                labelUsername.Visible = true;
                labelSaldo.Visible = true;
                labelNama.Visible = true;
                labelEmail.Visible = true;
                labelNoHP.Visible = true;
                labelGender.Visible = true;
                labelTglLahir.Visible = true;
                labelHP.Visible = true;
                labelNoGender.Visible = true;
                labelNoTglLahir.Visible = true;

                labelUsername.Text = userCheckKonsumen.Username;
                labelSaldo.Text = userCheckKonsumen.Saldo.ToString("C0", new CultureInfo("id-ID"));
                labelNama.Text = userCheckKonsumen.Nama;
                labelEmail.Text = userCheckKonsumen.Email;
                labelNoHP.Text = userCheckKonsumen.NoHP;
                labelGender.Text = userCheckKonsumen.Gender;
                labelTglLahir.Text = userCheckKonsumen.TglLahir.ToString();
            }

            if (userCheckPegawai != null)
            {
                labelUsername.Visible = true;
                labelNama.Visible = true;
                labelEmail.Visible = true;
                labelRole.Visible = true;

                labelUsername.Text = userCheckPegawai.Username;
                labelNama.Text = userCheckPegawai.Nama;
                labelEmail.Text = userCheckPegawai.Email;
                labelRole.Text = userCheckPegawai.Role;
            }
        }
    }
}
