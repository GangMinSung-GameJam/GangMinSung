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

    public float reloadTime;

    float curTime;

    [SerializeField] Slider reloadTimeView;
    [SerializeField] Text bulletTxt;

    bool canFire = true;
    void Start()
    {
        curbullet = maxbullet;
        reloadTimeView.maxValue = reloadTime;
    }
    void Update()
    {

        shot();
    }
    public void shot()

    {
        bulletTxt.text = curbullet + "/" + maxbullet;
        reloadTimeView.gameObject.SetActive(false);

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
        if (curbullet <= 0)
        {
            Reloading();
        }
    }
    void Reloading()
    {
        canFire = false;
        curTime += Time.deltaTime;

        reloadTimeView.value = curTime;
        reloadTimeView.gameObject.SetActive(true);

        if (curTime >= reloadTime)
        {
            canFire = true;
            curbullet = maxbullet;
            curTime = 0;

        }
    }

}
