﻿using System;
using UnityEngine;

public class sound_manager : MonoBehaviour
{

    public sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void play(string name)
    {
       sound s =  Array.Find(sounds, sound => sound.name == name);
      if (s == null)
        {
            Debug.LogError("the name of the sound does not match :(");
            return;
        }
       s.source.Play();
    }
}
