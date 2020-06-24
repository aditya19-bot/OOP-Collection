using System;
using System.Collections.Generic;
using System.Text;

namespace TugasLab8
{
    class KaryawanHarian: Karyawan
    {
        public double PendapatanPerJam { get; set; }
        public double HitunganJamKerja { get; set; }
        public override double Pendapatan()
        {
            return PendapatanPerJam * HitunganJamKerja;
        }
    }
}