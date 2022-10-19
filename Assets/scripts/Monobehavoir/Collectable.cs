using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
   
   public AudioClip pickingUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag=="Player")
        {
            if(pickingUp)
            AudioSource.PlayClipAtPoint(pickingUp,transform.position);
            
            Destroy(gameObject);
        }
    }
}
