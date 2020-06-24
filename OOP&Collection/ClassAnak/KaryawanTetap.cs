using System;
using System.Collections.Generic;
using System.Text;

namespace TugasLab8
{
    class KaryawanTetap: Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Pendapatan()
        {
            return GajiBulanan;
        }
    }
}