// FileName: TuningConfig.cs

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class TuningConfigData
{
    public TuningType Type { get; set; } = TuningType.nEDO; // Tuningの種類
    public int Division { get; set; } = 12;
    public List<double> TuningCents { get; set; } = new List<double>();
    public int[] ScaleSteps { get; set; } = new int[12];
    public double[] MappedCents { get; set; } = new double[12];
    public int RelativeStep { get; set; } = 0;
}

public static class TuningConfig
{
    // アプリ起動中の作業データ
    private static TuningConfigData _data = new TuningConfigData();

    // 各プロパティはDataに委譲
    public static TuningType Type
    {
        get => _data.Type;
        set => _data.Type = value;
    }
    public static int Division
    {
        get => _data.Division;
        set => _data.Division = value;
    }
    public static List<double> TuningCents
    {
        get => _data.TuningCents;
        set => _data.TuningCents = value;
    }
    public static int[] ScaleSteps
    {
        get => _data.ScaleSteps;
        set => _data.ScaleSteps = value;
    }
    public static double[] MappedCents
    {
        get => _data.MappedCents;
        set => _data.MappedCents = value;
    }
    public static int RelativeStep
    {
        get => _data.RelativeStep;
        set => _data.RelativeStep = value;
    }

    // JSON保存
    public static void SaveToJson(string path)
    {
        string json = JsonSerializer.Serialize(
            _data,
            new JsonSerializerOptions { WriteIndented = true }
        );
        File.WriteAllText(path, json);
    }

    // JSON読み込み
    public static void LoadFromJson(string path)
    {
        string json = File.ReadAllText(path);
        _data = JsonSerializer.Deserialize<TuningConfigData>(json)
            ?? new TuningConfigData();
    }

    public class TuningConfigData
    {
        public TuningType Type { get; set; } = TuningType.nEDO;
        public int Division { get; set; } = 12;
        public List<double> TuningCents { get; set; } = new List<double>();
        public int[] ScaleSteps { get; set; } = new int[12];
        public double[] MappedCents { get; set; } = new double[12];
        public int RelativeStep { get; set; } = 0;
        public ScaleType ScaleType { get; set; } = ScaleType.UserDefined; // 追加
    }

    // TuningConfigにプロパティを追加
    public static ScaleType ScaleType
    {
        get => _data.ScaleType;
        set => _data.ScaleType = value;
    }
}

public enum TuningType { nEDO, Meantone, JustIntonation, UserDefined }
public enum ScaleType { UserDefined, MOS, Random }

// 日記
// 2026-04-25
// とりあえず両方を実装した。色々とミスり実際プラグインひらくと使えたもんじゃない。
// TuningConfigに各フォームから拾ってきたデータを集結し、ScaleMapperで計算してUstWriteに流し込み書き込む。エラーしかでないのでAIコード読んでもらい相談。ワイは頭が悪い！！