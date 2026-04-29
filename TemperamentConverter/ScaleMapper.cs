using System;

public static class ScaleMapper
{
    public static void UserDifineScaleMap()
    {
        int division = TuningConfig.Division;

        for (int i = 0; i < 12; i++)
        {
            int baseStep =
                TuningConfig.ScaleSteps[i];

            int step =
                (baseStep +
                 TuningConfig.RelativeStep)
                % division;

            if (step < 0)
                step += division;

            TuningConfig.MappedCents[i] =
                TuningConfig.TuningCents[step];
        }
    }
}