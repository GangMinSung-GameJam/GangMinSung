using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    public float cooltime;
    
    void Update()
    {
        Destroy(gameObject,cooltime);
    }
}
