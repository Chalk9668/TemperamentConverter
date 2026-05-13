// FileName: ScaleMapper.cs

using System;
using System.Diagnostics;

public static class ScaleMapper
{
    public static void UserDifineScaleMap()
    {
        int division = TuningConfig.Division;
        double stepSize = 1200.0 / division;

        // RelativeStep適用後、0〜division-1に正規化
        int[] shiftedSteps = TuningConfig.ScaleSteps
            .Select(s => ((s + TuningConfig.RelativeStep) % division + division) % division)
            .ToArray();

        // -division/2〜+division/2に正規化
        int[] normalizedSteps = shiftedSteps
            .Select(s => s > division / 2 ? s - division : s)
            .ToArray();

        // 0に最も近いstepのindexを探す（同距離なら正を優先）
        int originIndex = 0;
        int minDist = int.MaxValue;
        for (int i = 0; i < 12; i++)
        {
            int dist = Math.Abs(normalizedSteps[i]);
            if (dist < minDist || (dist == minDist && normalizedSteps[i] > 0))
            {
                minDist = dist;
                originIndex = i;
            }
        }

        // originIndexをCとして順番に割り当て
        for (int i = 0; i < 12; i++)
        {
            int idx = (originIndex + i) % 12;
            double cent = normalizedSteps[idx] * stepSize - i * 100.0;

            while (cent > 600.0) cent -= 1200.0;
            while (cent < -600.0) cent += 1200.0;

            TuningConfig.MappedCents[i] = cent;
        }
    }
}