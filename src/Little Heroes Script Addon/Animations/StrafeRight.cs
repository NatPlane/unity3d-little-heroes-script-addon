public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class StrafeRight
        {
            public const string Name = "Strafe Right";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public static readonly float[] AnyStep = new float[2] { Step1, Step2 };

                public const float Step1 = 0.06f;
                public const float Step2 = 0.5f;
            }
        }
    }
}
