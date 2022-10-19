using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienB : MonoBehaviour
{
    Animator animator;
    private bool readyToAttack;

    public AudioClip atackSound;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }


    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag=="Player")
        {
            
             
                Debug.Log("hit");
                 var clone=trigger.GetComponent<Explude>() as Explude;
                clone.OnExplude();            
                animator.SetInteger("AnimState",1);
               if(atackSound)
                AudioSource.PlayClipAtPoint(atackSound,transform.position);
                

           
        }
        
    }

    void OnTriggerExit2D(Collider2D trigger)
    {
        readyToAttack=false;
        Debug.Log("exit");
        animator.SetInteger("AnimState",0);
    }

    void Attack()
    {
        readyToAttack=true;
        Debug.Log("attack  "+readyToAttack);
    }

   
}
