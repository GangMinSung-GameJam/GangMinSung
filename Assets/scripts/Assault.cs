using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assault : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject firePos;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        shot();

    }
    public void shot()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Instantiate(bullet, firePos.transform.position, Quaternion.identity);
            bullet.transform.position = transform.position;
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {

        }

    }


}
