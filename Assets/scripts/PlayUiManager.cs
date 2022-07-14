using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayUiManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool GameIsPause;
    dady dady;
    
    public void Start()
    {
        dady = GameObject.Find("dady").GetComponent<dady>(); 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //GameObject.Find("Player").GetComponent<player>().stop = true;
            /*Time.timeScale = 0;
            Penal.SetActive(true);*/
            if (GameIsPause) { Resume(); }
            else { Pausegame(); }

        }
    }
    void Resume()
    {
            GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = false;
        //GameObject.Find("dady").GetComponent<dady>().selectedBullet++;
        //player.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    void Pausegame()
    {
        pauseMenuUI.SetActive(true);
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = true;

        //GameObject.Find("dady").GetComponent<dady>().selectedBullet++;
        //player.SetActive(false);
        Time.timeScale = 0;
        GameIsPause = true;

    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ScenceChange()
    {
        SceneManager.LoadScene("Start");
    }
    public void Countinue()
    {
        pauseMenuUI.SetActive(false);
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = false;
        Time.timeScale = 1;
    }
}
