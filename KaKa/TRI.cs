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
    public partial class TRI : Form
    {
        public TRI()
        {
            InitializeComponent();
        }

        private void IDC_NEXT_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextei.Text);

            GV.in_tri[i, 0] = Int32.Parse(m_np1.Text);
            GV.in_tri[i, 1] = Int32.Parse(m_nm1.Text);
            GV.in_tri[i, 2] = Int32.Parse(m_np2.Text);
            GV.in_tri[i, 3] = Int32.Parse(m_nm2.Text);
            //GV.z_tri[i] = Int32.Parse(m_z.Text);
            float.TryParse(m_z.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out GV.z_tri[i]);
            i++;
            m_nextei.Text = i.ToString();
            if (i <= GV.nr)
            {
                m_np1.Text = "0";
                m_nm1.Text = "0";
                m_np2.Text = "0";
                m_nm2.Text = "0";
                m_z.Text = "0";
                m_np1.Focus();
            }
            else
            {
                this.Close();
            }
        }
    }
}
