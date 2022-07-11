using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assault : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        shot();
        //loadanim();
        
    }
    public void shot()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetBool("shot",true);
            Instantiate(bullet, transform.position,Quaternion.identity);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            anim.SetBool("shot",false);
            Instantiate(bullet, transform.position, Quaternion.identity);
        }

    }
    
    
}
