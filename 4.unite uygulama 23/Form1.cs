using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_uygulama_23
{
    public partial class Form1 : Form
    {
        List<Sehirler> listSehirler = new List<Sehirler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sehirler sehir = new Sehirler();
            sehir.plaka = txtPlaka.Text;
            sehir.SehirAdi = txtSehirAdi.Text;
            listSehirler.Add(sehir);
            bagla();
        }
        private void bagla()
        {
            cbSehirler.DataSource =null;
            cbSehirler.DataSource =listSehirler;
            cbSehirler.DisplayMember = "SehirAdi";
            cbSehirler.DisplayMember = "plaka";

        }
    }
}
