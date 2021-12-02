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
    public partial class Calculator : Form
    {
        public delegate void CreateUpdateEventHandler(Perhitungan perhitungan);

        public event CreateUpdateEventHandler OnCreate;

        public event CreateUpdateEventHandler OnUpdate;

        private bool isNewData = true;

        private Perhitungan perhitungan;

        public Calculator()
        {
            InitializeComponent();
            
        }
        public Calculator(string hasil, Perhitungan obj) : this()
        {
            this.Text = hasil;
            isNewData = false;
            perhitungan = obj;

            txbX.Text = perhitungan.NilaiX;
            txbY.Text = perhitungan.NilaiY;
            cmbOperasi.SelectedIndex = perhitungan.pilihan;
        }
        
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
           
        }

        private void btnproses_Click(object sender, EventArgs e)
        {
            if (isNewData) perhitungan = new Perhitungan();
            perhitungan.NilaiX = txbX.Text;
            perhitungan.NilaiY = txbY.Text;
            perhitungan.pilihan = cmbOperasi.SelectedIndex;

            OnCreate(perhitungan);
            clear();
            
        }

        private void clear() 
        {
            txbX.Text = "";
            txbY.Text= "";
            cmbOperasi.SelectedIndex = -1;
        }

        
    }

}
