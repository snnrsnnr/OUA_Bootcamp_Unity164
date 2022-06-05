using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAudio : MonoBehaviour
{
    public AudioSource Ses;
    public AudioClip SesClip;
    public void Awake()
    {
        foreach (Button obje in Resources.FindObjectsOfTypeAll<Button>()) 
            obje.onClick.AddListener(() => ButtonAudios());
    }


    public void ButtonAudios()
    {
        Ses.PlayOneShot(SesClip, 0.1f);
    }
}
