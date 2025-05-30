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

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            RaporForm raporForm = new RaporForm();
            raporForm.ShowDialog();
        }

        private void btnAracYonetimi_Click(object sender, EventArgs e)
        {
            // AracYonetimForm'dan bir örnek (instance) oluşturuyoruz.
            AracYonetimForm aracForm = new AracYonetimForm();

            // Oluşturduğumuz formu kullanıcıya gösteriyoruz.
            // ShowDialog(), formu modal olarak açar. Yani, bu form kapatılana kadar
            // AnaForm'a geri dönülemez. Bu genellikle alt formlar için tercih edilir.
            aracForm.ShowDialog();

            // Eğer AnaForm'a dönebilmek ve aynı anda AracYonetimForm'u da açık tutmak
            // isterseniz (non-modal), aşağıdaki satırı kullanabilirsiniz:
            // aracForm.Show();
        }
    }
}
