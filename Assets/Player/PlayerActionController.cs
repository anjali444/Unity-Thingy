using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour {

    public BulletSpawner _bulletSpawner;

    private void Start()
    {
        _bulletSpawner.Spawn();
    }
}
