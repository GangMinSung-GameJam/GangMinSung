using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleDamage : MonoBehaviour
{
    public float damage;

    AudioSource audio;
    
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        Destroy(gameObject,0.25f);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().enemyHp -= damage;
        }

    }
}
