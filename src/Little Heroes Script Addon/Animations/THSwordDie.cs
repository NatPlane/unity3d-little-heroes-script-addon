public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class THSwordDie
        {
            public const string Name = "TH Sword Die";

            public const string ParentName = THSwordIdle.Name;

            public static class Events
            {
                public static readonly float[] AnyHit = new float[3] { KneesHit, HeadHit1, HeadHit2 };

                public const float KneesHit = 0.28f;
                public const float HeadHit1 = 0.59f;
                public const float HeadHit2 = 0.82f;
            }
        }
    }
}
