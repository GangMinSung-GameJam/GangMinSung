using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    float time;
    float fadeRate = 0;
    [SerializeField] GameObject penal;
    [SerializeField] GameObject explain;
    [SerializeField] GameObject Dogam;
    [SerializeField] GameObject Weapon;
    [SerializeField] GameObject Enemy;
    [SerializeField] Text wavePenal;
    

    private void Update()
    {
        Fade();
        
    }
    public void Startbutton(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void Sulmeong()
    {
        penal.SetActive(true);
    }
    public void SulmeongClose()
    {
        penal.SetActive(false);
    }
    public void Restart(string start)
    {
        SceneManager.LoadScene(start);
    }
    public void explainO()
    {
        explain.SetActive(true);
    }
    public void WeaponO()
    {
        Weapon.SetActive(true);
        Dogam.SetActive(false);
    }
    public void Weaponclose()
    {
        Weapon.SetActive(false);
        Dogam.SetActive(true);
    }
    public void explainclose()
    {
        explain.SetActive(false);
    }
    public void EnemyO()
    {
        Enemy.SetActive(true);
        Dogam.SetActive(false);
    }
    public void Enemyclose()
    {
        Enemy.SetActive(false);
        Dogam.SetActive(true);
    }
    void Fade()
    {
        if (time <= 1)
        {
            wavePenal.color = new Color(1, 1, 1, fadeRate);
            fadeRate += 0.007f;
        }
        if (time >= 2)
        {
            wavePenal.color = new Color(1, 1, 1, fadeRate);
            fadeRate -= 0.007f; 
        }
        
    }
    public void Quit()
    {
        Application.Quit();
    }

}
