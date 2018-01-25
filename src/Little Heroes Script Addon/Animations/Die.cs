public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class Die
        {
            public const string Name = "Die";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public static readonly float[] AnyHit = new float[3] { KneesHit, HeadHit1, HeadHit2 };

                public const float KneesHit = 0.25f;
                public const float HeadHit1 = 0.5f;
                public const float HeadHit2 = 0.7f;
            }
        }
    }
}
