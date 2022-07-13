using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public bool stop = false;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject firepos;

    public int maxbullet;
    public int curbullet;
    public int reloadTime;
    public float fireRate;

    float curfireRate;

    public bool canFire;
    bool firerate;
    void Start()
    {
        canFire = true;
        curbullet = maxbullet;
    }
    void Update()
    {
        curfireRate += Time.deltaTime;

        if (curfireRate >= fireRate) firerate = true;
        else firerate = false;
        if (canFire == true)
        {
            if (Input.GetKeyDown(KeyCode.Z) && firerate & stop == false)
            {
                curbullet--;
                curfireRate = 0;

                Instantiate(bullet, firepos.transform.position, Quaternion.identity);

            }
            if (curbullet == 0)
            {
                canFire = false;
            }

        }
    }
}
