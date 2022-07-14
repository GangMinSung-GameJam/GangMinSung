using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverwave : MonoBehaviour
{
    [SerializeField] Text txt;
    void Start()
    {
        int wave = PlayerPrefs.GetInt("wave", 0);
        txt.text = (wave+1) + " wave";
    }
}
