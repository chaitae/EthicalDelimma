using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chime : MonoBehaviour,IInteractable {
    public Colors color;
    public void interact()
    {
        WindChimeManager.instance.EnterColor(color);
        //throw new System.NotImplementedException();
    }

    public void interact(KeyCode key)
    {
        throw new System.NotImplementedException();
    }

    //public WindChimeManager windChimeManager;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
