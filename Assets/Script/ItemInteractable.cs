using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInteractable : MonoBehaviour, IItemInteracterble
{
    public void interact(Item item)
    {
        Debug.Log("interacted with: " + item);
        //if likes item it makes dialogue
    }
}
