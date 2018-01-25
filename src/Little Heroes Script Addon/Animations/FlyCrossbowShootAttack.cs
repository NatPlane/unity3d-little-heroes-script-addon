public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class FlyCrossbowShootAttack
        {
            public const string Name = "Fly Crossbow Shoot Attack";

            public const string ParentName = FlyIdle.Name;

            public static class Events
            {
                public const float ArmUp = 0.3f;
                public const float Fire = 0.4f;
            }
        }
    }
}
