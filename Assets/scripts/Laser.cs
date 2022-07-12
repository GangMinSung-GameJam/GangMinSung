using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser: MonoBehaviour
{
    
        [SerializeField] GameObject bullet;
        [SerializeField] GameObject FirePos;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Vector3 mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);
                mousePos.z = 0;
                Instantiate(bullet, FirePos.transform.position, Quaternion.identity);
                bullet.transform.position = transform.position;
                
               
                
            }
        }
        
}
