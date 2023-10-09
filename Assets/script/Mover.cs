using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float Movespeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -20)
            Destroy(gameObject);

         Vector2 targetMovePosition = (Vector2)transform.position;
        targetMovePosition.x -= Movespeed * Time.deltaTime;

        transform.position = (Vector2)targetMovePosition;
    }
}
