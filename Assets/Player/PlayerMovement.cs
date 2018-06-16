using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _moveForce;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _jumpForce;

    public Transform groundCheck;
    bool grounded = false;

    private void FixedUpdate()
    {
        float axis;
        float vertAxis;
        float jumpAmount;

        jumpAmount = 0;
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        Debug.Log(grounded);

        axis = Input.GetAxisRaw("Horizontal");
        vertAxis = Input.GetAxisRaw("Vertical");

        if (grounded) { jumpAmount = vertAxis * _jumpForce; }

        Vector2 force = new Vector2(axis * _moveForce, jumpAmount);
        _rigidbody.AddForce(force);
        if (Mathf.Abs(_rigidbody.velocity.x) > _maxSpeed) { _rigidbody.velocity = Mathf.Sign(_rigidbody.velocity.x) * new Vector2(_maxSpeed, _rigidbody.velocity.y); }
    }


}
