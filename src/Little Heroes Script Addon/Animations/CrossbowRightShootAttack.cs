public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class CrossbowRightShootAttack
        {
            public const string Name = "Crossbow Right Shoot Attack";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float ArmUp = 0.25f;
                public const float Fire = 0.44f;
            }
        }
    }
}
