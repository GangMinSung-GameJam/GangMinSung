using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float damage = 10;
    // Start is called before the first frame update
    void Start()
    {
    }
    // ½ºÇÇµå
    public float speed;

    // Å¸°Ù
    public GameObject target = null;

    // ¸®Áþ ¹Ùµð Ä³½Ì
    public Rigidbody2D rigid = null;


    // Àû
    public float range = 20;
    // Update is called once per frame
    private void Update()
    {

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

        if (degree.x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        else if (degree.x > 0)
        {
            transform.localScale = new Vector2(1, 1);
        }

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<player>().HP -= damage;
            Destroy(gameObject);
        }
    }
}
