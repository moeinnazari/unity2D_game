using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectFloat : MonoBehaviour
{
    float startY=0f;
    float duration=1f;
    Transform t;
    // Start is called before the first frame update
    void Start()
    {
        t=GetComponent<Transform>();
        startY=t.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float newY=startY+(startY+Mathf.Cos(Time.time)/duration*2)/4;
        t.position=new Vector2(transform.position.x,newY);
    }
}
