using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float horiontal;
    private float speed = 8f;
    
    private float jumpingpower = 16f;

    private bool facingright = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horiontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrouded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
        }
        if (Input.GetButtonUp("Jump") && rb.velocity.y >0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * .5f);
        }
        Flip();

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horiontal * speed, rb.velocity.y);
    }

    private bool isGrouded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Flip()
    {
        if (facingright && horiontal <0f || !facingright && horiontal > 0f)
        {
            facingright = !facingright;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }

    }
}
