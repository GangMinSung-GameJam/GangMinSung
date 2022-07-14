using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineGun : MonoBehaviour
{
    public bool stop = false;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject firePos;
    [SerializeField] GameObject particlePos;
    [SerializeField] GameObject particle;
    AudioSource shootSound;

    public int maxbullet;
    public int curbullet;
    public float reloadTime;
    public float fireRate;

    float curfireRate;


    public bool canFire;
    bool firerate;
    void Start()
    {
        canFire = true;
        curbullet = maxbullet;

        shootSound = GetComponent<AudioSource>();
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
            if (Input.GetKey(KeyCode.Z) && firerate && stop == false)
            {
                curbullet--;
                curfireRate = 0;

                Vector3 mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                mousePos.z = 0;
                Instantiate(bullet, firePos.transform.position, Quaternion.identity);
                Instantiate(particle, particlePos.transform.position, Quaternion.identity);
                bullet.transform.position = transform.position;

                shootSound.Play();
            }
        }
        if (curbullet == 0)
        {
            canFire = false;
        }
    }
}
