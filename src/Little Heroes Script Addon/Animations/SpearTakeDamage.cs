public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class SpearTakeDamage
        {
            public const string Name = "Spear Take Damage";

            public const string ParentName = SpearIdle.Name;

            public static class Events
            {
                public const float Recover = 0.5f;
            }
        }
    }
}
