using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovementSpeed;
    public float JumpForce;

    
    private float move;
    private Rigidbody2D rb;
   
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(move * MovementSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") /*&& !isJumping*/)
        {
            rb.AddForce(new Vector2(rb.velocity.x, JumpForce));
            //isJumping = true;
        }
    }
    

    //private void OnCollisionEnter2D(Collision2D other)
    //{
    //    if(gameObject.CompareTag("Ground"))
    //    {
    //        isJumping = false;
    //    }
    //}


}
