using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Item")]


public class Item : ScriptableObject
{
   public Sprite sprite;
   public bool stackable;
   public enum ItemType
   {
    HEALTH,
    CRYSTAL,
    COIN,
    ARTIFACT
   }

    public ItemType itemType;

    public float quantity;
}
