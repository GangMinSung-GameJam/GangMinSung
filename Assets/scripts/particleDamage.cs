using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleDamage : MonoBehaviour
{
    public float damage= 20;

    private void Update()
    {
        Destroy(gameObject,1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().enemyHp -= damage;
        }

    }
}