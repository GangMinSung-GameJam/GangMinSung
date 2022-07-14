using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muchinebullet : MonoBehaviour
{

    public float Maxdamage = 25;
    public float damage;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().enemyHp -= damage;
            Debug.Log(damage);
            Destroy(gameObject);
        }
    }
}
