public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class RollBackwardWithRootMotion
        {
            public const string Name = "Roll Backward With Root Motion";

            public const string TriggerName = "Roll Backward";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float OnButt = 0.25f;
                public const float OnHead = 0.7f;
            }
        }
    }
}
