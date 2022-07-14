using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour
{
    public float Maxdamage = 20;
    public float damage;
    Vector3 dir;
    public float destroytime;
    void Start()
    {
        damage = Maxdamage;
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
