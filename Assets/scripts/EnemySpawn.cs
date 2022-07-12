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
        float randomX = Random.Range(-7.5f, 8.5f); //���� ��Ÿ�� X��ǥ�� �������� ������ �ݴϴ�.
        float randomY = Random.Range(-5f, 5f);
        if (enableSpawn)
        {
            GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, 5f, 0f), Quaternion.identity);
            GameObject enemy2 = (GameObject)Instantiate(Enemy2, new Vector3(randomX, -5f, 0f), Quaternion.identity);
            GameObject enemy3 = (GameObject)Instantiate(Enemy3, new Vector3(-7.5f, randomY, 0f), Quaternion.identity);//������ ��ġ��, ȭ�� ���� ������ Enemy�� �ϳ� �������ݴϴ�.
            GameObject enemy4 = (GameObject)Instantiate(Enemy4, new Vector3(8.8f, randomY, 0f), Quaternion.identity);//������ ��ġ��, ȭ�� ���� ������ Enemy�� �ϳ� �������ݴϴ�.
        }
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, 2); //3���� ����, SpawnEnemy�Լ��� 1�ʸ��� �ݺ��ؼ� ���� ��ŵ�ϴ�.
        
    }
    void Update()
    {

    }
}
