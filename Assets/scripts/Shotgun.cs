using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bullet, transform.position + Vector3.right * 3f + Vector3.down * 1f, Quaternion.identity);

        }
    }
}
