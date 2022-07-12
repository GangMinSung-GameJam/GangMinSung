using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour
{
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
        bulletTxt.text = curbullet + "/" + maxbullet;
        reloadTimeView.gameObject.SetActive(false);
        if (Input.GetKeyDown(KeyCode.Z) && canFire)
        {
            curbullet--;
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
