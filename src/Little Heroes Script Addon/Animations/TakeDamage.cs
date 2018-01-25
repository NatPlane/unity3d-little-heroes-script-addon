public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class TakeDamage
        {
            public const string Name = "Take Damage";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float Recover = 0.5f;
            }
        }
    }
}
