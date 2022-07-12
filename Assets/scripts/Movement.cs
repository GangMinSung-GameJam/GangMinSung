using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 dir;
    private void Start()
    {
        dir = GameObject.Find("Player").GetComponent<Transform>().up;
        transform.rotation = GameObject.Find("Player").GetComponent<Transform>().rotation;
    }
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
        
        Destroy(gameObject, 3);
    }
}
