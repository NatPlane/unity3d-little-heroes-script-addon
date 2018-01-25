public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class THSwordJumpWithoutRootMotion
        {
            public const string Name = "TH Sword Jump Without Root Motion";

            public const string TriggerName = "TH Sword Jump";

            public const string ParentName = THSwordIdle.Name;

            public static class Events
            {
                public const float Launch = 0f;
                public const float Top = 0.33f;
                public const float Land = 0.6f;
            }
        }
    }
}
