using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour,IInteractable {
    public Item item;
    public void interact()
    {
        PlayerController.instance.AddItem(item);
        Destroy(gameObject);
        //throw new System.NotImplementedException();
    }

    public void interact(KeyCode key)
    {
        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
