using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaKa
{
    public partial class RED : Form
    {
        public RED()
        {
            InitializeComponent();
        }

        private void m_redlst_DoubleClick(object sender, EventArgs e)
        {
            m_np1.Show();
            m_nm1.Show();
            m_np2.Show();
            m_nm2.Show();
            m_z1.Show();
            m_z2.Show();
            m_z3.Show();
            m_z4.Show();
            m_z5.Show();
            m_z6.Show();
            IDC_NP1_STATIC.Show();
            IDC_NM1_STATIC.Show();
            IDC_NP2_STATIC.Show();
            IDC_NM2_STATIC.Show();
            IDC_Z1_STATIC.Show();
            IDC_Z2_STATIC.Show();
            IDC_Z3_STATIC.Show();
            IDC_Z4_STATIC.Show();
            IDC_Z5_STATIC.Show();
            IDC_Z6_STATIC.Show();
            m_np1.Text = "";
            m_nm1.Text = "";
            m_np2.Text = "";
            m_nm2.Text = "";
            m_z1.Text = "";
            m_z2.Text = "";
            m_z3.Text = "";
            m_z4.Text = "";
            m_z5.Text = "";
            m_z6.Text = "";
            //Выбор типа компонента из списка и настройка панели
            int idx = m_redlst.SelectedIndex;
            switch (idx)
            {
                case 0:
                case 1:
                case 2:
                    IDC_NP2_STATIC.Text = "n+";
                    IDC_NM2_STATIC.Text = "n-";
                    IDC_Z1_STATIC.Text = "Значение";
                    m_np1.Hide();
                    m_nm1.Hide();
                    m_z2.Hide();
                    m_z3.Hide();
                    m_z4.Hide();
                    m_z5.Hide();
                    m_z6.Hide();
                    IDC_NP1_STATIC.Hide();
                    IDC_NM1_STATIC.Hide();
                    IDC_Z2_STATIC.Hide();
                    IDC_Z3_STATIC.Hide();
                    IDC_Z4_STATIC.Hide();
                    IDC_Z5_STATIC.Hide();
                    IDC_Z6_STATIC.Hide();
                    break;
                case 3:
                    IDC_NP1_STATIC.Text = "n1+";
                    IDC_NM1_STATIC.Text = "n1-";
                    IDC_NP2_STATIC.Text = "n2+";
                    IDC_NM2_STATIC.Text = "n2-";
                    IDC_Z1_STATIC.Text = "y0";
                    IDC_Z2_STATIC.Text = "T1";
                    IDC_Z3_STATIC.Text = "T2";
                    m_z4.Hide();
                    m_z5.Hide();
                    m_z6.Hide();
                    break;
                case 4:
                case 5:
                    IDC_NP1_STATIC.Text = "n1+";
                    IDC_NM1_STATIC.Text = "n1-";
                    IDC_NP2_STATIC.Text = "n2+";
                    IDC_NM2_STATIC.Text = "n2-";
                    IDC_Z1_STATIC.Text = "Значение";
                    m_z2.Hide();
                    m_z3.Hide();
                    m_z4.Hide();
                    m_z5.Hide();
                    m_z6.Hide();
                    break;
                case 6:
                    IDC_NP1_STATIC.Text = "n1+";
                    IDC_NM1_STATIC.Text = "n1-";
                    IDC_NP2_STATIC.Text = "n2+";
                    IDC_NM2_STATIC.Text = "n2-";
                    IDC_Z1_STATIC.Text = "Ri";
                    IDC_Z2_STATIC.Text = "Ro";
                    IDC_Z3_STATIC.Text = "m";
                    IDC_Z4_STATIC.Text = "ft";
                    m_z5.Hide();
                    m_z6.Hide();
                    break;
            }
            m_n.Focus();
        }

        private void IDC_OUT_BUTTON_Click(object sender, EventArgs e)
        {
            int idx = m_redlst.SelectedIndex;
            GV.k = Int32.Parse(m_n.Text);
            switch (idx)
            {
                case 0:
                    m_np2.Text = GV.in_r[GV.k, 0].ToString();
                    m_nm2.Text = GV.in_r[GV.k, 1].ToString();
                    m_z1.Text = GV.z_r[GV.k].ToString();
                    break;
                case 1:
                    m_np2.Text = GV.in_c[GV.k, 0].ToString();
                    m_nm2.Text = GV.in_c[GV.k, 1].ToString();
                    m_z1.Text = GV.z_c[GV.k].ToString();
                    break;
                case 2:
                    m_np2.Text = GV.in_l[GV.k, 0].ToString();
                    m_nm2.Text = GV.in_l[GV.k, 1].ToString();
                    m_z1.Text = GV.z_l[GV.k].ToString();
                    break;
                case 3:
                    m_np1.Text = GV.in_eu[GV.k, 0].ToString();
                    m_nm1.Text = GV.in_eu[GV.k, 1].ToString();
                    m_np2.Text = GV.in_eu[GV.k, 2].ToString();
                    m_nm2.Text = GV.in_eu[GV.k, 3].ToString();
                    m_z1.Text = GV.z_eu[GV.k, 0].ToString();
                    m_z2.Text = GV.z_eu[GV.k, 1].ToString();
                    m_z3.Text = GV.z_eu[GV.k, 2].ToString();
                    break;
                case 4:
                    m_np1.Text = GV.in_ei[GV.k, 0].ToString();
                    m_nm1.Text = GV.in_ei[GV.k, 1].ToString();
                    m_np2.Text = GV.in_ei[GV.k, 2].ToString();
                    m_nm2.Text = GV.in_ei[GV.k, 3].ToString();
                    m_z1.Text = GV.z_ei[GV.k].ToString();
                    break;
                case 5:
                    m_np1.Text = GV.in_tri[GV.k, 0].ToString();
                    m_nm1.Text = GV.in_tri[GV.k, 1].ToString();
                    m_np2.Text = GV.in_tri[GV.k, 2].ToString();
                    m_nm2.Text = GV.in_tri[GV.k, 3].ToString();
                    m_z1.Text = GV.z_tri[GV.k].ToString();
                    break;
                case 6:
                    m_np1.Text = GV.in_ou[GV.k, 1].ToString();
                    m_nm1.Text = GV.in_ou[GV.k, 2].ToString();
                    m_np2.Text = GV.in_ou[GV.k, 3].ToString();
                    m_nm2.Text = GV.in_ou[GV.k, 4].ToString();
                    m_z1.Text = GV.z_ou[GV.k, 0].ToString();
                    m_z2.Text = GV.z_ou[GV.k, 1].ToString();
                    m_z3.Text = GV.z_ou[GV.k, 2].ToString();
                    m_z4.Text = GV.z_ou[GV.k, 3].ToString();
                    break;
            }
            OK.Focus();

        }

        private void IDC_IN_BUTTON_Click(object sender, EventArgs e)
        {
            int idx = m_redlst.SelectedIndex;
            switch (idx)
            {
                case 0:
                    GV.in_r[GV.k, 0] = Int32.Parse(m_np2.Text);
                    GV.in_r[GV.k, 1] = Int32.Parse(m_nm2.Text);
                    float.TryParse(m_z1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_r[GV.k]);
                    break;
                case 1:
                    GV.in_c[GV.k, 0] = Int32.Parse(m_np2.Text);
                    GV.in_c[GV.k, 1] = Int32.Parse(m_nm2.Text);
                    float.TryParse(m_z1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_c[GV.k]);
                    break;
                case 2:
                    GV.in_l[GV.k, 0] = Int32.Parse(m_np2.Text);
                    GV.in_l[GV.k, 1] = Int32.Parse(m_nm2.Text);
                    float.TryParse(m_z1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_l[GV.k]);
                    break;
                case 3:
                    GV.in_eu[GV.k, 0] = Int32.Parse(m_np1.Text);
                    GV.in_eu[GV.k, 1] = Int32.Parse(m_nm1.Text);
                    GV.in_eu[GV.k, 2] = Int32.Parse(m_np2.Text);
                    GV.in_eu[GV.k, 3] = Int32.Parse(m_nm2.Text);
                    float.TryParse(m_z1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[GV.k, 0]);
                    float.TryParse(m_z2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[GV.k, 1]);
                    float.TryParse(m_z3.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_eu[GV.k, 2]);
                    break;
                case 4:
                    GV.in_ei[GV.k, 0] = Int32.Parse(m_np1.Text);
                    GV.in_ei[GV.k, 1] = Int32.Parse(m_nm1.Text);
                    GV.in_ei[GV.k, 2] = Int32.Parse(m_np2.Text);
                    GV.in_ei[GV.k, 3] = Int32.Parse(m_nm2.Text);
                    float.TryParse(m_z1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_ei[GV.k]);
                    break;
                case 5:
                    GV.in_tri[GV.k, 0] = Int32.Parse(m_np1.Text);
                    GV.in_tri[GV.k, 1] = Int32.Parse(m_nm1.Text);
                    GV.in_tri[GV.k, 2] = Int32.Parse(m_np2.Text);
                    GV.in_tri[GV.k, 3] = Int32.Parse(m_nm2.Text);
                    float.TryParse(m_z1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_tri[GV.k]);
                    break;
                case 6:
                    GV.in_ou[GV.k, 1] = Int32.Parse(m_np1.Text);
                    GV.in_ou[GV.k, 2] = Int32.Parse(m_nm1.Text);
                    GV.in_ou[GV.k, 3] = Int32.Parse(m_np2.Text);
                    GV.in_ou[GV.k, 4] = Int32.Parse(m_nm2.Text);
                    float.TryParse(m_z1.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_ou[GV.k, 0]);
                    float.TryParse(m_z2.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_ou[GV.k, 1]);
                    float.TryParse(m_z3.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_ou[GV.k, 2]);
                    float.TryParse(m_z4.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_ou[GV.k, 3]);
                    break;
            }
            OK.Focus();

        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}