using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour,IInteractable {
    public GameObject[] activatableGo;
    bool toggle = true;
    public void interact()
    {

        foreach(GameObject activatable in activatableGo)
        {
            if(toggle)
            activatable.GetComponent<IActivatable>().Activate();
            else
            {
                activatable.GetComponent<IActivatable>().Deactivate();

            }
        }
        toggle = !toggle;
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
