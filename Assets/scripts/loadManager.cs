using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadManager : MonoBehaviour
{
    [SerializeField] Slider MachineGunslider;
    [SerializeField] Text MachinegunbulletTxt;
    [SerializeField] MachineGun machine;

    [SerializeField] Slider Laserslider;
    [SerializeField] Text LaserbulletTxt;
    [SerializeField] Laser Laser;

    [SerializeField] Slider Shotgunslider;
    [SerializeField] Text ShotgunbulletTxt;
    [SerializeField] Shotgun Shotgun;


    float a;
    float b;
    float c;
    void Start()
    {
        MachineGunslider.maxValue = machine.reloadTime;

        Laserslider.maxValue = Laser.reloadTime;

        Shotgunslider.maxValue = Shotgun.reloadTime;

        a = 0;
        b = 0;
        c = 0;
    }

    void Update()
    {
        MachinegunbulletTxt.text = machine.curbullet + "/" + machine.maxbullet;

        LaserbulletTxt.text = Laser.curbullet + "/" + Laser.maxbullet;

        ShotgunbulletTxt.text = Shotgun.curbullet + "/" + Shotgun.maxbullet;




        if (machine.curbullet <= 0)
        {
            Reloading1();
        }
        else
            MachineGunslider.gameObject.SetActive(false);

        if (Laser.curbullet <= 0)
        {
            Reloading2();
        }
        else
            Laserslider.gameObject.SetActive(false);

        if (Shotgun.curbullet <= 0)
        {
            Reloading3();
        }
        else
            Shotgunslider.gameObject.SetActive(false);

    }
    void Reloading1()
    {
        machine.canFire = false;
        a += Time.deltaTime;

        MachineGunslider.value = a;
        MachineGunslider.gameObject.SetActive(true);

        if (a >= machine.reloadTime)
        {
            machine.canFire = true;
            machine.curbullet = machine.maxbullet;
            a = 0;

        }
    }
    void Reloading2()
    {
        Laser.canFire = false;
        b += Time.deltaTime;

        Laserslider.value = b;
        Laserslider.gameObject.SetActive(true);

        if (b >= Laser.reloadTime)
        {
            Laser.canFire = true;
            Laser.curbullet = Laser.maxbullet;
            b = 0;

        }
    }
    void Reloading3()
    {
        Shotgun.canFire = false;
        c += Time.deltaTime;

        Shotgunslider.value = c;
        Shotgunslider.gameObject.SetActive(true);

        if (c >= Shotgun.reloadTime)
        {
            Shotgun.canFire = true;
            Shotgun.curbullet = Shotgun.maxbullet;
            c = 0;

        }
    }
}
