using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Fast : MonoBehaviour
{
    
    Player player;

    public float HP;
    public float Speed;
    public float Damage;
    public float attackRange;

    Animation anim;

    public bool move;
    private void Start()
    {
/*        player = GetComponent<Player>();
*/    }
    private void Update()
    {
        Move(Speed);
    }
    void Move(float speed)
    {
        if (move)
        {
            Vector3 dir = Vector3.left * speed * Time.deltaTime;
            transform.Translate(dir);
        }
        else
        {
            transform.Translate(Vector3.zero);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject.Find("player").GetComponent<Player>().HP -= Damage;
            Destroy(gameObject);
        }
    }
}
