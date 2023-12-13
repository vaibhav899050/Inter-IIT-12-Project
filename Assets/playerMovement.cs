using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2f;
    public Rigidbody2D rb;
    public Rigidbody2D rb1;
    Vector2 movement;
    public Animator animator;
    bool ismovingx = false;
    bool ismovingy = false;
    void Start()
    {
        animator = animator.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement.x!=0 && movement.y != 0)
        {
            movement.x = 0;
            movement.y = 0;
        }
        if (movement.x < 0)
        {
            gameObject.transform.localScale = new Vector3(5, 5, 5);
        }
        if (movement.x > 0)
        {
            gameObject.transform.localScale = new Vector3(-5, 5, 5);
        }

        if (movement.y == 1)
        {
            animator.SetBool("upwalk", true);
        }
        if (movement.y == 0)
        {
            animator.SetBool("upwalk", false);
            animator.SetBool("dwalk", false);
        }
        if (movement.y == -1)
        {
            animator.SetBool("dwalk", true);
        }
        if (movement.x !=0)
        {
            animator.SetBool("lw", true);
        }
        if (movement.x == 1)
        {
            animator.SetBool("rrr", true);
        }
        if (movement.x == 0)
        {
            animator.SetBool("lw", false);
            animator.SetBool("rrr", false);

        }


    }

    void FixedUpdate()
    {
        /*if (movement.x != 0)
        {
            movement.y = 0;
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
        if (movement.y != 0)
        {
            movement.x = 0;
            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }*/
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        rb1.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
