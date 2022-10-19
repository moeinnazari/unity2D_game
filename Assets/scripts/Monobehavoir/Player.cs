using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rb2d;

    string animState="animationState";
     
    public float movementSpeed=5f;    
    Vector2 movement=new Vector2();
    // Start is called before the first frame update

    void Awake()
    {
        gameObject.SetActive(true);
    }
    void Start()
    {
        animator=GetComponent<Animator>();
        rb2d=GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdateState();
    }
 
      // Update is called once per frame
    void FixedUpdate()
    {
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y=Input.GetAxisRaw("Vertical");

        movement.Normalize();

        rb2d.velocity=movement*movementSpeed;
    }


    private void UpdateState()
    {
        if(movement.x > 0)
        {
           
            animator.SetInteger(animState,1);
        }
        else if(movement.x <0)
        {
           
            animator.SetInteger(animState,2);
        }
        else if(movement.y > 0)
        {
            
            animator.SetInteger(animState,3);
        }
        else if(movement.y < 0)
        {
           
            animator.SetInteger(animState,4);
        }
        else
        {
           
            animator.SetInteger(animState,5);
        }
    }

  
}
