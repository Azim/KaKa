﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaKa
{
    public partial class FILE : Form
    {
        public FILE()
        {
            InitializeComponent();
        }

        private void IDC_FILEOK_BUTTON_Click(object sender, EventArgs e)
        {
            switch (GV.k)
            {
                case 0:
                    GV.filename = m_file.Text;
                    if (GV.filename != "")
                        fileout(GV.filename);
                    else
                        MessageBox.Show("Введите имя файла");
                    break;
                case 1:
                    GV.filename = m_file.Text;
                    filein(GV.filename);

                    break;
            }
            this.Close();
        }

        private void fileout(String filename)      //Вывод описания схемы в файл
        {
            StreamWriter fout = new StreamWriter(GV.filename);
            String str = "";
            int i;
            str = GV.nv.ToString() + " " + GV.nr.ToString() + " " + GV.nc.ToString() + " " + GV.nl.ToString() 
                + " " + GV.neu.ToString() + " " + GV.nei.ToString() + " " + GV.ntri.ToString() + " " + GV.nou.ToString();

            fout.WriteLine(str);
            for (i = 1; i <= GV.nr; i++)
            {
                str = GV.in_r[i, 0].ToString() + " " + GV.in_r[i, 1].ToString() + " " + GV.z_r[i].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.nc; i++)
            {
                str = GV.in_c[i, 0].ToString() + " " + GV.in_c[i, 1].ToString() + " " + GV.z_c[i].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.nl; i++)
            {
                str = GV.in_l[i, 0].ToString() + " " + GV.in_l[i, 1].ToString() + " " + GV.z_l[i].ToString();
                fout.WriteLine(str);
            }
            for(i = 1; i <= GV.neu; i++)
            {
                str = GV.in_eu[i, 0].ToString() + " " + GV.in_eu[i, 1].ToString() + " "+ GV.in_eu[i, 2].ToString() + " " + GV.in_eu[i, 3].ToString() 
                    + " " + GV.z_eu[i, 0].ToString() + " " + GV.z_eu[i, 1].ToString() + " " + GV.z_eu[i, 2].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.nei; i++)
            {
                str = GV.in_ei[i, 0].ToString() + " " + GV.in_ei[i, 1].ToString() + " " + GV.in_ei[i, 2].ToString() + " " + GV.in_ei[i, 3].ToString()
                    + " " + GV.z_ei[i].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.ntri; i++)
            {
                str = GV.in_tri[i, 0].ToString() + " " + GV.in_tri[i, 1].ToString() + " " + GV.in_tri[i, 2].ToString() + " " + GV.in_tri[i, 3].ToString()
                    + " " + GV.z_tri[i].ToString();
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.nou; i++)
            {
                str = GV.in_ou[i, 1].ToString() + " " + GV.in_ou[i, 2].ToString() + " " + GV.in_ou[i, 3].ToString() + " " + GV.in_ou[i, 4].ToString()
                    + " " + GV.z_ou[i, 0].ToString() + " " + GV.z_ou[i, 1].ToString() + " " + GV.z_ou[i, 2].ToString() + " " + GV.z_ou[i, 3].ToString();
                fout.WriteLine(str);
            }

            fout.Close();
        }


        private void filein(String filename)      //Ввод описания схемы из файла
        {
            StreamReader fin = new StreamReader(GV.filename);
            char[] sep = { ' ' };
            string str = fin.ReadLine();
            String[] s = str.Split(sep, 8);//Значение второго аргумента!!!
            GV.nv = Int32.Parse(s[0]);
            GV.nr = Int32.Parse(s[1]);
            GV.nc = Int32.Parse(s[2]);
            GV.nl = Int32.Parse(s[3]);
            GV.neu = Int32.Parse(s[4]);
            GV.nei = Int32.Parse(s[5]);
            GV.ntri = Int32.Parse(s[6]);
            GV.nou = Int32.Parse(s[7]);

            GV.in_r = new int[GV.nr + 1, 2];
            GV.in_c = new int[GV.nc + 1, 2];
            GV.in_l = new int[GV.nl + 1, 2];
            GV.z_r = new float[GV.nr + 1];
            GV.z_c = new float[GV.nc + 1];
            GV.z_l = new float[GV.nl + 1];

            GV.in_eu = new int[GV.neu + 1, 4];
            GV.z_eu = new float[GV.neu + 1, 3];
            GV.in_ei = new int[GV.nei + 1, 4];
            GV.z_ei = new float[GV.nei + 1];
            GV.in_tri = new int[GV.ntri + 1, 4];
            GV.z_tri = new float[GV.ntri + 1];
            GV.in_ou = new int[GV.nou + 1, 5];
            GV.z_ou = new float[GV.nou + 1, 4];

            for (int i = 1; i <= GV.nr; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_r[i, 0] = Int32.Parse(s[0]);
                GV.in_r[i, 1] = Int32.Parse(s[1]);
                GV.z_r[i] = Single.Parse(s[2]);
            }
            for (int i = 1; i <= GV.nc; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_c[i, 0] = Int32.Parse(s[0]);
                GV.in_c[i, 1] = Int32.Parse(s[1]);
                GV.z_c[i] = Single.Parse(s[2]);
            }
            for (int i = 1; i <= GV.nl; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 3);
                GV.in_l[i, 0] = Int32.Parse(s[0]);
                GV.in_l[i, 1] = Int32.Parse(s[1]);
                GV.z_l[i] = Single.Parse(s[2]);
            }
            for (int i = 1; i <= GV.neu; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 7);
                GV.in_eu[i, 0] = Int32.Parse(s[0]);
                GV.in_eu[i, 1] = Int32.Parse(s[1]);
                GV.in_eu[i, 2] = Int32.Parse(s[2]);
                GV.in_eu[i, 3] = Int32.Parse(s[3]);
                GV.z_eu[i, 0] = Int32.Parse(s[4]);
                GV.z_eu[i, 1] = Int32.Parse(s[5]);
                GV.z_eu[i, 2] = Int32.Parse(s[6]);
            }
            for (int i = 1; i <= GV.nei; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 5);
                GV.in_ei[i, 0] = Int32.Parse(s[0]);
                GV.in_ei[i, 1] = Int32.Parse(s[1]);
                GV.in_ei[i, 2] = Int32.Parse(s[2]);
                GV.in_ei[i, 3] = Int32.Parse(s[3]);
                GV.z_ei[i] = Int32.Parse(s[4]);
            }
            for (int i = 1; i <= GV.ntri; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 5);
                GV.in_tri[i, 0] = Int32.Parse(s[0]);
                GV.in_tri[i, 1] = Int32.Parse(s[1]);
                GV.in_tri[i, 2] = Int32.Parse(s[2]);
                GV.in_tri[i, 3] = Int32.Parse(s[3]);
                GV.z_tri[i] = Int32.Parse(s[4]);
            }
            for (int i = 1; i <= GV.nou; i++)
            {
                str = fin.ReadLine();
                s = str.Split(sep, 8);
                GV.in_ou[i, 1] = Int32.Parse(s[0]);
                GV.in_ou[i, 2] = Int32.Parse(s[1]);
                GV.in_ou[i, 3] = Int32.Parse(s[2]);
                GV.in_ou[i, 4] = Int32.Parse(s[3]);
                GV.z_ou[i, 0] = Int32.Parse(s[4]);
                GV.z_ou[i, 1] = Int32.Parse(s[5]);
                GV.z_ou[i, 2] = Int32.Parse(s[6]);
                GV.z_ou[i, 3] = Int32.Parse(s[7]);
            }

            fin.Close();
        }

    }
}
