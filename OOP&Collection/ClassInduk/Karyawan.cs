using System;
using System.Collections.Generic;
using System.Text;

namespace TugasLab8
{
    public abstract class Karyawan
    {
        public string NIK { get; set; }
        public string NAMA { get; set; }
        public abstract double Pendapatan();
    }
}