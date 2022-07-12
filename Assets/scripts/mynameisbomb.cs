using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mynameisbomb : MonoBehaviour
{
    [SerializeField] GameObject particle;
    public float speed = 50;
    public float time;
    Vector3 dir;
    void Start()
    {
        dir = GameObject.Find("Player").GetComponent<Transform>().up;
        transform.rotation = GameObject.Find("Player").GetComponent<Transform>().rotation;
    }

    void Update()
    {
        speed = speed - time;
        time += Time.deltaTime;
        transform.position += dir * speed * Time.deltaTime;

        if(speed <= 0)
        {
            Destroy(gameObject);
            GameObject par = Instantiate(particle,transform.position,Quaternion.identity);

        }
    }
}
