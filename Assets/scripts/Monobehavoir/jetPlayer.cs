using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetPlayer : MonoBehaviour
{
    public PlayerController playerController;

    public Vector2 maxVelocity=new Vector2(3,5);
    public float speed=10f;
    public float jumpSpeed=20f;
    public float airSpeed=0.3f;
            bool standing;



    public AudioClip footLeftSound;
    public AudioClip footRightSound;
    public AudioClip thudSound;
    public AudioClip rocketSound;
    
    private Animator animator;       
    Rigidbody2D rb2d;
    void Start()
    {
        animator=GetComponent<Animator>();
        playerController=GetComponent<PlayerController>();
        rb2d=GetComponent<Rigidbody2D>();
    }

    void OnFootLeftSound()
    {
        if(footLeftSound)
        {
            AudioSource.PlayClipAtPoint(footLeftSound,transform.position);
        }
    }

    void OnFootRightSound()
    {
        if(footRightSound)
        {
            AudioSource.PlayClipAtPoint(footRightSound,transform.position);
        }
    }
    
    void PlayRocketSound()
    {
        if(!rocketSound || GameObject.Find("RocketSound"))
        return;

        GameObject go=new GameObject("RocketSound");
        AudioSource aSrc=go.AddComponent<AudioSource>();
        aSrc.clip=rocketSound;
        aSrc.volume=0.7f;
        aSrc.Play();

        Destroy(go,rocketSound.length);
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if(!standing)
        {
            var absVelX=Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x);
            var absVelY=Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y);
            
            if(absVelX <0.1f || absVelY <0.1f)
            {
                AudioSource.PlayClipAtPoint(thudSound,transform.position);      
            }
        }
    }

    
   // Update is called once per frame
    void Update()
    {
        float forcX=0f;
        float forcY=0f;


        float absVelX=Mathf.Abs(rb2d.velocity.x);
        float absVelY=Mathf.Abs(rb2d.velocity.y);

        if(absVelY < .2f)
        {
            standing=true;
        }
        else
        {
            standing=false;
        }

        if(playerController.movement.x !=0)
        {
            if(absVelX < maxVelocity.x)
            {
                forcX=standing ? speed*playerController.movement.x : (speed*airSpeed*playerController.movement.x);
                transform.localScale=new Vector3(forcX>0 ? 1 :-1 ,1,1);
              
            }

                animator.SetInteger("AnimState",1);

        }
        else
        {
                animator.SetInteger("AnimState",0);
        }
        
        if(playerController.movement.y >0)
        {

            PlayRocketSound();

            if(absVelY < maxVelocity.y)
             forcY=jumpSpeed*playerController.movement.y;
        
            animator.SetInteger("AnimState",2);
        }
        else if(absVelY > 0)
        {
            animator.SetInteger("AnimState",3);
        }

      
        rb2d.AddForce(new Vector2(forcX,forcY));
    }
   

   
}
