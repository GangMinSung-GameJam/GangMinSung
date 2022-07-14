using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public bool stop = false;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject FirePos;

    public int maxbullet;
    public int curbullet;
    public float reloadTime;
    public bool canFire;
    bool firerate;
    public float fireRate;

    float curfireRate;

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

        if(canFire == true)
        {
            if (Input.GetKeyDown(KeyCode.Z) && firerate && stop == false)
            {
                curbullet--;
                curfireRate = 0;

                Vector3 mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                mousePos.z = 0;
                Instantiate(bullet, FirePos.transform.position, Quaternion.identity);
                bullet.transform.position = transform.position;

            }
        }
        
        if (curbullet == 0)
        {
            canFire = false;
        }
    }

}
