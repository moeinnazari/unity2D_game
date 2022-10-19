using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToContinue : MonoBehaviour
{
    public string scene;
        bool loadlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !loadlock)
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        loadlock=true;
        Application.LoadLevel(scene);
    }
}
