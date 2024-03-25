using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    Collider2D _coll2d;
    Rigidbody2D _rb2d;
    bool _isGrounded;
    float _horizontal;
    float _speed = 8f;
    float _jumpPower = 16f;

    private void Awake()
    {

        _coll2d = GetComponent<Collider2D>();
        _rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        RaycastHit2D[] hit2d = new RaycastHit2D[1];
        if (_coll2d.Cast(Vector2.down, hit2d, 0.5f) > 0) _isGrounded = false; else _isGrounded = true;
        print(_isGrounded);
    }
}
