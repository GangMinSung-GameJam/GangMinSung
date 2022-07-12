using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject firepos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bullet, firepos.transform.position, Quaternion.identity);

        }
    }
}
