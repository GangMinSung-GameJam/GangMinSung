using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    public int selectedBullet;
    public bool stop = false;
    [SerializeField] Upgrade upgrade;
    void Update()
    {
        
        if(GameObject.Find("Player") == null) { return; }
        else { GameObject.Find("Player").SetActive(false); }
        Time.timeScale = 0;
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = true;
        SelectBullet();
        swap();

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
    void swap()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (selectedBullet >= 2)
                selectedBullet = 0;
            else
                selectedBullet++;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(GameObject.Find("playerHp") != null)
            {
                upgrade.PlayerHpUp();
            }
            if (GameObject.Find("loadTimeDown") != null)
            {
                upgrade.loadTime();
            }
            if (GameObject.Find("damageUp") != null)
            {
                upgrade.damageUp();
            }
        }
    }
}
