// FileName : Form3.cs

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

        private void ScaleSetting_Load(
            object sender,
            EventArgs e)
        {
            // テキストフィールドの復元
            if (TuningConfig.ScaleSteps != null)
            {
                UserDifineScale.Text =
                    string.Join(",", TuningConfig.ScaleSteps);
            }

            // ラジオボタンの復元
            switch (TuningConfig.ScaleType)
            {
                case ScaleType.UserDefined:
                    UserDifineScaleButton.Checked = true;
                    break;
                case ScaleType.MOS:
                    MosButton.Checked = true;
                    break;
                case ScaleType.Random:
                    RandomButton.Checked = true;
                    break;
            }

            UserDifineUpDown.Value = TuningConfig.RelativeStep;  // 詳細はForm2のこれを参照せよ。
        }

        private void UserDifineUpDown_ValueChanged(object sender, EventArgs e)　// 相対ステップ。
        {
            // 相対ステップ。
        }

        private void UserDifineScale_TextChanged(object sender, EventArgs e) // ユーザ定義音階
        {
            // ユーザ定義音階
        }



        private void ScaleApply_Click(object sender, EventArgs e)
        {
            try
            {
                // ラジオボタンの選択をTuningConfigに保存
                if (UserDifineScaleButton.Checked)
                    TuningConfig.ScaleType = ScaleType.UserDefined;
                else if (MosButton.Checked)
                    TuningConfig.ScaleType = ScaleType.MOS;
                else if (RandomButton.Checked)
                    TuningConfig.ScaleType = ScaleType.Random;

                if (UserDifineScaleButton.Checked)
                {
                    // 既存のバリデーションと保存処理
                    int relativeStep = (int)UserDifineUpDown.Value;

                    var steps = UserDifineScale.Text
                        .Split(',')
                        .Select(s => int.TryParse(s.Trim(), out int v) ? v : (int?)null)
                        .ToArray();

                    if (steps.Any(s => s == null))
                    {
                        MessageBox.Show(
                            "数値が不正です。\nInvalid values entered.",
                            "入力エラー\nInput Error"
                        );
                        return;
                    }

                    if (steps.Length != 12)
                    {
                        MessageBox.Show(
                            "12個入力してください。\nPlease enter 12 values.",
                            "入力エラー\nInput Error"
                        );
                        return;
                    }

                    int division = TuningConfig.Division;

                    if (steps.Any(s => s.Value < 0 || s.Value >= division))
                    {
                        MessageBox.Show(
                            $"0〜{division - 1} の範囲で入力してください。\nPlease enter values in the range 0〜{division - 1}.",
                            "入力エラー/Input Error"
                        );
                        return;
                    }

                    TuningConfig.ScaleSteps = steps.Select(s => s.Value).ToArray();
                    TuningConfig.RelativeStep = relativeStep;
                    this.DialogResult = DialogResult.OK;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "不明なエラー。\nUnknown error occurred.");
            }
        }

        private void UserDifineScaleButton_CheckedChanged(object sender, EventArgs e)
        {
            // ユーザ定義音階ラジオボタン。
        }

        private void MosButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UserDifineScaleRabel_Click(object sender, EventArgs e)
        {

        }
    }
}
