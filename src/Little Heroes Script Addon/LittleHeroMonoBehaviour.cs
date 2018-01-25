using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class LittleHeroMonoBehaviour : MonoBehaviour
{
    public ToonSoundBank soundBank;

    protected Animator animator;
    protected AnimatorControllerParameter[] parameters;
    protected string currentAnimationName;
    protected Dictionary<ToonBodyPart, GameObject> bodyParts;

    protected virtual void Start()
    {
        animator = GetComponent<Animator>();

        parameters = animator.parameters.ToArray();

        FindAndAttachBodyParts();

        soundBank.Initialize();
    }

    protected virtual void FindAndAttachBodyParts()
    {
        bodyParts =
            new Dictionary<ToonBodyPart, GameObject>
            {
                { ToonBodyPart.LeftHand, FindChildGameObject("Dummy Prop Left") },
                { ToonBodyPart.RightHand, FindChildGameObject("Dummy Prop Right") },
                { ToonBodyPart.Head, FindChildGameObject("Dummy Prop Head") },
                { ToonBodyPart.Back, FindChildGameObject("Dummy Prop Back") }
            };
    }

    protected virtual GameObject FindChildGameObject(string name)
    {
        return
            FindObjectsOfType<GameObject>()
            .Where(r => r.name == name)
            .FirstOrDefault();
    }

    public virtual void Unequip(ToonBodyPart part)
    {
        if (!bodyParts.ContainsKey(part) || bodyParts[part] == null)
            return;

        foreach (Transform child in bodyParts[part].transform)
            Destroy(child.gameObject);
    }

    public virtual void Equip(ToonBodyPart part, string equipmentPath, bool autoUnEquip = true)
    {
        var newGameObject =
            Instantiate(Resources.Load(equipmentPath)) as GameObject;

        if (!Equip(
            part,
            newGameObject,
            autoUnEquip))
            Destroy(newGameObject);
    }

    public virtual bool Equip(ToonBodyPart part, GameObject equipment, bool autoUnEquip = true)
    {
        if (!bodyParts.ContainsKey(part) || bodyParts[part] == null)
            return false;

        if (autoUnEquip)
            Unequip(part);

        var originalPosition = equipment.transform.position;
        var originalRotation = equipment.transform.rotation;

        equipment.transform.SetParent(bodyParts[part].transform);

        equipment.transform.localPosition = originalPosition;
        equipment.transform.localRotation = originalRotation;

        return true;
    }

    public virtual void ClearAllAnimations()
    {
        foreach (var parameter in parameters)
            if (parameter.type == AnimatorControllerParameterType.Bool)
                animator.SetBool(parameter.name, false);
    }

    public virtual void PlayAnimation(string name)
    {
        if (name == currentAnimationName)
            return;

        currentAnimationName = name;

        var animation =
            ToonLibrary.Animations.AllAnimations[name];

        if (animation == null)
            throw new UnityException("Unknown animation \"" + name + "\"");

        ClearAllAnimations();

        if (
            animation.ParentName != ToonLibrary.Animations.RootAnimation.Name &&
            !string.IsNullOrEmpty(animation.ParentTriggerName))
            animator.SetBool(animation.ParentTriggerName, true);

        if (
            animation.Name != ToonLibrary.Animations.RootAnimation.Name &&
            !string.IsNullOrEmpty(animation.TriggerName))
            animator.SetBool(animation.TriggerName, true);
    }

    public virtual void AddToonAnimationEvent(
        string[] clipNames,
        float[] times,
        string functionName,
        Object objectReference = null)
    {
        var animator = GetComponent<Animator>();

        if (animator == null)
            throw new UnityException("Cannot find animator on gameObject \"" + gameObject.name + "\"");

        foreach (var clipName in clipNames)
        {
            var clip =
                animator
                .runtimeAnimatorController
                .animationClips
                .Where(r => r.name == clipName)
                .FirstOrDefault();

            if (clip == null)
                throw new UnityException("Cannot find animation \"" + clipName + "\"");

            foreach (var time in times)
                clip.AddEvent(
                    new AnimationEvent
                    {
                        time = time * clip.length,
                        functionName = functionName,
                        objectReferenceParameter = objectReference
                    });
        }
    }

    public virtual void AddToonAnimationEvent(
        string clipName,
        float time,
        string functionName,
        Object objectReference = null)
    {
        AddToonAnimationEvent(
            new string[] { clipName },
            new float[] { time },
            functionName,
            objectReference);
    }

    public virtual void AddToonAnimationEvent(
        string clipName,
        float[] times,
        string functionName,
        Object objectReference = null)
    {
        AddToonAnimationEvent(
            new string[] { clipName },
            times,
            functionName,
            objectReference);
    }

    public virtual void AddToonAnimationEvent(
        string[] clipNames,
        float time,
        string functionName,
        Object objectReference = null)
    {
        AddToonAnimationEvent(
            clipNames,
            new float[] { time },
            functionName,
            objectReference);
    }
}
