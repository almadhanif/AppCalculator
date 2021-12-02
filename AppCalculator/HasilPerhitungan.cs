using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculator
{
    public partial class HasilPerhitungan : Form
    {
        private IList<Perhitungan> listhitungan = new List<Perhitungan>();

        public HasilPerhitungan()
        {
            InitializeComponent();
            
        }
        

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.OnCreate += Calculator_OnCreate;
            calc.ShowDialog();
        }

        private void HasilPerhitungan_Load(object sender, EventArgs e)
        {

        }

        private void lvwhasil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Calculator_OnCreate(Perhitungan perhitungan) 
        {
            var x = int.Parse(perhitungan.NilaiX);
            var y = Convert.ToInt32(perhitungan.NilaiY);

            if (perhitungan.pilihan == 0)
            {
                lvwhasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2} ", x, y, perhitungan.add(x, y)));
            }
            else if (perhitungan.pilihan == 1)
            {
                lvwhasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2} ", x, y, perhitungan.minus(x, y)));
            }
            else if (perhitungan.pilihan == 2)
            { lvwhasil.Items.Add(string.Format("Hasil Perkalian: {0} x {1} = {2} ", x, y, perhitungan.times(x, y))); }

            else if (perhitungan.pilihan == 3)
            { lvwhasil.Items.Add(string.Format("Hasil Pembagian: {0} : {1} = {2} ", x, y, perhitungan.decided(x, y))); }






        }
    }
}
