using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;


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
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPause = true;
    }
}
