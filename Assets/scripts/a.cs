using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
   
    void Update()
    {
        Time.timeScale = 0;
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = true;
    }
}
