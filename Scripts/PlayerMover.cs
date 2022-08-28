using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] public float runSpeed = 0f;
    [SerializeField] public float jumpForce = 0f;
    private float dirX = 0f;

    [SerializeField] public int howFarTheGround = 0;

    [SerializeField] private LayerMask jumpableGround;
    //this one is for ground check.
    private BoxCollider2D coll;
    //
    private Rigidbody2D rb;
    private Animator anim;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * runSpeed, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(0, jumpForce, 0);
        }

        Updateanimation();
    }  

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, howFarTheGround, jumpableGround);
        
    }

    private void Updateanimation()
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else
        {
            anim.SetBool("running", false);
            transform.Rotate(0.0f, 0.0f, 0.0f);
        }
    }
}
