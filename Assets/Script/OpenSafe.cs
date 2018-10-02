using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSafe : MonoBehaviour,IInteractable {
    public void interact()
    {
        Safe.instance.OpenSafe();
        //throw new System.NotImplementedException();
    }

    public void interact(KeyCode key)
    {
        throw new System.NotImplementedException();
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
