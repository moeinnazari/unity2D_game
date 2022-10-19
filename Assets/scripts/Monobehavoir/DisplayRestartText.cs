using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayRestartText : MonoBehaviour
{
    private Texture2D t2d;
    // Start is called before the first frame update
    void Start()
    {
        t2d=Resources.Load<Texture2D>("restart-text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        float x=(Screen.width-t2d.width)/2;
        float y=Screen.height-50;

        if(Time.time%2>1)
        GUI.DrawTexture(new Rect(x,y,t2d.width,t2d.height),t2d);
    }
}
