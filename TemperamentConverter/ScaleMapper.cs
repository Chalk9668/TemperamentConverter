// FileName: ScaleMapper.cs

using System;

public static class ScaleMapper
{
    public static void UserDifineScaleMap()
    {
        int division = TuningConfig.Division;
        double stepSize = 1200.0 / division;

        // RelativeStep適用後のScaleStepsを計算
        int[] shiftedSteps = new int[12];
        for (int i = 0; i < 12; i++)
        {
            int step = (TuningConfig.ScaleSteps[i] + TuningConfig.RelativeStep) % division;
            if (step < 0) step += division;
            shiftedSteps[i] = step;
        }

        // Cに対応するステップのセント値を基準にする
        double baseCent = shiftedSteps[0] * stepSize;

        for (int i = 0; i < 12; i++)
        {
            double cent = shiftedSteps[i] * stepSize - baseCent;

            // 0〜1200¢に正規化
            while (cent < 0.0) cent += 1200.0;
            while (cent >= 1200.0) cent -= 1200.0;

            // 12EDOの各音（100¢刻み）との差分に変換
            cent = cent - i * 100.0;

            // -600〜+600¢に収める
            while (cent > 600.0) cent -= 1200.0;
            while (cent < -600.0) cent += 1200.0;

            TuningConfig.MappedCents[i] = cent;
        }
    }
}