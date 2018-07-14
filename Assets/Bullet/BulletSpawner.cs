using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour {

    public GameObject bullet;
    public float spawnTime = 3f;
    public bool autofire = true;
	void Start ()
    {
        if (autofire) { InvokeRepeating("Spawn", spawnTime, spawnTime); }
	}
	
	public void Spawn ()
    {
            Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
