using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dady : MonoBehaviour
{
    public int selectedBullet;
    public bool iscold;
    bool isstop;
    AudioSource audio;
    /* private void Start()
     {
         owo();
     }*/
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        owo();

        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedBullet) { weapon.gameObject.SetActive(true); }
            else { weapon.gameObject.SetActive(false); }
            i++;
        }

        if (GameObject.Find("Shotgunbulletparticle(Clone)") == null) { isstop = false; }
        else
        {
            if (!isstop)
            {
                audio.Play();
                isstop = true;
            }
        }
    }
    public void owo()
    {
        if (selectedBullet >= 1)
            selectedBullet = 0;
        else
            selectedBullet++;
    }
}
