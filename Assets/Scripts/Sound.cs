using UnityEngine.Audio;
using UnityEngine;

//Script sourced from https://youtu.be/6OT43pvUyfY?si=7-sd9os0qEQnAm5A

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 10f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}