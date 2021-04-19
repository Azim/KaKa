using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaKa
{
    public partial class KaKaForm : Form
    {
        public KaKaForm()
        {
            InitializeComponent();
        }

        private void ID_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            SIZE size = new SIZE();
            size.ShowDialog(this);
            size.Dispose();
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

            if (GV.nr > 0)
            {
                R ir = new R();
                ir.ShowDialog(this);
                ir.Dispose();
            }
            if (GV.nc > 0)
            {
                C ic = new C();
                ic.ShowDialog(this);
                ic.Dispose();
            }
            if (GV.nl > 0)
            {
                L il = new L();
                il.ShowDialog(this);
                il.Dispose();
            }
            if (GV.neu > 0)
            {
                EU eu = new EU();
                eu.ShowDialog(this);
                eu.Dispose();
            }
            if (GV.nei > 0)
            {
                EI ei = new EI();
                ei.ShowDialog(this);
                ei.Dispose();
            }
            if (GV.ntri > 0)
            {
                TRI tri = new TRI();
                tri.ShowDialog(this);
                tri.Dispose();
            }
            if (GV.nou > 0)
            {
                OU ou = new OU();
                ou.ShowDialog(this);
                ou.Dispose();
            }
            DialogResult res = MessageBox.Show("Выводить описание схемы в файл?", "Вывод в файл", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                FILE ofile = new FILE();
                GV.k = 0;
                ofile.ShowDialog(this);
                ofile.Dispose();
            }
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();

            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();

            ID_CALC_Click(sender, e);
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            RED red = new RED();
            red.ShowDialog(this);
            red.Dispose();
        }

        private void ID_FILE_Click(object sender, EventArgs e)
        {
            GV.k = 1;
            FILE file = new FILE();
            try
            {
                file.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            file.Dispose();
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_F_Click(object sender, EventArgs e)
        {
            F f = new F();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void ID_IO_Click(object sender, EventArgs e)
        {
            IO io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_PRIV_Click(object sender, EventArgs e)
        {
            GV.flag = false;
        }

        private void ID_SYS_Click(object sender, EventArgs e)
        {
            GV.flag = true;
        }

        private void ID_INTERNET_Click(object sender, EventArgs e)
        {
            if (!GV.flag)
            {
                INT cint = new INT();
                cint.Show(this);
            }
            else
            {
                //убрал строку iexplore.exe для запуска браузера, установленного пользователем по умолчанию 
                System.Diagnostics.Process.Start("http://azim.icu/MF/Int3d.htm"); 
            }
        }

        private void ID_CALC_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= GV.M; i++) 
                for(int j = 0; j <= GV.M; j++)
                {
                    GV.w[i, j] = new Complex(0, 0);
                }
            GV.n = GV.nv;
            for(int kf = 1; kf <= GV.nf; kf++)
            {
                GV.s = new Complex(0.0, 2 * Math.PI * GV.f[kf]);
                MatrixCreator.form_d(ref GV.in_r, ref GV.z_r, GV.nr, 'R');
                MatrixCreator.form_d(ref GV.in_c, ref GV.z_c, GV.nc, 'C');
                MatrixCreator.form_d(ref GV.in_l, ref GV.z_l, GV.nl, 'L');
                MatrixCreator.form_ei();
                MatrixCreator.form_eu();
                MatrixCreator.form_ou();
                MatrixCreator.form_tri();
                MatrixCreator.form_s();

                if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
                {
                    SF.st();
                    SF.sf1(kf);
                }
                else
                {
                    SF.gauss_c();
                    SF.sf2(kf);
                }

            }
            
            string str = "";
            str = "Результаты моделирования ";
            textBox1.AppendText(str + "\r\n");
            if ((GV.lp == 1) && (GV.lm == 0) && (GV.kp == 2) && (GV.km == 0))
            {
                str = String.Format("{0,-12}{1,-12}{2,-12}{3,-12}{4,-12}{5,-12}{6,-12}", "f кГц", "kum", "kua", "rim", "ria", "rom", "roa");
                textBox1.AppendText(str + "\r\n");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,-12:F2}{1,-12:E2}{2,-12:F2}{3,-12:E2}{4,-12:F2}{5,-12:E2}{6,-12:F2}",
                    GV.f[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf],
                    GV.ria[kf], GV.rom[kf], GV.roa[kf]);
                    textBox1.AppendText(str + "\r\n");
                }
            }
            else
            {
                str = String.Format("{0,-12}{1,-12}{2,-12}{3,-12}{4,-12}", "f кГц", "kum", "kua", "rim", "ria");
                textBox1.AppendText(str + "\r\n");
                for (int kf = 1; kf <= GV.nf; kf++)
                {
                    str = String.Format("{0,-12:F2}{1,-12:E2}{2,-12:F2}{3,-12:E2}{4,-12:F2}",
                    GV.f[kf], GV.kum[kf], GV.kua[kf], GV.rim[kf], GV.ria[kf]);
                    textBox1.AppendText(str + "\r\n");
                }
            }
            
            // Вывод результатов расчета в файл
            DialogResult res = MessageBox.Show("Выводить результаты в файл?",
            "Вывод результатов", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                SF.write_out();
            MessageBox.Show("Выберите в меню дальнейший режим работы",
            "Режим работы", MessageBoxButtons.OK);
        }
    }
}
