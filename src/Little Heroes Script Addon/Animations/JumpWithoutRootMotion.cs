public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class JumpWithoutRootMotion
        {
            public const string Name = "Jump Without Root Motion";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float Launch = 0f;
                public const float Top = 0.33f;
                public const float Land = 0.5f;
            }
        }
    }
}
