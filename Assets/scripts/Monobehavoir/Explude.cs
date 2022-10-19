using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explude : MonoBehaviour
{
    public BodyPart bodyPart;
    public int totalPart;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D trigger)
    {
        if(trigger.gameObject.tag=="Deadly")
        {
            OnExplude();
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag=="Deadly")
        {
            OnExplude();
        }
    }

   public void OnExplude()
    {
        
       Destroy(gameObject);

        Transform t=GetComponent<Transform>();

        for(int i=0;i<=totalPart;i++)
        {
            t.TransformPoint(0f,-100f,0f);
            BodyPart clone=Instantiate(bodyPart,t.position,Quaternion.identity) as BodyPart;
            clone.GetComponent<Rigidbody2D>().AddForce(Vector3.right*Random.Range(-60,60));
            clone.GetComponent<Rigidbody2D>().AddForce(Vector3.up*Random.Range(200,500));
               
        }
        
        GameObject go=new GameObject("ClickToContinue");
        ClickToContinue script=go.AddComponent<ClickToContinue>();
        script.scene=Application.loadedLevelName;
        go.AddComponent<DisplayRestartText>();
    }

    
}
