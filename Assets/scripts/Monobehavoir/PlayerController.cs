using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 movement=new Vector2();
    
  

    // Update is called once per frame
    void Update()
    {
        movement.x=movement.y=0;
        
        if(Input.GetKey("right"))
        {
            movement.x=1;
        }
        else if(Input.GetKey("left"))
        {
            movement.x=-1;
        }

        if(Input.GetKey("up"))
        {
            movement.y=1;
        }
        else if(Input.GetKey("down"))
        {
            movement.y=-1;
        }
    }
}
