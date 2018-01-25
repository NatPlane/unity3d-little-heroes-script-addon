public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class Clapping
        {
            public const string Name = "Clapping";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public static readonly float[] AnyClap = new float[4] { Clap1, Clap2, Clap3, Clap4 };

                public const float Clap1 = 0.13f;
                public const float Clap2 = 0.38f;
                public const float Clap3 = 0.62f;
                public const float Clap4 = 0.86f;
            }
        }
    }
}
