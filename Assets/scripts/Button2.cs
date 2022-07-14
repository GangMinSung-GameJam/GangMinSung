using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] Text text2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DD");
        StartCoroutine("EE");
    }
    IEnumerator EE()
    {
        while (true)
        {
            text.color = Color.white;
            yield return new WaitForSeconds(0.2f);
            text.color = Color.blue;
            yield return new WaitForSeconds(0.2f);

        }
    }
    IEnumerator DD()
    {
        while (true)
        {
            text2.color = Color.white;
            yield return new WaitForSeconds(0.4f);
            text2.color = Color.black;
            yield return new WaitForSeconds(0.4f);

        }
    }

}
