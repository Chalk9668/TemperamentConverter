using System;
using System.IO;
using System.Text;  // こいつはShift_JISでファイルを読み書きするために必要らしい（へぇ～）。
using System.Linq;
using System.Collections.Generic;

public static class UstWriter
{
    public static void Write(string ustPath) // 一時ファイルの処理はほぼコピペなので最初に読んだUTAUプラグインの記事を見ると良い。
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        var lines = File.ReadAllLines(
            ustPath,
            Encoding.GetEncoding("shift_jis")
        ).ToList();

        bool inNote = false;
        bool flagsFound = false;

        int lastLyricIndex = -1;
        int currentNoteNum = -1;

        int division = TuningConfig.Division;

        for (int i = 0; i < lines.Count; i++)
        {
            string line = lines[i];

            // ノート開始判定。詳しくはForm1のコード参照。

            if (line.StartsWith("[#") && line.EndsWith("]"))
            {
                // 前ノートにFlagsが無い場合、挿入
                if (inNote &&
                    !flagsFound &&
                    lastLyricIndex >= 0 &&
                    currentNoteNum >= 0)
                {
                    int pitchIndex =
                        currentNoteNum % 12; // 12で割った余りがピッチクラス（C, C#, D, ..., B）に対応する。

                    ScaleMapper.UserDifineScaleMap();

                    double cent =
                        TuningConfig.MappedCents[pitchIndex];

                    int tValue =
                        (int)Math.Round(
                            cent - pitchIndex * 100 // ピッチクラスの基準からのセント差をt値として計算
                        );

                    lines.Insert(
                        lastLyricIndex + 1,
                        $"Flags=t{tValue}"
                    );

                    i++; // 行追加分ずらす
                }


                if (line == "[#PREV]" ||
                    line == "[#NEXT]" ||
                    line == "[#TRACKEND]")
                {
                    inNote = false;
                }
                else
                {
                    inNote = true;

                    flagsFound = false;
                    lastLyricIndex = -1;
                    currentNoteNum = -1;
                }

                continue;
            }

            // 一時ファイルの解析。

            if (!inNote)
                continue;

            if (line.StartsWith("NoteNum="))
            {
                currentNoteNum =
                    int.Parse(
                        line.Substring("NoteNum=".Length)
                    );
            }
            else if (line.StartsWith("Lyric="))
            {
                lastLyricIndex = i;
            }
            else if (line.StartsWith("Flags="))
            {
                flagsFound = true;

                if (currentNoteNum >= 0)
                {
                    int pitchIndex =
                        currentNoteNum % 12; // 12で割った余りがピッチクラス（C, C#, D, ..., B）に対応する。

                    double cent =
                        TuningConfig.MappedCents[pitchIndex];

                    int tValue =
                        (int)Math.Round(
                            cent - pitchIndex * 100 // ピッチクラスの基準からのセント差をt値として計算
                        );

                    string flagsValue =
                        line.Substring("Flags=".Length);

                    lines[i] =
                        "Flags=" +
                        SetTFlag(flagsValue, tValue);
                }
            }
        }

        File.WriteAllLines(
            ustPath,
            lines,
            Encoding.GetEncoding("shift_jis")
        );
    }

    // Flags文字列にtフラグを追加・更新する。
    private static string SetTFlag(
        string flags,
        int tValue
    )
    {
        if (string.IsNullOrWhiteSpace(flags))
        {
            return $"t{tValue}";
        }

        // tフラグ削除
        var parts =
            flags
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries) .Where(p => !p.StartsWith("t")) .ToList();

        // 新しいt追加
        parts.Add($"t{tValue}");

        return string.Join("", parts);
    }
}