using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health {

    public GameObject _gameover;

    protected override void HandleDeath()
    {
        Time.timeScale = 0;
        Instantiate(_gameover, transform.position, Quaternion.identity);
    }
}
