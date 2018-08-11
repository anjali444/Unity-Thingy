using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject enemy;
    public float spawnTime = 5f;
    public Transform spawnpoint;

    void Start()
    {
       InvokeRepeating("Spawn", spawnTime, spawnTime); 
    }
    

    public void Spawn()
    {
        Instantiate(enemy, spawnpoint.position, Quaternion.identity);
    }
}
