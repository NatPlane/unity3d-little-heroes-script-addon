public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class SpearWalkWithRootMotion
        {
            public const string Name = "Spear Walk With Root Motion";

            public const string TriggerName = SpearWalk.Name;

            public const string ParentName = SpearIdle.Name;

            public static class Events
            {
                public static readonly float[] AnyStep = new float[2] { Step1, Step2 };

                public const float Step1 = 0f;
                public const float Step2 = 0.5f;
            }
        }
    }
}
