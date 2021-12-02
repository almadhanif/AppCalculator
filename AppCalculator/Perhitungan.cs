using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculator
{
    public class Perhitungan
    {
        public string NilaiX { get; set; }
        public string NilaiY { get; set; }
        public int pilihan { get; set; }
        public int add(int x, int y)
        {
            return x + y;
        }

        public int minus(int x, int y)
        {
            return x - y;
        }
        public int times(int x, int y)
        {
            return x * y;
        }
        public double decided(double x, double y)
        {
            return x / y;
        }
        
    }

   
}
