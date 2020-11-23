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
    public partial class F : Form
    {
        int m_f = 0;

        public F()
        {
            InitializeComponent();
        }

        private void IDC_F_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 0;
            IDC_T1.Text = "Значение частоты (кгц)";
            IDC_T2.Text = "";
            IDC_T3.Text = "";
        }

        private void IDC_DF_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 1;
            IDC_T1.Text = "Минимальная частота Fmin(кгц)";
            IDC_T2.Text = "Максимальная частота Fmax(кгц)";
            IDC_T3.Text = "Шаг изменения частоты dF(кгц)";

        }

        private void IDC_KF_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 2;
            IDC_T1.Text = "Минимальная частота Fmin(кгц)";
            IDC_T2.Text = "Максимальная частота Fmax(кгц)";
            IDC_T3.Text = "Отношение соседних частот K";

        }

        private void IDC_FOK_BUTTON_Click(object sender, EventArgs e)
        {
            float fmin, fmax, df, kk;
            int kf;
            switch (m_f)
            {
                case 0:
                    GV.f[1] = Single.Parse(IDC_F1.Text);
                    GV.nf = 1;
                    break;
                case 1:
                    fmin = GV.f[1] = Single.Parse(IDC_F1.Text);
                    fmax = Single.Parse(IDC_F2.Text);
                    df = Single.Parse(IDC_F3.Text);
                    kf = 1;
                    while (GV.f[kf] < fmax)
                    {
                        GV.f[kf + 1] = GV.f[kf] + df;
                        kf = kf + 1;
                    }
                    GV.nf = kf;
                    break;
                case 2:
                    GV.f[1] = Single.Parse(IDC_F1.Text);
                    fmax = Single.Parse(IDC_F2.Text);
                    kk = Single.Parse(IDC_F3.Text);
                    kf = 1;
                    while (GV.f[kf] < fmax)
                    {
                        GV.f[kf + 1] = kk * GV.f[kf];
                        kf = kf + 1;
                    }
                    GV.nf = kf;
                    break;
            }
            this.Close();

        }
    }
}
