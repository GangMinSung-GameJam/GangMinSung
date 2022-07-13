using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour
{
    public float damage = 20;
    Vector3 dir;
    public float destroytime;
    void Start()
    {
        dir = GameObject.Find("Player").GetComponent<Transform>().up;
        transform.rotation = GameObject.Find("Player").GetComponent<Transform>().rotation;
    }
    private void Update()
    {
        Destroy(gameObject,destroytime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("metal"))
        {

        }
    }
}
