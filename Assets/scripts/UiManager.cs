using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] Sprite[] swapImage = new Sprite[2];

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Image>().sprite = swapImage[1];
            GetComponent<Image>().SetNativeSize();

        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            GetComponent<Image>().sprite = swapImage[0];
            GetComponent<Image>().SetNativeSize();

        }
    }

}
