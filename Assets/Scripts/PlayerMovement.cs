using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 2.0f;
    public float jumpSpeed = 3.0f;
    private Rigidbody2D _rb2d;
    
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            _rb2d.velocity = new Vector2(runSpeed, _rb2d.velocity.y);
        }
        
        else if (Input.GetKey("left"))
        {
            _rb2d.velocity = new Vector2(-runSpeed, _rb2d.velocity.y);
        }
        
        else
        {
            _rb2d.velocity = new Vector2(0, _rb2d.velocity.y);
        }
        
        if (Input.GetKey("space") && CheckGround.IsGrounded)
        {
            _rb2d.velocity = new Vector2(_rb2d.velocity.x, jumpSpeed);
        }
    }
}
