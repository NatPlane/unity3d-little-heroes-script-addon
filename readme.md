# Unity3d Little Heroes Script Add-On

I love Meshtint's Unity Store assets and I can't count how many small projects I've started over the years using their assets.  I can also attest to the fact that getting everything configured from scratch can be a challenge.  So contained within this add-on are a few handy features to get you started much more quickly.

* Animation mappings - Getting your arrow to fire, playing footsteps, casting spells and launching projectiles all in sync with the animations without modifying the animation clips themselves.  All major events have been time mapped and named for each animation, simply add a bit of code wherever to create callbacks for these events - best of all, this is pack update safe YASSS!

``` csharp
// on any step event for the "Walk" and "Walk Backward" animations, call the "Step" method
AddToonAnimationEvent(
    new string[] { ToonLibrary.Animations.Walk.Name, ToonLibrary.Animations.WalkBackward.Name },
    ToonLibrary.Animations.Walk.Events.AnyStep,
    "Step");

// as the toon raises their hand to cast a deadly spell, call the CastSpell method
AddToonAnimationEvent(
    ToonLibrary.Animations.CastSpell.Name,
    ToonLibrary.Animations.CastSpell.Events.Cast,
    "CastSpell");

// after the toon's "Die" animation completes - call the "RemoveBody" method
AddToonAnimationEvent(
    ToonLibrary.Animations.Die.Name,
    ToonLibrary.Animations.GlobalEvents.Complete,
    "RemoveBody");
```
* Randomized sound banks - Make things less mundane and create named collections of sounds to randomize and play for various events and otherwise.

``` csharp
soundBank.PlayRandomClip(audioSource, "Footsteps");
```
* Equipment management - Easily equip and unequip one or more accessories, weapons, etc. to your toon. 

``` csharp
// equip a red mace prefab to the toon's right hand
Equip(ToonBodyPart.RightHand, "Mace 01 Red");

// equip a blue shield prefab to the toon's left hand
Equip(ToonBodyPart.LeftHand, "Shield 02 Blue");

// add both black hair and a mask to the toon's face (the tertiary property here is disabling the auto un-equip)
Equip(ToonBodyPart.Head, "Hair Female 18 Black");
Equip(ToonBodyPart.Head, "Mask 03 Blue", false);

// add a prop to the toon's back
Equip(ToonBodyPart.Back, "Back Prop 01 Black");
```

## Getting Started

For the time being the only way to use this add-on is to clone and merge the code into your project.  Eventually a unity package may be created, but for now, it doesn't exist :) After merging, consult the instructions at the top of the DemoToon behavior to get started quickly.

## Contributing

Contributions are encouraged! Further improvement is various areas is planned and some help would be great as this is obviously just a fun hobby.  Don't be shy to create a PR, I'd love to see what you've got.  Most other repos have contributing guidelines a mile long, who has time for that? Just be cool :)

## Versioning

Eventually I'd like to do formal versions and releases, but for now let's keep it loosey goosey.  This is just for fun right? :) 

## License

This project is licensed under the MIT License.  You should be familiar with that at this point.

## Greetz

Yes, I'm old and this was a thing in my day ;)

* [Meshtint](https://www.meshtint.com/) - Without their great assets this wouldn't have been possible.  Give me a shout fellas, I'd love to do stuff for other asset packs :)
* [Jeff Goergen](https://github.com/jgoergen) - Another Unity developer and good buddy
