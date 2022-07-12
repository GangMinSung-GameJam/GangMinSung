using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyHp = 20;
    public float damage = 10;
    Vector3 dir;
    void Start()
    {
        dir = GameObject.Find("Player").GetComponent<Transform>().up;
        transform.rotation = GameObject.Find("Player").GetComponent<Transform>().rotation;
    }
    // ���ǵ�
    public float speed;
    LaserBullet laser;
    // Ÿ��
    public GameObject target = null;

    // ���� �ٵ� ĳ��
    public Rigidbody2D rigid = null;


    // ��
    public float range = 20;
    // Update is called once per frame
    private void Update()
    {
        if(enemyHp <= 0)
        {
            Destroy(gameObject);
        }

        Vector2 degree = GameObject.Find("Player").GetComponent<Transform>().position - transform.position;

        if (degree.magnitude <= range)
        {
            rigid.velocity = degree.normalized * speed;
        }
        else
        {
            rigid.velocity = Vector2.zero;
            degree = Vector2.zero;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<player>().HP -= damage;
            Destroy(gameObject);
        }
        
            if (collision.CompareTag("laser"))
            {
            Destroy(gameObject);
            }
        

    }
}
