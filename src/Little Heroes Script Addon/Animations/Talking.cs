public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static class Talking
        {
            public const string Name = "Talking";

            public const string ParentName = Idle.Name;

            public static class Events
            {
                public const float NodStart = 0.15f;
                public const float RightArmUp = 0.29f;
                public const float NodEnd = 0.34f;
                public const float LeftArmUp = 0.61f;
            }
        }
    }
}
