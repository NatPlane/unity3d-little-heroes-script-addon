public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class FlyTakeDamage
        {
            public const string Name = "Fly Take Damage";

            public const string ParentName = FlyIdle.Name;

            public static class Events
            {
                public const float Recover = 0.5f;
            }
        }
    }
}
