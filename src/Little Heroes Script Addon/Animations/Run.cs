public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class Run
        {
            public const string Name = "Run";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public static readonly float[] AnyStep = new float[2] { Step1, Step2 };

                public const float Step1 = 0.14f;
                public const float Step2 = 0.64f;
            }
        }
    }
}
