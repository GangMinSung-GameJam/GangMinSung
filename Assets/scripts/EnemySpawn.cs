using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{


    public bool stop;

    [SerializeField]
    private float spawnRadius = 7,
            time,
            time1,
            time2,
            time3;
    int waveTime = 0;
    [SerializeField] GameObject wave1;
    [SerializeField] GameObject wave2;
    [SerializeField] GameObject wave3;
    [SerializeField] GameObject wave4;
    [SerializeField] GameObject wave5;
    [SerializeField] GameObject wave6;
    [SerializeField] GameObject wave7;
    [SerializeField] GameObject wave8;
    [SerializeField] GameObject wave9;
    [SerializeField] GameObject wave10;

    public GameObject[] enemies;
    public GameObject[] enemies1;
    public GameObject[] enemies2;
    public GameObject[] enemies3;
    public float waveNext;
    public float endWaveTime;

    bool iscase1;

    private void Start()
    {
        wave1.SetActive(false);
        wave2.SetActive(false);
        wave3.SetActive(false);
        wave4.SetActive(false);
        wave5.SetActive(false);
        wave6.SetActive(false);
        wave7.SetActive(false);
        wave8.SetActive(false);
        wave9.SetActive(false);
        wave10.SetActive(false);
    }

    float curTime = 0;
    public void Update()
    {
        if (stop == true)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;

        GameObject.Find("WaveTime").GetComponent<Text>().text = "Time : " + (waveNext - (int)curTime);
        if (curTime >= waveNext)
        {
            StopAllCoroutines();
            iscase1 = false;
            curTime = 0;
            waveTime++;
        }
        if (waveTime == 9)
        {
            waveNext = endWaveTime;
        }

        curTime += Time.deltaTime;

        if (!iscase1)
        {
            switch (waveTime)
            {
                case 0:
                    wave1.SetActive(true);
                    StartCoroutine(SpawnAnEnemy());
                    iscase1 = true;
                    break;

                case 1:
                    wave2.SetActive(true);
                    StartCoroutine(SpawnAnEnemy());
                    iscase1 = true;
                    break;

                case 2:
                    wave3.SetActive(true);
                    StartCoroutine(SpawnAnEnemy1());
                    iscase1 = true;
                    break;

                case 3:
                    wave4.SetActive(true);
                    StartCoroutine(SpawnAnEnemy1());
                    iscase1 = true;
                    break;

                case 4:
                    wave5.SetActive(true);
                    StartCoroutine(SpawnAnEnemy1());
                    iscase1 = true;
                    break;

                case 5:
                    wave6.SetActive(true);
                    StartCoroutine(SpawnAnEnemy2());
                    iscase1 = true;
                    break;

                case 6:
                    wave7.SetActive(true);
                    StartCoroutine(SpawnAnEnemy2());
                    iscase1 = true;
                    break;

                case 7:
                    wave8.SetActive(true);
                    StartCoroutine(SpawnAnEnemy2());
                    iscase1 = true;
                    break;

                case 8:
                    wave9.SetActive(true);
                    StartCoroutine(SpawnAnEnemy3());
                    iscase1 = true;
                    break;

                case 9:
                    wave10.SetActive(true);
                    StartCoroutine(SpawnAnEnemy3());
                    iscase1 = true;
                    break;

                default:
                    SceneManager.LoadScene("Clear");
                    break;
            }
        }
    }
    IEnumerator SpawnAnEnemy()
    {

        yield return new WaitForSeconds(3.3f);
        while (true)
        {
            wave1.SetActive(false);
            wave2.SetActive(false);
            Vector2 spawnPos = GameObject.Find("Player").transform.position;
            spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
            if (stop == false)
                Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);

            yield return new WaitForSecondsRealtime(time);

        }
    }

    IEnumerator SpawnAnEnemy1()
    {
        yield return new WaitForSeconds(3.3f);
        while (true)
        {
            wave3.SetActive(false);
            wave4.SetActive(false);
            wave5.SetActive(false);
            Vector2 spawnPos1 = GameObject.Find("Player").transform.position;
            spawnPos1 += Random.insideUnitCircle.normalized * spawnRadius;

            if (stop == false)
                Instantiate(enemies1[Random.Range(0, enemies1.Length)], spawnPos1, Quaternion.identity);

            yield return new WaitForSecondsRealtime(time1);

        }
    }
    //-------------------------------
    IEnumerator SpawnAnEnemy2()
    {

        yield return new WaitForSeconds(3.3f);
        while (true)
        {
            wave6.SetActive(false);
            wave7.SetActive(false);
            wave8.SetActive(false);
            Vector2 spawnPos2 = GameObject.Find("Player").transform.position;
            spawnPos2 += Random.insideUnitCircle.normalized * spawnRadius;

            if (stop == false)
                Instantiate(enemies2[Random.Range(0, enemies2.Length)], spawnPos2, Quaternion.identity);

            yield return new WaitForSecondsRealtime(time2);

        }
    }
    IEnumerator SpawnAnEnemy3()
    {

        yield return new WaitForSeconds(3.3f);
        while (true)
        {
            wave9.SetActive(false);
            wave10.SetActive(false);
            Vector2 spawnPos3 = GameObject.Find("Player").transform.position;
            spawnPos3 += Random.insideUnitCircle.normalized * spawnRadius;

            if (stop == false)
                Instantiate(enemies3[Random.Range(0, enemies3.Length)], spawnPos3, Quaternion.identity);

            yield return new WaitForSecondsRealtime(time3);

        }
    }

}


