using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyActionController : MonoBehaviour {

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private GameObject bullet;
    public float _timebetweenshots;

    void Start()
    {
        StartCoroutine("StartAttack");
    }


    IEnumerator StartAttack ()
    {
        var minx = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        var maxx = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;
        var myx = transform.position.x;
        if (myx >minx && myx < maxx)
        {
            Debug.Log("I became visable");
            yield break;
        }
        yield return null;


    }
   

}


