using System.Linq;
using UnityEngine;

public class DemoToon : LittleHeroMonoBehaviour
{
    private CharacterController toonCharacterController;
    private AudioSource audioSource;
    private bool jumping;
    private bool casting;

    protected override void Start()
    {
        // TO CONFIGURE TOON TO WORK WITH THIS DEMO:
        //
        // 1. add any prefab hero to the scene
        // 2. add this behavior to the hero
        // 3. add and configure a character controller to the hero
        // 4. add and configure an audio source to the hero
        // 5. Add the prefabs used in the CastSpell method to the resources folder or reconfigure to use from a pre-loader
        // 6. configure and populate this behavior's soundbank with two collections, "Footsteps" and "Cast Spell"

        // only real requirement on all inherited behaviors - must call base start to setup all the bits

        base.Start();

        toonCharacterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();

        // casting

        AddToonAnimationEvent(
            ToonLibrary.Animations.CastSpell.Name,
            ToonLibrary.Animations.CastSpell.Events.Cast,
            "CastSpell");

        AddToonAnimationEvent(
            ToonLibrary.Animations.CastSpell.Name,
            ToonLibrary.Animations.GlobalEvents.Complete,
            "SpellDone");

        // walking

        AddToonAnimationEvent(
            new string[] { ToonLibrary.Animations.Walk.Name, ToonLibrary.Animations.WalkBackward.Name },
            ToonLibrary.Animations.Walk.Events.AnyStep,
            "Step");

        // jump

        AddToonAnimationEvent(
            ToonLibrary.Animations.Jump.Name,
            ToonLibrary.Animations.Jump.Events.Land,
            "Land");

        AddToonAnimationEvent(
            ToonLibrary.Animations.Jump.Name,
            ToonLibrary.Animations.GlobalEvents.Complete,
            "JumpingDone");
    }
    
    public void Fire()
    {
        if (casting)
            return;

        PlayAnimation(ToonLibrary.Animations.CastSpell.Name);

        casting = true;
    }

    public void CastSpell()
    {
        // to get this to work add a sound bank collection of "Cast Spell" and add at least 1 clip

        soundBank.PlayRandomClip(audioSource, "Cast Spell");

        // i threw these prefabs into the resources folder

        Equip(ToonBodyPart.RightHand, "Mace 01 Red");
        Equip(ToonBodyPart.LeftHand, "Shield 02 Blue");
        Equip(ToonBodyPart.Head, "Beard 01 Grey");
        Equip(ToonBodyPart.Head, "Hair Female 18 Black", false);
        Equip(ToonBodyPart.Head, "Mask 03 Blue", false);
        Equip(ToonBodyPart.Back, "Back Prop 01 Black");
    }

    public void SpellDone()
    {
        casting = false;
    }

    public void Step()
    {
        // to get this to work add a sound bank collection of "Footsteps" and add at least 1 clip

        soundBank.PlayRandomClip(audioSource, "Footsteps");
    }

    void Jump()
    {
        if (jumping)
            return;

        jumping = true;

        PlayAnimation(ToonLibrary.Animations.Jump.Name);
    }

    public void Land()
    {
        // to get this to work add a sound bank collection of "Footsteps" and add at least 1 clip

        soundBank.PlayRandomClip(audioSource, "Footsteps");
    }

    public void JumpingDone()
    {
        jumping = false;
    }

    bool IsBusy()
    {
        return casting || jumping;
    }

    void Update()
    {
        // this entire update is obviously too rigid and basic - for demo purposes only

        var move = 
            !toonCharacterController.isGrounded ? 
            Physics.gravity : 
            Vector3.zero;

        if (!IsBusy())
        {
            move +=
                transform.forward * 2.0f * Input.GetAxis("Vertical");

            if (Input.GetAxis("Fire1") != 0)
                Fire();
            else if (Input.GetKey(KeyCode.Space))
                Jump();
            else if (
                (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") != 0) &&
                !jumping)
                PlayAnimation(ToonLibrary.Animations.Walk.Name);
            else if (Input.GetAxis("Vertical") < 0 && !jumping)
                PlayAnimation(ToonLibrary.Animations.WalkBackward.Name);
            else if (!jumping)
                PlayAnimation(ToonLibrary.Animations.Idle.Name);

            transform.Rotate(
                0.0f,
                Input.GetAxis("Horizontal"),
                0.0f);
        }

        toonCharacterController.Move(move * Time.deltaTime);
    }
}
