using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayerMovement : MonoBehaviour
{
  
    //movement speed
    public float moveSpeed = 5f;
  
    
    //reference to the rigidbody that moves the player
    public Rigidbody2D rb;

    Vector2 movement;

    
    // Update is called once per frame
    // dont use this because frame rate can change so need a fixed update
    // update is kept for registering Input
    void Update()        // Input
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    //works the same as update but is called a bunch of times per sec but does it on a fixed timer
    private void FixedUpdate() //movement
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }


}
