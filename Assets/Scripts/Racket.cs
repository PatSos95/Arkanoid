using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {

    public float speed = 150;

   // Vector2 a = GetComponent<BoxCollider2D>().size;

    
    

    private void FixedUpdate()
    {
        // Get Horizontal Input
        float h = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
