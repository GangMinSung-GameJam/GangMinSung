using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotmove : MonoBehaviour
{
    public float speed = 100;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Destroy(gameObject, 0.05f);
    }
    
}
