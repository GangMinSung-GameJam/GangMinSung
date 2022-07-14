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
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = false;
        machinegun.reloadTime -= loadCoolTime;
        laser.reloadTime -= loadCoolTime;
        shotgun.reloadTime -= loadCoolTime;
        panel.SetActive(false);
        Time.timeScale = 1;

    }
    public void PlayerHpUp()
    {
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = false;
        player.currenthp += PlusHp;
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    public void damageUp()
    {
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = false;
        muchinegunDamage.damage += PlusDamage;
        panel.SetActive(false);
        Time.timeScale = 1;

    }
    /*public void find()
    {
        GameObject.Find("Machinegun").SetActive(true);   
        GameObject.Find("laser").SetActive(true);   
        GameObject.Find("Shotgun").SetActive(true);   
    }*/
}