using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBullet : MonoBehaviour
{
    SpriteRenderer sr;

    public float Maxdamage = 20;    
    public float damage;
    public float time;
    Vector3 dir;
    public float destroytime;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine("fadeout");
        damage = Maxdamage;
        dir = GameObject.Find("Player").GetComponent<Transform>().up;
        transform.rotation = GameObject.Find("Player").GetComponent<Transform>().rotation;
    }
    private void Update()
    {
        Destroy(gameObject, destroytime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
    IEnumerator fadeout()
    {
        for (int i = 10; i >= 0; i--)
        {
            float f = i / 10.0f;
            Color c = sr.material.color;
            c.a = f;
            sr.material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
