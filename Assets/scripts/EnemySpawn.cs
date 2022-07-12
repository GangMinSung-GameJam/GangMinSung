using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public GameObject Enemy;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    void SpawnEnemy()
    {
        float randomX = Random.Range(-7.5f, 8.5f); //적이 나타날 X좌표를 랜덤으로 생성해 줍니다.
        float randomY = Random.Range(-5f, 5f);
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, 5f, 0f), Quaternion.identity);
            GameObject enemy2 = (GameObject)Instantiate(Enemy2, new Vector3(randomX, -5f, 0f), Quaternion.identity);
            GameObject enemy3 = (GameObject)Instantiate(Enemy3, new Vector3(-7.5f, randomY, 0f), Quaternion.identity);//랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
            GameObject enemy4 = (GameObject)Instantiate(Enemy4, new Vector3(8.8f, randomY, 0f), Quaternion.identity);//랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, 2); //3초후 부터, SpawnEnemy함수를 1초마다 반복해서 실행 시킵니다.
        
    }
    void Update()
    {

    }
}
