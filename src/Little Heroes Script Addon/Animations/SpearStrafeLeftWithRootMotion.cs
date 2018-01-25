public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class SpearStrafeLeftWithRootMotion
        {
            public const string Name = "Spear Strafe Left With Root Motion";

            public const string TriggerName = "Spear Strafe Left";

            public const string ParentName = SpearIdle.Name;

            public static class Events
            {
                public static readonly float[] AnyStep = new float[2] { Step1, Step2 };

                public const float Step1 = 0.06f;
                public const float Step2 = 0.5f;
            }
        }
    }
}
