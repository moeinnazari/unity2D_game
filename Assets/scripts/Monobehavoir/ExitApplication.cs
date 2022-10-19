using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApplication : MonoBehaviour
{


    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Quit();
        }
    }

     void Quit() {
    #if UNITY_STANDALONE
        Application.Quit();
    #endif
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
}
}
