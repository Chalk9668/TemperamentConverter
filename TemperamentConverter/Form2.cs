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
        public int ApplyEDO { get; private set; }

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
        private void TuningSetting_Load(
            object sender,
            EventArgs e)
        {
            int n = (int)nEDOselect.Value; // ここでnEDOselectの値を取得して、1ステップあたりの大きさを計算の最初。
            double step = 1200.0 / n; // 1ステップあたりの大きさを計算。
            IndicateEDO1step.Text = $"{step:F3} cent";　// ここで計算結果をボタンの表面に表示するのも最初。

            if (TuningConfig.Division > 0)
            {
                nEDOselect.Value =
                    TuningConfig.Division;
            } //　TuningTypeに応じてやるようにはするが分岐処理は後回し。
        }

        private void WholeRadioButton_CheckedChanged(object sender, EventArgs e)　//　パネル切り替えをする。
        {
            EDOPanel.Visible = nEDORadio.Checked;
            JIPanel.Visible = JIRadio.Checked;
            MeantonePanel.Visible = MeantoneRadio.Checked;
            UserDifinePanel.Visible = UserDifineRadio.Checked;
        }

        private void UserDifinePitches_TextChanged(object sender, EventArgs e)
        {
            // ユーザ定義ピッチ
        }

        private void UserDifineUpDown_ValueChanged(object sender, EventArgs e)
        {
            // 音数
        }

        private void TuningApply_Click(object sender, EventArgs e)
        {
            if (nEDORadio.Checked)
            {
                TuningConfig.Division = (int)nEDOselect.Value;
            }
            else if (JIRadio.Checked)
            {
               // ApplyJI();
            }
            else if (MeantoneRadio.Checked)
            {
               // ApplyMeantone();
            }
            else if (UserDifineRadio.Checked)
            {
               // ApplyUserDefined();
            }


            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void IndicateEDO1step_Click(object sender, EventArgs e)
        {
            // けしちゃだめ
            // どうせTuningApplyで適用されるから、ここでは何もしないんだよ！！！
        }

        private void nEDOselect_ValueChanged(object sender, EventArgs e) // EDOの大きさを取得。
        {
            // 1. nEDOselectから分割数 n を取得。
            int n = (int)nEDOselect.Value;

            // 2. 1200セントを n で割って、1ステップあたりの大きさを計算。
            double step = 1200.0 / n;

            // 3. 表示用のボタン (IndicateEDO1step) の文字を直接更新。
            // ここで計算結果をボタンの表面に表示する。
            IndicateEDO1step.Text = $"{step:F3} cent";
        }
    }
}
