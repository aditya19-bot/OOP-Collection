using System;
using System.Collections.Generic;
using System.Text;

namespace TugasLab8
{
    class Sales: Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Pendapatan()
        {
            return JumlahPenjualan * Komisi;
        }
    }
}