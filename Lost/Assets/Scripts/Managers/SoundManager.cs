using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField]
    private AudioClip MelankolikMusic;
    [SerializeField]
    private AudioClip AksiyonMusic;
    [SerializeField]
    private AudioClip AksiyonAmbiance;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //Ilk sahnede calan muzik
        audioSource.clip = MelankolikMusic;
        audioSource.Play();
        audioSource.loop = true;
    }
}
