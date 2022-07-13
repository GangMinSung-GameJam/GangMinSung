using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muchinebullet : MonoBehaviour
{

    [SerializeField] float damage = 5;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().enemyHp -= damage;
            Destroy(gameObject);
        }
    }
}