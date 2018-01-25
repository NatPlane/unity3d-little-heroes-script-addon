public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class RollForwardWithoutRootMotion
        {
            public const string Name = "Roll Forward Without Root Motion";

            public const string TriggerName = "Roll Forward";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float OnHead = 0.3f;
                public const float OnButt = 0.75f;
            }
        }
    }
}
