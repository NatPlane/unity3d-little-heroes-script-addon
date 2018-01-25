public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class SpearRun
        {
            public const string Name = "Spear Run";

            public const string ParentName = SpearIdle.Name;

            public static class Events
            {
                public static readonly float[] AnyStep = new float[2] { Step1, Step2 };

                public const float Step1 = 0.14f;
                public const float Step2 = 0.64f;
            }
        }
    }
}
