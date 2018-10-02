using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour,IActivatable {
    public void Activate()
    {
        TorchManager.instance.AddTorchesLit();
        //throw new System.NotImplementedException();
    }

    public void Deactivate()
    {
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
