using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUGAS8._2596.ClassAnak;
using TUGAS8._2596.ClassInduk;


namespace TUGAS8._2596
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 (Pertemuan 11) - Polymorphsim, Abstraction & Collection";

            ClassAnak.KaryawanTetap karyawanTetap = new ClassAnak.KaryawanTetap();
            karyawanTetap.NIK = 2596;
            karyawanTetap.NAMA = "BUDHI";
            karyawanTetap.gajibulanan = 9000000;

            ClassAnak.KaryawanHarian karyawanHarian = new ClassAnak.KaryawanHarian();
            karyawanHarian.NIK = 2725;
            karyawanHarian.NAMA = "RAIHAN";
            karyawanHarian.jumlahjamkerja = 10;
            karyawanHarian.upahperjam = 250000;

            ClassAnak.Sales sales = new ClassAnak.Sales();
            sales.NIK = 2888;
            sales.NAMA = "JULIAN";
            sales.jumlahpenjualan = 47;
            sales.komisi = 100000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, NAMA: {2}, GAJI: {3:N0}", noUrut, karyawan.NIK, karyawan.NAMA, karyawan.GAJI());
                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
