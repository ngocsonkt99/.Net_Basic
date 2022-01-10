using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17072921_UngNgocSon_N131
{
    public class CuocDT31
    {
        public float CuocDT3(int soPhut, float phiCodinh, bool noiBo, out float soTienTL)
        {
            float cuocDT = 0;
            if (soPhut > 20)
                cuocDT = (soPhut - 20) * 200 + 20 * 400 + 10 * 600;
            else
                if (soPhut > 10)
                cuocDT = (soPhut - 10) * 400 + 10 * 600;
            else
                cuocDT = soPhut * 600;
            cuocDT = cuocDT + phiCodinh;
            soTienTL = 0.01f * cuocDT;
            return cuocDT;
        }

    }
}
