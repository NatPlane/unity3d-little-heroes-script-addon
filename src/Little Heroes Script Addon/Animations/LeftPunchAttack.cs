public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class LeftPunchAttack
        {
            public const string Name = "Left Punch Attack";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float ArmBack = 0.33f;
                public const float Punch = 0.5f;
            }
        }
    }
}
