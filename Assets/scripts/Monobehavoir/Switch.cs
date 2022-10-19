using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public DoorTrigger doorTrigger;
    Animator animator;

    public AudioClip switchSound;

    public bool sticky;
    private bool down;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        animator.SetInteger("AnimState",1);
      
        if(switchSound)
         AudioSource.PlayClipAtPoint(switchSound,transform.position);
     

        doorTrigger.Toggle(true);

        down=true;
    }

    void OnTriggerExit2D(Collider2D trigger)
    {
        if(sticky && down)
          return;

          down=false;
        animator.SetInteger("AnimState",2);
        if(switchSound)
         AudioSource.PlayClipAtPoint(switchSound,transform.position);
         
        doorTrigger.Toggle(false);
    }

    void OnDrawGizmos()
    {
        Gizmos.color=sticky? Color.red : Color.green;

        Gizmos.DrawLine(transform.position,doorTrigger.transform.position);
    }
}
