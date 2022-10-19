using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCharecter : MonoBehaviour
{
    Rigidbody2D rb2d;

    [Header("Movement")]
    public float moveSpeed=5f;
    public float jumpSpeed=15f;
    Vector2 move=Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement=Input.GetAxisRaw("Horizontal");

        rb2d.velocity=new Vector2(moveSpeed*movement,rb2d.velocity.y);
        
        if(Input.GetKeyDown(KeyCode.Space) && rb2d.velocity.y <0.001f)
        {
            Debug.Log("jump");
            rb2d.AddForce(new Vector2(0,jumpSpeed),ForceMode2D.Impulse);
        }

    }
}
