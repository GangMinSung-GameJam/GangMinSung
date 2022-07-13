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



    public bool canFire;
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

        if (Input.GetKey(KeyCode.Z) && canFire)
        {
            curbullet--;

            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Instantiate(bullet, firePos.transform.position, Quaternion.identity);
            Instantiate(particle, particlePos.transform.position, Quaternion.identity);
            bullet.transform.position = transform.position;

        }
        if(curbullet == 0)
        {
            canFire = false;
        }
    }
}
