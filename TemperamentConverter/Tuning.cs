using System;
using System.Collections.Generic;

public static class Tuning
{
    public static void EDO(int division)
    {
        TuningConfig.TuningCents.Clear();

        double step = 1200.0 / division;

        for (int i = 0; i < division; i++)
        {
            TuningConfig.TuningCents.Add(
                i * step
            );
        }
    }
}