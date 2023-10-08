using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{

    public float JumpForce = 200f;
    public float MoveForce = 400f;

    private Rigidbody2D _rigidBody2D;
    

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            // Vevtor2.up = (0,1)
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.up * JumpForce);
            Debug.Log("We should jump");
        }

        if (Input.GetKeyDown("left")) 
        {
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.up * JumpForce);
            _rigidBody2D.AddForce(Vector2.left * MoveForce);
            Debug.Log("We should left");
        }

        if (Input.GetKeyDown("right"))
        {
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.up * JumpForce);
            _rigidBody2D.AddForce(Vector2.right * MoveForce);
            Debug.Log("We should right");
        }

    }
}
