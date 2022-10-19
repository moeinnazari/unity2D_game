using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : MonoBehaviour
{
    public Item item;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.gameObject.tag=="Player")
        {
            Destroy(gameObject);
        }
    }
}
