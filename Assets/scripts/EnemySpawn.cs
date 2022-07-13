using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour
{




    [SerializeField]
    private float spawnRadius = 7,
            time,
            time1,
            time2,
            time3;
    int waveTime = 0;
    [SerializeField] GameObject wave1Penal;
    [SerializeField] GameObject wave1Pena2;
    [SerializeField] GameObject wave1Pena3;
    [SerializeField] GameObject wave1Pena4;
    [SerializeField] GameObject wave1Pena5;
    [SerializeField] GameObject wave1Pena6;
    [SerializeField] GameObject wave1Pena7;
    [SerializeField] GameObject wave1Pena8;
    [SerializeField] GameObject wave1Pena9;
    [SerializeField] GameObject wave1Pena10;
    public GameObject[] enemies;
    public GameObject[] enemies1;
    public GameObject[] enemies2;
    public GameObject[] enemies3;

    bool iscase1;


    float curTime = 0;
    private void Start()
    {
        /*        switch (waveTime)
                {
                    case 0:

                        Debug.Log("a");
                        StartCoroutine(SpawnAnEnemy());
                        iscase1 = false;
                        break;
                    default: return;
                }*/

    }
    public void Update()
    {
        if (curTime >= 55)
        {
            StopAllCoroutines();
            iscase1 = false;
            curTime = 0;
            waveTime++;
        }


        curTime += Time.deltaTime;

        if (!iscase1)
        {
            switch (waveTime)
            {
                case 0:
                    wave1Penal.SetActive(true);
                    StartCoroutine(SpawnAnEnemy());
                    iscase1 = true;
                    break;
                case 1:
                    wave1Pena2.SetActive(true);
                    StartCoroutine(SpawnAnEnemy());
                    iscase1 = true;
                    break;
                case 2:
                    wave1Pena3.SetActive(true);
                    StartCoroutine(SpawnAnEnemy1());
                    iscase1 = true;
                    break;
                case 3:
                    wave1Pena4.SetActive(true);
                    StartCoroutine(SpawnAnEnemy1());
                    iscase1 = true;
                    break;
                case 4:
                    wave1Pena5.SetActive(true);
                    StartCoroutine(SpawnAnEnemy1());
                    iscase1 = true;
                    break;
                case 5:
                    wave1Pena6.SetActive(true);
                    StartCoroutine(SpawnAnEnemy2());
                    iscase1 = true;
                    break;
                case 6:
                    wave1Pena7.SetActive(true);
                    StartCoroutine(SpawnAnEnemy2());
                    iscase1 = true;
                    break;
                case 7:
                    wave1Pena8.SetActive(true);
                    StartCoroutine(SpawnAnEnemy2());
                    iscase1 = true;
                    break;
                case 8:
                    wave1Pena9.SetActive(true);
                    StartCoroutine(SpawnAnEnemy3());
                    iscase1 = true;
                    break;
                case 9:
                    wave1Pena10.SetActive(true);
                    StartCoroutine(SpawnAnEnemy3());
                    iscase1 = true;
                    break;
                default: return;
            }
        }
    }

    /*    public void Spawnenemy(int enemy)
        {
            while (enemy <= 0)
            {
                Vector2 spawnPos = GameObject.Find("Player").transform.position;
                spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

                Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
                enemy--;
                 return;
            }
        }*/
    IEnumerator SpawnAnEnemy()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            wave1Penal.SetActive(false);
            wave1Pena2.SetActive(false);
            Vector2 spawnPos = GameObject.Find("Player").transform.position;
            spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);

            yield return new WaitForSecondsRealtime(time);

        }
    }
    IEnumerator SpawnAnEnemy1()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            wave1Pena3.SetActive(false);
            wave1Pena4.SetActive(false);
            wave1Pena5.SetActive(false);
            Vector2 spawnPos1 = GameObject.Find("Player").transform.position;
            spawnPos1 += Random.insideUnitCircle.normalized * spawnRadius;

            Instantiate(enemies1[Random.Range(0, enemies1.Length)], spawnPos1, Quaternion.identity);

            yield return new WaitForSecondsRealtime(time1);

        }
    }
    IEnumerator SpawnAnEnemy2()
    {
        wave1Pena6.SetActive(false);
        wave1Pena7.SetActive(false);
        wave1Pena8.SetActive(false);
        yield return new WaitForSeconds(5);
        while (true)
        {
            Vector2 spawnPos2 = GameObject.Find("Player").transform.position;
            spawnPos2 += Random.insideUnitCircle.normalized * spawnRadius;

            Instantiate(enemies2[Random.Range(0, enemies2.Length)], spawnPos2, Quaternion.identity);

            yield return new WaitForSecondsRealtime(time2);

        }
    }
    IEnumerator SpawnAnEnemy3()
    {
        wave1Pena9.SetActive(false);
        wave1Pena10.SetActive(false);

        yield return new WaitForSeconds(5);
        while (true)
        {
            Vector2 spawnPos3 = GameObject.Find("Player").transform.position;
            spawnPos3 += Random.insideUnitCircle.normalized * spawnRadius;

            Instantiate(enemies3[Random.Range(0, enemies3.Length)], spawnPos3, Quaternion.identity);

            yield return new WaitForSecondsRealtime(time3);

        }
    }

}


