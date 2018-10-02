using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickActivate : MonoBehaviour,IInteractable {
    public GameObject activatable;
    public bool showStuff = true;
    public void interact()
    {

        if (!showStuff)
            activatable.GetComponent<SetActiveInactive>().Deactivate();
        else
            activatable.GetComponent<SetActiveInactive>().Activate();
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
