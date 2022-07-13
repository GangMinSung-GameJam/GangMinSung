using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadManager : MonoBehaviour
{
    [SerializeField] Slider MachineGunslider;
    [SerializeField] Text bulletTxt;



    float curTime;
    [SerializeField] MachineGun machine;    
    void Start()
    {
        MachineGunslider.maxValue = machine.reloadTime;
        curTime = 0;
    }

    void Update()
    {
        bulletTxt.text = machine.curbullet + "/" + machine.maxbullet;

        if (machine.curbullet <= 0)
        {
            Reloading();
        }
        else
            MachineGunslider.gameObject.SetActive(false);

    }
    void Reloading()
    {
        machine.canFire = false;
        curTime += Time.deltaTime;

        MachineGunslider.value = curTime;
        MachineGunslider.gameObject.SetActive(true);

        if (curTime >= machine.reloadTime)
        {
            machine.canFire = true;
            machine.curbullet = machine.maxbullet;
            curTime = 0;

        }
    }
}
