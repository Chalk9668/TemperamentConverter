// FileName : TuningConfig.cs

using System;

public static class TuningConfig
{
    public static TuningType Type { get; set; } // どの音律を選択しているか。Form2のラジオボタンで選択する。
    public static int Division { get; set; }
    public static List<double> TuningCents { get; set; } = new List<double>();
    public static int[] ScaleSteps { get; set; } = new int[12];
    public static double[] MappedCents { get; set; } = new double[12];

    public static int RelativeStep { get; set; } = 0;　// ユーザ定義音階の相対ステップ。Form3のUpDownで指定する。
}

public enum TuningType { nEDO, Meantone, JI, UserDefined } // Typeの列挙型宣言。

// 日記
// 2026-04-25
// とりあえず両方を実装した。色々とミスり実際プラグインひらくと使えたもんじゃない。
// TuningConfigに各フォームから拾ってきたデータを集結し、ScaleMapperで計算してUstWriteに流し込み書き込む。エラーしかでないのでAIコード読んでもらい相談。ワイは頭が悪い！！