public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class FlyRightPunchAttack
        {
            public const string Name = "Fly Right Punch Attack";

            public const string ParentName = FlyIdle.Name;

            public static class Events
            {
                public const float ArmBack = 0.33f;
                public const float Punch = 0.5f;
            }
        }
    }
}
