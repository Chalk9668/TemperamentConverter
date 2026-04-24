using System;

public static class ScaleMapper
{
    public static void UserDifineScaleMap()
    {
        for (int i = 0; i < 12; i++)
        {
            int step = TuningConfig.ScaleSteps[i];
            TuningConfig.MappedCents[i] = TuningConfig.TuningCents[step];
        }
    }
}