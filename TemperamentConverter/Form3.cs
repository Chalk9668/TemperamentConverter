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
            if (TuningConfig.ScaleSteps != null)
            {
                UserDifineScale.Text =
                    string.Join(
                        ",",
                        TuningConfig.ScaleSteps
                    );
            }

            UserDifineUpDown.Value =
                TuningConfig.RelativeStep;  // 詳細はForm2のこれを参照せよ。
        }

        private void UserDifineUpDown_ValueChanged(object sender, EventArgs e)　// 相対ステップ。
        {
            // 相対ステップ。
        }

        private void UserDifineScale_TextChanged(object sender, EventArgs e) // ユーザ定義音階
        {
            // ユーザ定義音階
        }

        private void ScaleApply_Click(object sender, EventArgs e) // 適用してTunignCongifgをいじって終了。
        {
            try
            {
                if (UserDifineScaleButton.Checked)
                {
                    int relativeStep =
                        (int)UserDifineUpDown.Value;

                    var steps =
                        UserDifineScale.Text  // ユーザ定義音階のテキストをカンマで分割して数値に変換。
                        .Split(',')
                        .Select(s =>　int.TryParse(s.Trim(),out int v) ? v : (int?)null) .ToArray();
                    //--------------------------------
                    // 数値チェック
                    //--------------------------------

                    if (steps.Any(s => s == null)) // 下記以外のエラー。
                    {
                        MessageBox.Show(
                            "数値が不正です。",
                            "入力エラー"
                        );
                        return;
                    }

                    if (steps.Length != 12)　//全音名を指定しなかったときのエラー。
                    {
                        MessageBox.Show(
                            "12個入力してください。",
                            "入力エラー"
                        );
                        return;
                    }

                    int division =
                        TuningConfig.Division;

                    if (steps.Any(s => s.Value < 0 || s.Value >= division)) // ステップが0以上division未満だったときのエラー。
                    {
                        MessageBox.Show(
                            $"0〜{division - 1} の範囲で入力してください。",
                            "入力エラー"
                        );
                        return;
                    }

                    //--------------------------------

                    TuningConfig.ScaleSteps =
                        steps.Select(s => s.Value).ToArray();

                    TuningConfig.RelativeStep =
                        relativeStep;

                    this.DialogResult =
                        DialogResult.OK;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "A SPECIFIC ERROR OCCURED!! Zannen!"
                );
            }
        }

        private void UserDifineScaleButton_CheckedChanged(object sender, EventArgs e)
        {
            // ユーザ定義音階ラジオボタン。
        }

        private void MosButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
