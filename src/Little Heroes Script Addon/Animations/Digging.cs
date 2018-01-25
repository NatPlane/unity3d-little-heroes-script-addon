public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class Digging
        {
            public const string Name = "Digging";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float ArmUp = 0.32f;
                public const float Dig = 0.5f;
            }
        }
    }
}
