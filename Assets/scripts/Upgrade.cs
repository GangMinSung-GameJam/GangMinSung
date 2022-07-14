using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
     public float loadCoolTime;
     public float PlusDamage;
    public float PlusHp;

    [SerializeField] GameObject panel;
    [SerializeField] player player;
    [SerializeField] MachineGun machinegun;
    [SerializeField] Laser laser;
    [SerializeField] Shotgun shotgun;
    [SerializeField] Muchinebullet muchinegunDamage;

    private void Start()
    {
        muchinegunDamage.damage = muchinegunDamage.Maxdamage;
    }
    public void loadTime()
    {
        machinegun.reloadTime -= loadCoolTime;
        laser.reloadTime -= loadCoolTime;
        shotgun.reloadTime -= loadCoolTime;
        panel.SetActive(false);
    }
    public void PlayerHpUp()
    {
        player.currenthp += PlusHp;
        panel.SetActive(false);
    }
    public void damageUp()
    {
        muchinegunDamage.damage += PlusDamage;
        panel.SetActive(false);

    }
    /*public void find()
    {
        GameObject.Find("Machinegun").SetActive(true);   
        GameObject.Find("laser").SetActive(true);   
        GameObject.Find("Shotgun").SetActive(true);   
    }*/
}
