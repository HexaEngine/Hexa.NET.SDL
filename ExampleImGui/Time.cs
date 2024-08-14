namespace ExampleImGui
{
    using System;
    using System.Diagnostics;

    public static class Time
    {
        private static long last;
        private static double cumulativeFrameTime;

        public static float Delta { get; private set; }

        public static double CumulativeFrameTime => cumulativeFrameTime;

        public static void Initialize()
        {
            last = Stopwatch.GetTimestamp();
            cumulativeFrameTime = 0;
        }

        public static void FrameUpdate()
        {
            long now = Stopwatch.GetTimestamp();
            double deltaTime = ((double)now - last) / Stopwatch.Frequency;

            // Calculate the frame time by the time difference over the timer speed resolution.
            Delta = (float)deltaTime;
            cumulativeFrameTime += Delta;

            if (deltaTime == 0 || deltaTime < 0)
            {
                throw new InvalidOperationException();
            }

            last = now;
        }
    }
}