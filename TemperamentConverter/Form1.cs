using System.Text;
using static System.Windows.Forms.DataFormats;

namespace TemperamentConverter
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        // キャンセルボタン「CancelButton_Click」
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 12EDOに戻す処理「Reconvert_Click」
        private void Reconvert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "本当に続けますか？このまま実行すると設定した調律は失われます。",
                "12EDOReconvertWarning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                MessageBox.Show("変更を取りやめました。", "ReturnCancel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (result == DialogResult.Yes)
            {
                try
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    string[] lines = File.ReadAllLines(
                        Environment.GetCommandLineArgs()[1],
                        Encoding.GetEncoding("shift_jis")
                    );

                    bool inNote = false;
                    bool flagsFound = false;
                    int lastLyricIndex = -1;

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string line = lines[i];

                        // セクションヘッダーの検出
                        if (line.StartsWith("[#") && line.EndsWith("]"))
                        {
                            // 前のノートでFlags行が見つからなかった場合、Lyric=の直後に挿入
                            if (inNote && !flagsFound && lastLyricIndex >= 0)
                            {
                                var linesList = lines.ToList();
                                linesList.Insert(lastLyricIndex + 1, "Flags=t0");
                                lines = linesList.ToArray();
                                i++; // 挿入した分インデックスをずらす
                            }

                            if (line == "[#PREV]" || line == "[#NEXT]" || line == "[#TRACKEND]")
                            {
                                inNote = false;
                            }
                            else
                            {
                                inNote = true;
                                flagsFound = false;
                                lastLyricIndex = -1;
                            }
                        }
                        else if (inNote)
                        {
                            if (line.StartsWith("Lyric="))
                            {
                                lastLyricIndex = i;
                            }
                            else if (line.StartsWith("Flags="))
                            {
                                flagsFound = true;
                                string flagsValue = line.Substring("Flags=".Length);
                                lines[i] = "Flags=" + SetTFlag(flagsValue, 0);
                            }
                        }
                    }

                    File.WriteAllLines(
                        Environment.GetCommandLineArgs()[1],
                        lines,
                        Encoding.GetEncoding("shift_jis")
                    );

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("エラーが発生しました:\n" + ex.Message, "エラー",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string SetTFlag(string flags, int value)
        {
            var tPattern = new System.Text.RegularExpressions.Regex(@"t[+-]?\d*");
            string replacement = "t" + value.ToString();

            if (tPattern.IsMatch(flags))
            {
                return tPattern.Replace(flags, replacement);
            }
            else
            {
                return flags + replacement;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BaseFreq_Click(object sender, EventArgs e)
        {

        }

        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void TuningText_Click(object sender, EventArgs e)
        {

        }

        private void Notation_Click(object sender, EventArgs e)
        {

        }

        private void DoTuning_Click(object sender, EventArgs e)
        {
            DivitionSetting f2 = new();
            f2.ShowDialog();
            //分割設定が開く。
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScaleSetting f2 = new();
            f2.ShowDialog();
            //音階設定が開く。
        }

        private void SamplerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InputBaseFreq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}