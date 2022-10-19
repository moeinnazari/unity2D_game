using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
        Vector3 offset=new Vector3(0f,0f,-10f);
        float smoothTime=0.4f;
        Vector3 velocity=Vector3.zero;
    //Camera camera;
    void Awake()
    {
         transform.position=new Vector3(target.position.x,target.position.y,transform.position.z);
       // camera=GetComponent<Camera>();
       // camera.orthographicSize=(Screen.height/2f)/100f;
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if(target)
        {
        Vector3 movePosition=target.position+offset;
        transform.position=Vector3.SmoothDamp(transform.position, movePosition, ref velocity, smoothTime);    
        }
        else
        {
            transform.position=new Vector3(transform.position.x,transform.position.y,transform.position.z);
        }
        
    }
}
