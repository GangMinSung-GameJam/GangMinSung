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
    
}
