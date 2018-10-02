using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBoxColliders : MonoBehaviour,IActivatable {
    public BoxCollider2D[] boxCols;
    public void Activate()
    {
        foreach(BoxCollider2D boxCol in boxCols)
        {
            boxCol.enabled = true;
        }
        //throw new System.NotImplementedException();
    }

    public void Deactivate()
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
