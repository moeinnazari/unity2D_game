using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForward : MonoBehaviour
{
    public Transform startSigh,endSigh;
            bool collision=false;
    public bool needCollision=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        collision=Physics2D.Linecast(startSigh.position,endSigh.position,1<< LayerMask.NameToLayer("Solid"));
        Debug.DrawLine(startSigh.position,endSigh.position,Color.red);

         if(collision==needCollision)
         this.transform.localScale=new Vector3(transform.localScale.x>=1?-1:1,1,1);
    }
}
