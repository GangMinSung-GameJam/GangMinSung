using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dady : MonoBehaviour
{
    public int selectedBullet;
    public bool iscold;
    /* private void Start()
     {
         owo();
     }*/
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


    }
    public void owo()
    {
        if (selectedBullet >= 1)
            selectedBullet = 0;
        else
            selectedBullet++;
    }
}
