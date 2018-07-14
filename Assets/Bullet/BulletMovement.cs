using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public Vector3 _velocity;
    public string _collisionTag;
	
	// Update is called once per frame
	void Update () {
        transform.position += _velocity * Time.deltaTime;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("bullet!");
        if (collision.tag == _collisionTag)
        {
            Debug.Log("bullet touches player!");
            Destroy(gameObject);

        }
    }
}
//add collision tag to player and ask Eris