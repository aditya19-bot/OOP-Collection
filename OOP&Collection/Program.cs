using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Inheritance, Abstraction & Collection";

            //Membuat objek untuk semua karyawan

            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.NIK = "200.111.27795";
            karyawantetap.NAMA = "Aditya Yulis Kusdiyanto";
            karyawantetap.GajiBulanan = 5000000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.NIK = "200.122.43776";
            karyawanharian.NAMA = "Muhammad Ridwan";
            karyawanharian.HitunganJamKerja = 8;
            karyawanharian.PendapatanPerJam = 50000;

            Sales sales = new Sales();
            sales.NIK = "205.145.45578";
            sales.NAMA = "Nur Muhammad";
            sales.JumlahPenjualan = 20;
            sales.Komisi = 80000;

            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.NIK, karyawan.NAMA, karyawan.Pendapatan());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}