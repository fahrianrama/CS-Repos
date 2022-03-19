using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMath
{
    class BangunRuang
    {
        public int jenis;
        public double sisi1;
        public double sisi2;
        public double sisi3;
        public double phi = 3.14;

        public double Volume()
        {
            double volume = 0;
            if (jenis == 1)
            {
                volume = sisi1 * sisi1 * sisi1;
                return volume;
            }
            if (jenis == 2)
            {
                volume = sisi1 * sisi2 * sisi3;
                return volume;
            }
            else if (jenis == 3)
            {
                volume = 0.3 * sisi1 * sisi2;
                return volume;
            }
            else if (jenis == 4)
            {
                volume = sisi1 * sisi2;
                return volume;
            }
            else if (jenis == 5)
            {
                volume = phi * sisi1 * sisi1 * sisi2;
                return volume;
            }
            else if (jenis == 6)
            {
                volume = 0.3 * phi * sisi1 * sisi1 * sisi2;
                return volume;
            }
            else if (jenis == 7)
            {
                volume = 1.3 * phi * sisi1 * sisi1 * sisi1;
                return volume;
            }
            return volume;
        }
        public BangunRuang(int bangun, int sisiA, int sisiB, int sisiC)
        {
            jenis = bangun;
            sisi1 = sisiA;
            sisi2 = sisiB;
            sisi3 = sisiC;
        }
    }
}
