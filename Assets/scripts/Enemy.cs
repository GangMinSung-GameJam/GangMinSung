using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyHp = 20;
    public float damage = 10;
    [SerializeField] GameObject particle;
    Vector3 dir;
    void Start()
    {
        if (GameObject.Find("Player") != null)
        {
            dir = GameObject.Find("Player").GetComponent<Transform>().up; transform.rotation = GameObject.Find("Player").GetComponent<Transform>().rotation;
        }
        else return;

    }
    // ½ºÇÇµå
    public float speed;
    // Å¸°Ù

    // ¸®Áþ ¹Ùµð Ä³½Ì
    public Rigidbody2D rigid = null;


    // Àû
    public float range = 20;
    // Update is called once per frame
    private void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            if (enemyHp <= 0)
            {
                Destroy(gameObject);
                GameObject par = Instantiate(particle, transform.position, Quaternion.identity);
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
        else { return; }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<player>().currenthp -= damage;
            Destroy(gameObject);
            //GameObject par = Instantiate(particle, transform.position, Quaternion.identity);
        }

        if (collision.CompareTag("laser"))
        {
            Destroy(gameObject);
            GameObject par = Instantiate(particle, transform.position, Quaternion.identity);
        }
    }
}
