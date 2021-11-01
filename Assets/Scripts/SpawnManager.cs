using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {
        int index = Random.Range(0, spawnPoint.Length);
        Instantiate(enemy, spawnPoint[index].position, Quaternion.identity);
    }
}
