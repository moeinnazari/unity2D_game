using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Door door;
    public bool ignoreTrigger;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(ignoreTrigger)
        {
            return;
        }

        if(trigger.gameObject.tag=="Player")
        {
            door.Open();
        }
    }

    void OnTriggerExit2D(Collider2D trigger)
    {
        if(ignoreTrigger)
        {
            return;
        }


        if(trigger.gameObject.tag=="Player")
        {
            door.Close();
        }
    }

    public void Toggle(bool value)
    {
        if(value)
        {
            door.Open();
        }
        else
        {
            door.Close();
        }
    }
       
}
