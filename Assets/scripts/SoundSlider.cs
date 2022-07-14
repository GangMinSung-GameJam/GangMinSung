using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    [SerializeField] Slider slider;
    void Start()
    {
        slider.value = 0.5f;
        if (PlayerPrefs.HasKey("volume"))
        {
            PlayerPrefs.SetFloat("volume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = slider.value;
        Save();
    }
    void Load()
    {
        AudioListener.volume = PlayerPrefs.GetFloat("Volume");
    }
    void Save()
    {
        PlayerPrefs.SetFloat("Volume", slider.value);
    }
}
