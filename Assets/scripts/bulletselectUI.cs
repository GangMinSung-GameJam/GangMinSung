using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletselectUI : MonoBehaviour
{

    void Update()
    {
        if (GameObject.Find("Player").GetComponent<player>().selectedBullet == 0)
        {
            GameObject.Find("MachineGun").GetComponent<Image>().color = new Color(1, 1, 1, 1);
            GameObject.Find("Laser").GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            GameObject.Find("ShotGun").GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        }
        else if (GameObject.Find("Player").GetComponent<player>().selectedBullet == 1)
        {
            GameObject.Find("MachineGun").GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            GameObject.Find("Laser").GetComponent<Image>().color = new Color(1, 1, 1, 1);
            GameObject.Find("ShotGun").GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
        }
        else if (GameObject.Find("Player").GetComponent<player>().selectedBullet == 2)
        {
            GameObject.Find("MachineGun").GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            GameObject.Find("Laser").GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            GameObject.Find("ShotGun").GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
    }
}
