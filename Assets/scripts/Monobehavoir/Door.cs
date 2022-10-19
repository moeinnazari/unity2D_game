using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public const int  IDLE=0;
    public const int  OPENING=1;
    public const int  OPEN=2;
    public const int  CLOSE=3;
    int state;
    public float closedDelay=0.5f;


    public AudioClip doorSound;

    Animator animator;
    Collider2D collider2d;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        collider2d=GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnStartOpen()
    {
        state=OPENING;
    }
    
    void OnEndOpen()
    {
        state=OPEN;
    }

    void OnStartClosing()
    {
        state=CLOSE;
    }

    void OnEndClosing()
    {
        state=IDLE;
    }

    void OnDisableCollider()
    {
        collider2d.enabled=false;
    }
    void OnEnableCollider()
    {
        collider2d.enabled=true;
    }

    public void Open()
    {
        animator.SetInteger("AnimState",1);
        if(doorSound)
        AudioSource.PlayClipAtPoint(doorSound,transform.position);
    }

    public void Close()
    {
        StartCoroutine(closeNow());
    }


    public IEnumerator closeNow()
    {
        yield return new WaitForSeconds(closedDelay);

        animator.SetInteger("AnimState",2);
          if(doorSound)
        AudioSource.PlayClipAtPoint(doorSound,transform.position);
    }




}
