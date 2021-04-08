using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaKa
{
    class MatrixCreator
    {
        public static void form_d(ref int[,] in_d, ref float[]z_d, int nd, char td)
        {
            for(int kd=1; kd <= nd; kd++)
                for(int l = 0; l <= 1; l++)
                {
                    int i = in_d[kd, l];
                    if (i == 0) continue;
                    for(int m = 0; m<=1; m++)
                    {
                        int j = in_d[kd, m];
                        if (j == 0) continue;
                        int g = (1 - 2 * l) * (1 - 2 * m);
                        switch (td)
                        {
                            case 'R':
                                GV.w[i, j] += g / z_d[kd];
                                break;
                            case 'C':
                                GV.w[i, j] += g * GV.s * z_d[kd];
                                break;
                            case 'L':
                                GV.w[i, j] += g / (GV.s * z_d[kd]);
                                break;
                        }
                    }

                }
        }

        /*
        public static void form_eu()
        {
            for(int keu = 1; keu <= GV.neu; keu++)
            {
                int i = GV.n + keu;
                for(int m = 0; m<=3; m++)
                {
                    int j = GV.in_eu[keu, m];
                    int g;
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i, j] += g * GV.z_eu[keu];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }
            GV.n += GV.neu;
        }*/

        public static void form_eu()
        {
            Complex ms = new Complex(0, 0);
            int i, j, g;
            for(int keu = 1; keu<= GV.neu; keu++)
            {
                ms = GV.z_eu[keu, 0] * (1 + GV.s * GV.z_eu[keu, 1]) / (1 + GV.s * GV.z_eu[keu, 2]);
                i = GV.n + keu;
                for(int m = 0; m <= 3; m++)
                {
                    j = GV.in_eu[keu, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i, j] += g * ms;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }
            GV.n += GV.neu;
        }


        public static void form_ei()
        {
            int i1, i2, j, g;
            for(int kei = 1; kei <= GV.nei; kei++)
            {
                i1 = GV.n + kei;
                i2 = i1 + GV.nei;
                //TODO is it true?
                GV.w[i2, i1] = new Complex(GV.z_ei[kei], 0); 
                for(int m = 0; m <= 3; m++)
                {
                    j = GV.in_ei[kei, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i1, j] -= g;
                        GV.w[j, i1] += g;
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i2, j] -= g;
                        GV.w[j, i2] += g;
                    }
                }
            }
            GV.n += 2 * GV.nei;
        }

        public static void form_tri()
        {
            int i, j, g;
            for(int ktri=1;ktri<=GV.ntri; ktri++)
            {
                i = GV.n + ktri;
                for(int m = 0; m <= 3; m++)
                {
                    j = GV.in_tri[ktri, m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        g = 1 - 2 * m;
                        GV.w[i, j] += g * GV.z_tri[ktri];
                        GV.w[j, i] -= g * GV.z_tri[ktri];
                    }
                    else
                    {
                        g = 5 - 2 * m;
                        GV.w[i, j] -= g;
                        GV.w[j, i] += g;
                    }
                }
            }
            GV.n += GV.ntri;
        }

        public static void form_ou()
        {
            Complex[,] y = new Complex[5, 5];
            int[,] in_d = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[] in_ju = new int[4]{ 1, 2, 4, 3 };

            for (int kou = 1; kou <= GV.nou; kou++)
            {
                for (int i = 1; i <= 4; i++)
                    for (int j = 1; j <= 4; j++)
                        y[i, j] = new Complex(0, 0);
                for(int k = 0; k <= 1; k++)
                    for (int l = 0; k <= 1; l++)
                    {
                        int i = in_d[k, l];
                        for (int m = 0; m <= 1; m++)
                        {
                            int j = in_d[k, m];
                            int g = (1 - 2 * l) * (1 - 2 * m);
                            y[i, j] += g / GV.z_ou[kou, k];
                        }
                    }
                Complex ys = GV.z_ou[kou, 2] / (1 + GV.s * 0.16 * GV.z_ou[kou, 2] / GV.z_ou[kou, 3]) / GV.z_ou[kou, 1];
                for (int l = 2; l <= 3; l++)
                {
                    int i = in_ju[l];
                    for (int m = 0; m <= 1; m++)
                    {
                        int j = in_ju[m];
                        int g = (1 - 2 * m) * (5 - 2 * l);
                        y[i, j] += g * ys;
                    }
                }
                for (int i = 1; i <= 4; i++)
                {
                    int ii = GV.in_ou[kou, i];
                    if (ii == 0) continue;
                    for (int j = 1; j <= 4; j++)
                    {
                        int jj = GV.in_ou[kou, j];
                        if (jj == 0) continue;
                        GV.w[ii, jj] += y[i, j];
                    }
                }
            }
        }


        public static void form_s()
        {
            for (int i = 1; i <= GV.M; i++)
                GV.w[i, 0] = new Complex(0,0);
            if (GV.lp != 0)
                GV.w[GV.lp, 0] = new Complex(-1,0);
            if (GV.lm != 0)
                GV.w[GV.lm, 0] = new Complex(1,0);
        }

    }
}
