using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class ToonSoundBank
{
    public ToonSoundBankCollection[] collections;

    private Dictionary<string, ToonSoundBankCollection> collectionDictionary;

    public void Initialize()
    {
        collectionDictionary =
            collections
            .ToDictionary(r => r.name, r => r);
    }

    public void PlayClip(AudioSource source, string collection, int index)
    {
        if (!collectionDictionary.ContainsKey(collection))
        {
            Debug.LogWarning("Collection \"" + collection + "\" does not exist in the soundbank!");
            return;
        }

        source.PlayOneShot(
            collectionDictionary[collection].clips[index]);
    }

    public void PlayRandomClip(AudioSource source, string collection)
    {
        if (!collectionDictionary.ContainsKey(collection))
        {
            Debug.LogWarning("Collection \"" + collection + "\" does not exist in the soundbank!");
            return;
        }

        PlayClip(
            source,
            collection,
            Random.Range(
                0,
                collectionDictionary[collection].clips.Length));
    }
}
