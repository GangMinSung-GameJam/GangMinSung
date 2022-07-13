using UnityEngine;



using System.Collections;



using UnityEngine.UI;



using UnityEngine.EventSystems;
using TMPro;








public class Blink : MonoBehaviour
{
    [SerializeField]
    private float lerpTime = 0.1f;
    private TextMeshProUGUI text;


    




    Text flashingText;








    // Use this for initialization



    void Start()
    {

        text = GetComponent<TextMeshProUGUI>();



    }


    private void OnEnable()
    {
        StartCoroutine("ColorLerpLoop");
    }

    public IEnumerator ColorLerpLoop()
    {
        while ( true)
        {
            yield return StartCoroutine(ColorLerp(Color.white, Color.blue));
            yield return StartCoroutine(ColorLerp(Color.blue, Color.white));
        }
    }

    private IEnumerator ColorLerp(Color startColor, Color endColor)
    {
        float currentime = 0.0f;
        float percent = 0.0f;

        while ( percent < 1)
        {
            currentime += Time.deltaTime;
            percent = currentime / lerpTime;

            text.color = Color.Lerp(startColor, endColor, percent);

            yield return null;
        }
    }





    /*public IEnumerator BlinkText()
    {



        while (true)
        {



            flashingText.text = "";



            yield return new WaitForSeconds(.3f);



            flashingText.text = "Congratulations!";



            yield return new WaitForSeconds(.3f);



        }



    }*/



}

