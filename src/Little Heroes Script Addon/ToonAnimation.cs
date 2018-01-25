public class ToonAnimation
{
    public string Name { get; set; }

    public string ParentName { get; set; }

    public string TriggerName { get; set; }

    public string ParentTriggerName { get; set; }

    public bool IsAnimationHub { get; set; }

    public bool IsRoot { get; set; }

    public ToonAnimationEvent[] Events { get; set; }

    public ToonAnimation()
    {
        Events = new ToonAnimationEvent[0];
    }
}