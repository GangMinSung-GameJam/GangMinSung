using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedBullet;
    
    void Update()
    {
        SelectBullet();
        SwitchingBullet();
    }
    public void SelectBullet()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedBullet) { weapon.gameObject.SetActive(true); }
            else { weapon.gameObject.SetActive(false); }
            i++;
        }
    }
    void SwitchingBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectedBullet >= transform.childCount - 1)
                selectedBullet = 0;
            else
                selectedBullet++;
        }
    }
}
