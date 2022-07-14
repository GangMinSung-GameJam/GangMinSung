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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause) { Resume(); }
            else { Pausegame(); }
        }
    }
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void Pausegame()
    {
        //GameObject.Find("Player").SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPause = true;
    }
}
