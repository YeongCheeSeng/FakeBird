using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{

    public float JumpForce = 200f;
    public float MoveForce = 400f;

    public float StartGameDelay = 1f;
    private float _timer = 0f;

    private Rigidbody2D _rigidBody2D;




     void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        _timer = StartGameDelay;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // Vevtor2.up = (0,1)
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.up * JumpForce);
        }

        if (Input.GetKeyDown("left"))
        {
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.up * JumpForce);
            _rigidBody2D.AddForce(Vector2.left * MoveForce);
        }

        if (Input.GetKeyDown("right"))
        {
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.up * JumpForce);
            _rigidBody2D.AddForce(Vector2.right * MoveForce);
        }

        if (Input.GetKeyDown("down"))
        {
            _rigidBody2D.velocity = Vector2.zero;
            _rigidBody2D.AddForce(Vector2.down * JumpForce);
        }

        if (_timer > 0f)
        {
            _rigidBody2D.velocity = Vector2.zero;
            _timer -= Time.deltaTime;
            return;
        }

    }


}
