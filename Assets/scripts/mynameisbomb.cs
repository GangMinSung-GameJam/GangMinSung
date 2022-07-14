using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mynameisbomb : MonoBehaviour
{
    [SerializeField] GameObject particle;
    public float speed = 50;
    public float time;
    Vector3 targetPosition;
    Vector3 dir;
    void Start()
    {
        //dir = GameObject.Find("Player").GetComponent<Transform>().up;
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dir = targetPosition.normalized;

        transform.rotation = GameObject.Find("Player").GetComponent<Transform>().rotation;
    }

    void Update()
    {
        time += Time.deltaTime;
        transform.position += dir * speed * Time.deltaTime;

        if(Vector3.Distance(transform.position, targetPosition) <= 1)
        {
            Destroy(gameObject);
            GameObject par = Instantiate(particle, transform.position, Quaternion.identity);
        }


        //if (speed <= 0)
        //{
        //    Destroy(gameObject);
        //    GameObject par = Instantiate(particle,transform.position,Quaternion.identity);

        //}
    }
}
