using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _moveForce;
    [SerializeField] private float _maxSpeed;
    public string _collisionTag = "Door";
    public GameObject _youwin;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit "+collision.gameObject.name);
        if (collision.gameObject.tag == _collisionTag)
        {
            Time.timeScale = 0;
            Instantiate(_youwin, transform.position, Quaternion.identity);
            //You win screen and stop game


        }
    }
}
