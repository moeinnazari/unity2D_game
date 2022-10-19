using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitSign : MonoBehaviour
{
    public string scene;
   

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag=="Player")
        {
            Destroy(target.gameObject,2f);
            Destroy(gameObject,2f);
            Application.LoadLevel(scene);
        }
    }
}
