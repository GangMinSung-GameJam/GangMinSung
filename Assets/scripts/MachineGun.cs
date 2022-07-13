using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject firePos;
    [SerializeField] GameObject particlePos;
    [SerializeField] GameObject particle;

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

        shot();
    }
    public void shot()
    {
        curfireRate += Time.deltaTime;

        if (curfireRate >= fireRate) firerate = true;
        else firerate = false;

        if (canFire == true)
        {
            if (Input.GetKey(KeyCode.Z) && firerate)
            {
                curbullet--;
                curfireRate = 0;

                Vector3 mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                mousePos.z = 0;
                Instantiate(bullet, firePos.transform.position, Quaternion.identity);
                Instantiate(particle, particlePos.transform.position, Quaternion.identity);
                bullet.transform.position = transform.position;

            }
        }
        if (curbullet == 0)
        {
            canFire = false;
        }
    }
}
