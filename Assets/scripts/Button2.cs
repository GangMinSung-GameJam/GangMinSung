using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EE");
    }
    IEnumerator EE()
    {
        while (true)
        {
            text.color = Color.white;
            yield return new WaitForSeconds(0.3f);
            text.color = Color.blue;
            yield return new WaitForSeconds(0.3f);

        }
    }

}
