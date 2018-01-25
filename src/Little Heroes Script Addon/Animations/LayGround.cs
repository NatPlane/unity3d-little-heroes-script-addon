public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class LayGround
        {
            public const string Name = "On the Ground Loop";

            public const string ParentName = Idle.Name;

            public const string TriggerName = "Lay Ground";

            public static class Events
            {
                public static readonly float[] AnyHit = new float[2] { ButtHit, HeadHit };

                public const float ButtHit = 0.48f;
                public const float HeadHit = 0.96f;
            }
        }
    }
}
