﻿using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;

    void Awake()
    {
        Debug.Log("Dont destroy onejct" + name);
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log(thisLevelMusic);
        if (thisLevelMusic)
        {
          
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void setVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
