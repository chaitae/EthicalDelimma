using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveItem : MonoBehaviour,IActivatable {
    public Item item;
    public void Activate()
    {
        PlayerController.instance.AddItem(item);
        //throw new System.NotImplementedException();
    }

    public void Deactivate()
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
