using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meter : MonoBehaviour
{
    private GameObject player;
    public float air=10f;
    public float airMax=10f;
    public float airBonous=1f;

    public Texture2D airbg;
    public Texture2D airHpbg;
            int iconWidth=32;
    Vector2 offset=new Vector2(10f,10f);


    void OnGUI()
    {   
        float percent=Mathf.Clamp01(air/airMax);

        if(!player)
            percent=0;

        DrawMeter(offset.x,offset.y,airHpbg,airbg,percent);
    }

    void DrawMeter(float x,float y,Texture2D texture,Texture2D background,float percent )
    {
        float bgw=background.width;
        float bgh=background.height;

        GUI.DrawTexture(new Rect(x,y,bgw,bgh),background);

        float nw=((bgw-iconWidth)*percent)+iconWidth;
        GUI.BeginGroup(new Rect(x,y,nw,bgh));
        GUI.DrawTexture(new Rect(0,0,bgw,bgh),texture);
        GUI.EndGroup();
    }


    // Start is called before the first frame update
    void Awake()
    {
      
       player=GameObject.FindGameObjectsWithTag("Player")[0];   
          
          
    }

    // Update is called once per frame
    void Update()
    {
        if(!player)
           return;

            if(air>0)
            {
              air-=Time.deltaTime*airBonous;
            }
            else
            {
                Explude script=player.GetComponent<Explude>();
                script.OnExplude();

            }
        

        
    }
}
