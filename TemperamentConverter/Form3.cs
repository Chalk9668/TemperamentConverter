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

        private void ScaleSetting_Load(object sender, EventArgs e)
        {

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
                    // 相対ステップ（安全に取得）
                    int relativeStep = (int)UserDifineUpDown.Value;

                    TuningConfig.RelativeStep = relativeStep;

                    // ユーザ定義音階（安全にパース）
                    var steps = UserDifineScale.Text
                        .Split(',')
                        .Select(s => int.TryParse(s.Trim(), out int v) ? v : (int?)null)
                        .ToArray();

                    if (steps.Any(s => s == null))
                    {
                        MessageBox.Show(
                            "音階入力に不正な値があります。若しくは未入力。",
                            "入力エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }

                    TuningConfig.ScaleSteps = steps
                        .Select(s => s.Value)
                        .ToArray();

                    this.DialogResult = DialogResult.OK;
                }
                else if (MosButton.Checked)
                {
                    // 未実装
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "設定処理中にエラーが発生しました:\n" + ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
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
