public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class Victory
        {
            public const string Name = "Victory";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float Launch = 0.25f;
                public const float Top = 0.5f;
                public const float Land = 0.62f;
            }
        }
    }
}
