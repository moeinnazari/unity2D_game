using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Rigidbody2D rb2d;
    Transform transforms;
    public float speed=3f;
    public int directMove=1;
    // Start is called before the first frame update
    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();
        transforms=GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity=new Vector2(transforms.localScale.x*directMove,0)* speed;
    }
}
