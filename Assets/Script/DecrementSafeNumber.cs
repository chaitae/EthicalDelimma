using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementSafeNumber : MonoBehaviour,IInteractable {
    public safeType safeName;

    public void interact()
    {
        switch (safeName)
        {
            case safeType.A:
                Safe.instance.DecrementSafeNumberA();
                break;
            case safeType.B:
                Safe.instance.DecrementSafeNumberB();

                break;
            case safeType.C:
                Safe.instance.DecrementSafeNumberC();

                break;
        }
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
