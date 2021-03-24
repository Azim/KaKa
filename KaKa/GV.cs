using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaKa
{
    class GV
    {

        public static int M = 100, MR = 50, MC = 50, ML = 20,  MF = 20;

        public static int nv, nr, nc, nl;
        public static int lp, lm, kp, km;
        public static int k;

        public static int[,] in_r = new int[MR + 1, 2];
        public static int[,] in_c = new int[MC + 1, 2];
        public static int[,] in_l = new int[ML + 1, 2];

        public static float[] z_r = new float[MR + 1];
        public static float[] z_c = new float[MC + 1];
        public static float[] z_l = new float[ML + 1];

        public static float[] f = new float[MF + 1];
        public static int nf;

        public static Complex s;

        public static String filename;
        public static bool flag = false;

    }
}
