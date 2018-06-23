using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _moveForce;
    [SerializeField] private float _maxSpeed;


    private void FixedUpdate()
    {
        float axis;
        axis = Input.GetAxisRaw("Horizontal");
    }

}
