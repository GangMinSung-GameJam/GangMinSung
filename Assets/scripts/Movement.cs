using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 dir;
    // Start is called before the first frame update
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
        Destroy(gameObject, 3);
    }
    public void MoveTo(Vector3 position)
    {
        position = dir;
    }
}
