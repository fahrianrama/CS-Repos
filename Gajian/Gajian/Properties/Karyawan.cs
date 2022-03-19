using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gajian
{
    class Karyawan
    {
        public string nama;
        public string divisi;
        public int lama_kerja;
        public int gaji;

        public Karyawan(string id, string bagian, int tahun, int hasil)
        {
            nama = id;
            divisi = bagian;
            lama_kerja = tahun;
            gaji = hasil;
        }

        public int Hitung()
        {
            if (divisi == "produksi")
            {
                gaji = 3000000;
                if (lama_kerja > 3)
                {
                    int bonus = 500000 * (lama_kerja - 3);
                    gaji += bonus;
                }
                Console.WriteLine("Gaji untuk {0} pada divisi {1} adalah : {2} ", nama, divisi, gaji);
                return gaji;
            }
            else if (divisi == "pemasaran")
            {
                gaji = 3200000;
                if (lama_kerja > 2)
                {
                    int bonus = 400000 * (lama_kerja - 2);
                    gaji += bonus;
                }
                Console.WriteLine("Gaji untuk {0} pada divisi {1} adalah : {2} ", nama, divisi, gaji);
                return gaji;
            }
            else
            {
                gaji = 2800000;
                if (lama_kerja > 3)
                {
                    int bonus = 300000 * (lama_kerja - 3);
                    gaji += bonus;
                }
                Console.WriteLine("Gaji untuk {0} pada divisi {1} adalah : {2} ", nama, divisi, gaji);
                return gaji;
            }
        }
    }
}
