using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;

public class Health :MonoBehaviour {
    public bool destroyOnDeath;

    public int life = 0;

    public void Hit (int damage)
    {
         
        
            life -= damage;
            if (life < 1)
                Destroy(gameObject);
        
    }

}
