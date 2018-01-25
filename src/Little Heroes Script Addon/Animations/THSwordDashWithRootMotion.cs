public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class THSwordDashWithRootMotion
        {
            public const string Name = "TH Sword Dash With Root Motion";

            public const string TriggerName = "TH Sword Dash";

            public const string ParentName = THSwordIdle.Name;

            public static class Events
            {
                public static readonly float[] AnyStep = new float[2] { Step1, Step2 };

                public const float Step1 = 0.11f;
                public const float Step2 = 0.62f;
            }
        }
    }
}
