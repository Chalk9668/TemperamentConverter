using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TemperamentConverter
{
    public partial class DivitionSetting : Form
    {
        public DivitionSetting()
        {
            InitializeComponent();
        }

        private void TuningClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EDOPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void nEDORadio_CheckedChanged(object sender, EventArgs e)
        {
            //けしちゃだめ
        }

        private void MeantoneRadio_CheckedChanged(object sender, EventArgs e)
        {
            //けしちゃだめ
        }

        private void JIRadio_CheckedChanged(object sender, EventArgs e)
        {
            //けしちゃだめ
        }

        private void UserDifineRadio_CheckedChanged(object sender, EventArgs e)
        {
            //けしちゃだめ
        }

        private void TuningSetting_Load(object sender, EventArgs e)
        {
            //けしちゃだめ
        }

        private void WholeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EDOPanel.Visible = nEDORadio.Checked;
            JIPanel.Visible = JIRadio.Checked;
            MeantonePanel.Visible = MeantoneRadio.Checked;
            UserDifinePanel.Visible = UserDifineRadio.Checked;
        }
    }
}
