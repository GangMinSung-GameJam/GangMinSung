using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour
{
    public float cooltime;
    Vector3 dir;
    private void Start()
    {
        dir = GameObject.Find("Player").GetComponent<Transform>().up;
        transform.rotation = GameObject.Find("Player").GetComponent<Transform>().rotation;
    }
    void Update()
    {
        Destroy(gameObject,cooltime);
    }
}
