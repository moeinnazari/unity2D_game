using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPart : MonoBehaviour
{
    SpriteRenderer spriteRender;
     float t=0f;
     Color start;
     Color end;
    // Start is called before the first frame update
    void Start()
    {
        spriteRender=GetComponent<SpriteRenderer>();
        start=spriteRender.color;
        end=new Color(start.r,start.g,start.b,0f);
    }

    // Update is called once per frame
    void Update()
    {
        t+=Time.deltaTime;
        spriteRender.color=Color.Lerp(start,end, t/2);
        
        if(spriteRender.color.a <=0)
        {
          Destroy(gameObject,3f);    
        }
        
    }

}
