using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanager : MonoBehaviour

{
    public static Soundmanager instance;
    private void Awake()
    {
        if(instance = null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SFXPlay(string sfxName, AudioClip clip)
    {
        GameObject go = new GameObject(sfxName + "Sound");
        AudioSource audiosource = go.AddComponent<AudioSource>();
        audiosource.clip = clip;
        audiosource.Play();

        Destroy(go, clip.length);
    }
}


