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


        //confusing part
        public static int neu, nei, ntri, nou, n;

        public static int[,] in_eu;//  = new int[neu + 1, 4];
        public static float[,] z_eu;//  = new float[neu + 1, 3];

        public static int[,] in_ei;//  = new int[nei + 1, 4];
        public static float[] z_ei;//  = new float[nei + 1];

        public static int[,] in_tri;//  = new int[ntri + 1, 4];
        public static float[] z_tri;//  = new float[ntri + 1];

        public static int[,] in_ou;//  = new int[nou + 1, 4];
        public static float[,] z_ou;// = new float[nou + 1, 4];


        public static int[,] in_r = new int[nr + 1, 2];
        public static int[,] in_c = new int[nv + 1, 2];
        public static int[,] in_l = new int[nl + 1, 2];

        public static float[] z_r = new float[nr + 1];
        public static float[] z_c = new float[nc + 1];
        public static float[] z_l = new float[nl + 1];

        public static float[] f = new float[MF + 1];
        public static int nf;

        public static Complex s;
        public static Complex[,] w = new Complex[M + 1, M + 1];

        public static float[] kum = new float[MF + 1];
        public static float[] kua = new float[MF + 1];
        public static float[] rim = new float[MF + 1];
        public static float[] ria = new float[MF + 1];
        public static float[] rom = new float[MF + 1];
        public static float[] roa = new float[MF + 1];

        public static String filename;
        public static bool flag = false;

    }
}
