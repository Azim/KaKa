﻿using System;
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
    public partial class SIZE : Form
    {
        public SIZE()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            GV.nv = Int32.Parse(m_nv.Text);
            GV.nr = Int32.Parse(m_nr.Text);
            GV.nc = Int32.Parse(m_nc.Text);
            GV.nl = Int32.Parse(m_nl.Text);
            GV.nei = Int32.Parse(m_nei.Text);
            GV.neu = Int32.Parse(m_neu.Text);
            GV.ntri = Int32.Parse(m_ntri.Text);
            GV.nou = Int32.Parse(m_nou.Text);

            //...
            this.Close();
        }
    }
}
