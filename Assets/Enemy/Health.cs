using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class Health : MonoBehaviour {

    public int life = 0;
    private bool _playerDeath = false;
    public void Hit (int damage)
    {
            life -= damage;
        if (life < 1)
        {
            HandleDeath();

        }

    }


    protected virtual void HandleDeath ()
    {
        Destroy(gameObject);
    }

}
