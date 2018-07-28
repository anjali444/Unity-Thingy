using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {

    public Vector3 _velocity;
    public string _collisionTag;
    public int _damage = 1;
	
	
	void Update () {
        transform.position += _velocity * Time.deltaTime;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == _collisionTag)
        {
            var health = collision.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.Hit(_damage);
            }

            Destroy(gameObject);

        }
    }
}
