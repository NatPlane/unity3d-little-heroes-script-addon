using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public static partial class ToonLibrary
{
    public static partial class Animations
    {
        public static ToonAnimation RootAnimation { get; set; }

        public static ToonAnimation[] AnimationHubs { get; set; }

        public static Dictionary<string, ToonAnimation> AllAnimations { get; set; }

        public static class GlobalEvents
        {
            public const float Begin = 0f;
            public const float Progress25Percent = 0.1f;
            public const float Progress50Percent = 0.1f;
            public const float Progress75Percent = 0.1f;
            public const float Complete = 1f;
        }

        static Animations()
        {
            Initialize();
        }

        public static void Initialize()
        {
            AllAnimations =
                GetAllAnimations()
                .ToDictionary(r => r.Name, r => r);

            RootAnimation =
                AllAnimations
                .Values
                .Where(r => r.IsRoot)
                .FirstOrDefault();

            AnimationHubs =
                AllAnimations
                .Values
                .Where(r => r.IsAnimationHub)
                .ToArray();
        }

        private static T GetFieldValue<T>(List<FieldInfo> fields, string name)
        {
            var field =
                fields
                .FirstOrDefault(r => r.Name == name);

            return
                field != null ?
                (T)field.GetValue(null) :
                default(T);
        }

        private static List<ToonAnimation> GetAllAnimations()
        {
            var result = new List<ToonAnimation>();

            foreach (var type in typeof(Animations).GetNestedTypes())
            {
                var fields =
                    type
                    .GetFields()
                    .ToList();

                var eventsType =
                    type
                    .GetNestedTypes()
                    .Where(r => r.Name == "Events")
                    .FirstOrDefault();

                if (!fields.Any(r => r.Name == "Name"))
                    continue;

                result.Add(
                    new ToonAnimation
                    {
                        Name =
                            GetFieldValue<string>(fields, "Name"),
                        TriggerName =
                            GetFieldValue<string>(fields, "TriggerName") ??
                            GetFieldValue<string>(fields, "Name"),
                        ParentName =
                            GetFieldValue<string>(fields, "ParentName"),
                        ParentTriggerName =
                            GetFieldValue<string>(fields, "ParentTriggerName") ??
                            GetFieldValue<string>(fields, "ParentName"),
                        IsAnimationHub =
                            GetFieldValue<bool>(fields, "IsAnimationHub"),
                        IsRoot =
                            GetFieldValue<bool>(fields, "IsRoot"),
                        Events =
                            eventsType != null ?
                            eventsType
                            .GetFields()
                            .Where(r => r.FieldType == typeof(System.Single))
                            .Select(r =>
                                new ToonAnimationEvent
                                {
                                    Name = r.Name,
                                    Time = (float)r.GetValue(null)
                                })
                            .ToArray() :
                            new ToonAnimationEvent[0]
                    });
            }

            return result;
        }
    }
}