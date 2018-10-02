using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandDoor : MonoBehaviour,IInteractable {
    public SceneNames sceneTarget;
    public DialogueTrigger diagTrig;
    public bool unlocked = false;

    public void interact()
    {
        Debug.Log("interacted");
        Open();
        //throw new System.NotImplementedException();
    }

    public void interact(KeyCode key)
    {
        //throw new System.NotImplementedException();
    }
    void CheckUnlocked()
    {
        if(PlayerController.instance.hasGiant && PlayerController.instance.hasMermaid && PlayerController.instance.hasPixie)
        {
            //Open();
            Debug.Log("opened grand door");
            unlocked = true;
        }
    }
    void Open()
    {
        CheckUnlocked();
        if(unlocked)
        {
            CameraManager.instance.ChangeScene((int)sceneTarget);
            diagTrig.TriggerDialogue();
        }
    }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
