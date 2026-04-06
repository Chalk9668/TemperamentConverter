using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TemperamentConverter
{
    public partial class ScaleSetting : Form
    {
        public ScaleSetting()
        {
            InitializeComponent();
        }

        private void ScaleClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
