using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,IActivatable,IInteractable,IItemInteracterble {
    public GameObject clickSFX;
    public DialogueTrigger doorDialogue;
    public SceneNames sceneTarget;
    public bool unlocked = false;
    public void Activate()
    {
        clickSFX.SetActive(true);
        doorDialogue.dialogue.sentences = new string[0];
        unlocked = true;
    }
    void DisableCollider()
    {
        GetComponent<Collider2D>().enabled = false;
    }
    void EnableCollider()
    {
        GetComponent<Collider2D>().enabled = true;

    }
    private void OnEnable()
    {
        DialogueManager.OnStartConversationHandler += DisableCollider;
        DialogueManager.OnEndConversationHandler += EnableCollider;
    }
    private void OnDisable()
    {
        DialogueManager.OnStartConversationHandler -= DisableCollider;
        DialogueManager.OnEndConversationHandler -= EnableCollider;
    }
    public void Deactivate()
    {
        //throw new System.NotImplementedException();
    }
    void Open()
    {
        CameraManager.instance.ChangeScene((int)sceneTarget);
    }
    public void interact()
    {
        if(unlocked)
        {
            Open();
        }
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

    public void interact(Item item)
    {
        if (item == Item.key)
        {
            unlocked = true;
            doorDialogue.dialogue.sentences = new string[0];
            clickSFX.SetActive(true);
            PlayerController.instance.RemoveItem(item);
        }
        //throw new System.NotImplementedException();
    }
}
