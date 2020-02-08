using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector2 spawnRange;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",0f,3f);        
    }


    void SpawnEnemy()
    {
        Instantiate(enemyPrefab,new Vector3(Random.Range(-spawnRange.x,spawnRange.x),0,Random.Range(-spawnRange.y,spawnRange.y)),Quaternion.identity);
    }
}
