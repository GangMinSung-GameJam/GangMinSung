using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [SerializeField] GameObject penal;

    
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

}
