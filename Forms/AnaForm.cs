using AracKiralamaSistemi.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            MusteriKayitForm musteriForm = new MusteriKayitForm();
            musteriForm.ShowDialog(); // Modlu açar
        }

        private void btnKiralamaIslemleri_Click(object sender, EventArgs e)
        {
            KiralamaForm kiralamaForm = new KiralamaForm();
            kiralamaForm.ShowDialog();
        }
    }
}
