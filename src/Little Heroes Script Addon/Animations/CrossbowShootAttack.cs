public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class CrossbowShootAttack
        {
            public const string Name = "Crossbow Shoot Attack";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float ArmUp = 0.25f;
                public const float Fire = 0.44f;
            }
        }
    }
}
