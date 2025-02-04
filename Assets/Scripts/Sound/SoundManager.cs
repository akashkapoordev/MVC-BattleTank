using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get { return instance; } }
    private static SoundManager instance;
    public AudioSource backgroundSource;
    public AudioSource soundEffects;
    public Sounds[] sounds;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

        PlayBackgroundMusic(SoundType.BACKGROUND);
    }

    void Update()
    {
        
    }

    public void PlayBackgroundMusic(SoundType type)
    {
        AudioClip clip = GetAudioClip(type);
        backgroundSource.clip = clip;
        backgroundSource.Play();
    }

    public void PlaySoundEffect(SoundType type)
    {
        AudioClip clip = GetAudioClip(type);
        soundEffects.PlayOneShot(clip);
    }

    private AudioClip GetAudioClip(SoundType soundType)
    {
        Sounds sound = Array.Find(sounds, i => i.soundType == soundType);
        if(sound !=null)
        {
            return sound.audioClip;
        }

        return null;
    }
}
