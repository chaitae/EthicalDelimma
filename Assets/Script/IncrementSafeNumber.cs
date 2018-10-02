using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum safeType
{
    A,B,C,
}
public class IncrementSafeNumber : MonoBehaviour,IInteractable {
    public safeType safeName;
    public void interact()
    {

        switch (safeName)
        {
            case safeType.A:
                Safe.instance.IncrementSafeNumberA();
                break;
            case safeType.B:
                Safe.instance.IncrementSafeNumberB();
                break;
            case safeType.C:
                Safe.instance.IncrementSafeNumberC();

                break;
        }
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
