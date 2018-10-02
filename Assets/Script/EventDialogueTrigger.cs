using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDialogueTrigger : MonoBehaviour {
    public DialogueTrigger bah;
    public string[] questSentence;
    public GameObject activatableGO;
    public GameEvent gEvent;
    void EventHappened()
    {
        Debug.Log("event happened");
        bah.dialogue.sentences = questSentence;
        //Dothing();
        bah.OnEndConversationHandler += Dothing;
        //bah.dialogue.activatableGO = activatableGO;
    }
    void Dothing()
    {
        Debug.Log("did thing");
        IActivatable[] activatables = activatableGO.GetComponents<IActivatable>();
        foreach (IActivatable activatable in activatables)
        {
            activatable.Activate();
        }
        activatableGO.GetComponent<IActivatable>().Activate();
        //bah.OnEndConversationHandler -= Dothing;
    }
  
    // Use this for initialization
    void OnEnable() {
        bah = GetComponent<DialogueTrigger>();
        switch(gEvent)
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
                EventQuestManager.OnGotPixieHandler += EventHappened;
                break;
            case GameEvent.SolvedClockPuzzle:
                EventQuestManager.OnSolvedClockHandler += EventHappened;
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

    // Update is called once per frame
    void Update () {
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        EventQuestManager.instance.GotGiant();
        //    }
    }
}
