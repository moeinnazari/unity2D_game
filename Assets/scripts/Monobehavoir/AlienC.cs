using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienC : MonoBehaviour
{
    Animator animator;
    float DelayFire=3f;
    public AudioClip attackSound;

    public Projectile projectile;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();

        if(DelayFire > 0f)
        {
            StartCoroutine(OnAttack());
        }
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("AnimState",0);
    }

    IEnumerator OnAttack()
    {
        yield return new WaitForSeconds(DelayFire);
        Fire();
        StartCoroutine(OnAttack());
    }

    void Fire()
    {
        animator.SetInteger("AnimState",1);
        
        if(attackSound)
         AudioSource.PlayClipAtPoint(attackSound,transform.position);
    }


    void Shoot()
    {
        if(projectile)
        {
            Projectile clone=Instantiate(projectile,transform.position,Quaternion.identity) as Projectile;

        }
    }
}
