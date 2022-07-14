using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayUiManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool GameIsPause;
    [SerializeField] GameObject player;
    public void Start()
    {
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
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = true;

        //GameObject.Find("dady").GetComponent<dady>().selectedBullet++;
        //player.SetActive(false);
        pauseMenuUI.SetActive(true);
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
        GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = false;
        GameObject.Find("Player").GetComponent<player>().stop = false;
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);

    }
}
