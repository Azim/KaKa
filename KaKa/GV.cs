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

        public static int[,] in_eu = new int[neu + 1, 4];//TODO in after neu is initialized
        public static int[] z_eu = new int[neu + 1];
        public static int[,] z_eu_complex = new int[neu + 1,4];

        public static int[,] in_ei = new int[nei + 1, 4];
        public static int[] z_ei = new int[nei + 1];

        public static int[,] in_tri = new int[ntri + 1, 4];//TODO
        public static int[] z_tri = new int[ntri + 1];

        public static int[,] in_ou = new int[nou + 1, 5];
        public static int[,] z_ou = new int[nou + 1, 4];




        public static int[,] in_r = new int[MR + 1, 2];
        public static int[,] in_c = new int[MC + 1, 2];
        public static int[,] in_l = new int[ML + 1, 2];

        public static float[] z_r = new float[MR + 1];
        public static float[] z_c = new float[MC + 1];
        public static float[] z_l = new float[ML + 1];

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
