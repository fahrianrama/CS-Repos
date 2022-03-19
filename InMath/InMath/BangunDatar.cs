using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMath
{
    class BangunDatar
    {
        public int jenis;
        public double sisi1;
        public double sisi2;
        public double sisi3;
        public double phi = 3.14;

        public double Luas()
        {
            double luas = 0;
            if (jenis == 1)
            {
                luas = sisi1 * sisi2;
                return luas;
            }
            if (jenis == 2)
            {
                luas = sisi1 * sisi2;
                return luas;
            }
            else if (jenis == 3)
            {
                luas = sisi1 * sisi2 / 2;
                return luas;
            }
            else if (jenis == 4)
            {
                luas = (sisi1 + sisi2) / 2 * sisi3;
                return luas;
            }
            else if (jenis == 5)
            {
                luas = sisi1 * sisi2;
                return luas;
            }
            else if (jenis == 6)
            {
                luas = (sisi1 * sisi2) / 2;
                return luas;
            }
            else if (jenis == 7)
            {
                luas = (sisi1 * sisi2) / 2;
                return luas;
            }
            else if (jenis == 8)
            {
                luas = phi * sisi1 * sisi1;
                return luas;
            }
            return luas;
        }
        public BangunDatar(int bangun, int sisiA, int sisiB, int sisiC)
        {
            jenis = bangun;
            sisi1 = sisiA;
            sisi2 = sisiB;
            sisi3 = sisiC;
        }
    }
}
