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
    public partial class R : Form
    {
        public R()
        {
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextr.Text);
            GV.in_r[i, 0] = Int32.Parse(m_npr.Text);
            GV.in_r[i, 1] = Int32.Parse(m_nmr.Text);
            float.TryParse(m_zr.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_r[i]);
            i++;
            m_nextr.Text = i.ToString();
            if (i <= GV.nr)
            {
                m_npr.Text = "0";
                m_nmr.Text = "0";
                m_zr.Text = "0";
                m_npr.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
