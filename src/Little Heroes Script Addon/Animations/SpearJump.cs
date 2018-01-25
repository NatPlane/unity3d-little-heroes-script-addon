public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class SpearJump
        {
            public const string Name = "Spear Jump";

            public const string ParentName = SpearIdle.Name;

            public static class Events
            {
                public const float Launch = 0f;
                public const float Top = 0.33f;
                public const float Land = 0.5f;
            }
        }
    }
}
