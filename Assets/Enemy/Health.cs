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
            //Destroy(gameObject);

            if (gameObject.tag == "Player")
            {
                //Debug.Log("GAME OVER");
                Time.timeScale = 0;
                _playerDeath = true;
            }

            else
            {
                Destroy(gameObject);
            }

        }

    }
    public void OnGUI()
    {
        if (_playerDeath)

        {
            GUI.TextField(new Rect(10, 10, 200, 20), "Game Over", 25);
            Destroy(gameObject);
        }
    }
}
