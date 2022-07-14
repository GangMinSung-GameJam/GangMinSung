using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;
    public bool stop;

    void Update()
    {
        if (GameObject.Find("Esc") == null) GameObject.Find("dady").GetComponent<dady>().selectedBullet = 0;
        else GameObject.Find("dady").GetComponent<dady>().selectedBullet = 1;
    }
}

