using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

//Script sourced from https://youtu.be/6OT43pvUyfY?si=7-sd9os0qEQnAm5A
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    // Update is called once per frame
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s != null)
        {
            s.source.Stop();
        }
    }

    public AudioSource GetSource(string name)
    {
        foreach (Sound s in sounds)
        {
            if (s.name == name)
                return s.source;
        }
        return null;
    }
}
