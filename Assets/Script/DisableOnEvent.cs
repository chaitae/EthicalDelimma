using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnEvent : MonoBehaviour {
    public GameEvent gEvent;
    void EventHappened()
    {
        gameObject.SetActive(false);
    }
    void OnEnable()
    {
        //bah = GetComponent<DialogueTrigger>();
        switch (gEvent)
        {
            case GameEvent.GotGiant:
                Debug.Log("i'm subscribed");
                EventQuestManager.OnGainedGiantHandler += EventHappened;
                break;
            case GameEvent.GotInvis:
                break;
            case GameEvent.GotMermaid:
                break;
            case GameEvent.GotPixie:
                break;
            case GameEvent.FedPixie:
                EventQuestManager.OnFedPixieHandler += EventHappened;

                break;
        }

    }
    private void OnDisable()
    {
        switch (gEvent)
        {
            case GameEvent.GotGiant:
                EventQuestManager.OnGainedGiantHandler -= EventHappened;
                break;
            case GameEvent.GotInvis:
                break;
            case GameEvent.GotMermaid:
                break;
            case GameEvent.GotPixie:
                break;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
