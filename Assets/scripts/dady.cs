using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dady : MonoBehaviour
{
    public int selectedBullet;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (selectedBullet >= 1)
                selectedBullet = 0;
            else
                selectedBullet++;
        }

        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedBullet) { weapon.gameObject.SetActive(true); }
            else { weapon.gameObject.SetActive(false); }
            i++;
        }


    }
}
