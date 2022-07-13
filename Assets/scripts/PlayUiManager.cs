using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayUiManager : MonoBehaviour
{
    public GameObject Penal;
    

    public void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject.Find("EnemySpwaner").GetComponent<EnemySpawn>().stop = true;
            GameObject.Find("Player").GetComponent<player>().stop = true;
                Time.timeScale = 0;
                Penal.SetActive(true);
           
        }
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
        Penal.SetActive(false);
        
    }
}
