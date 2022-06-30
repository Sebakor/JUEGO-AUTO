using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioSource source2;
    public AudioSource source3;
    public AudioClip musica;
    public AudioClip choque;
    public AudioClip frenos;

    public void MusicaCars(){
        source.clip = musica;
        source.Play();
    }

    public void Choque(){
        source2.clip = choque;
        source2.Play();
    }

    public void Frenos(){
        source3.clip = frenos;
        source3.Play();
    }

}
