using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject firePos;
    [SerializeField] GameObject particlePos;
    [SerializeField] GameObject particle;
    [SerializeField] public float maxshotdelay;
    [SerializeField] public float curshotdelay;

    void Update()
    {
        shot();
        Reload();
    }
    public void shot()

    {

        if (Input.GetKey(KeyCode.Z))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Instantiate(bullet, firePos.transform.position, Quaternion.identity);
            Instantiate(particle, particlePos.transform.position, Quaternion.identity);
            bullet.transform.position = transform.position;
            if (curshotdelay < maxshotdelay)
                return;
            
        }

    }
    void Reload()
    {
        curshotdelay += 1;
    }
}
