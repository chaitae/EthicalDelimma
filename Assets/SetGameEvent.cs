using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameEvent : MonoBehaviour,IActivatable{
    public GameEvent gameEvent;

    public void Activate()
    {
        SetQuest();
        //Debug.Log("setquest");
        //throw new System.NotImplementedException();
    }

    public void Deactivate()
    {
        //throw new System.NotImplementedException();
    }

    void SetQuest()
    {
        switch (gameEvent)
        {
            case GameEvent.FedPixie:
                EventQuestManager.instance.FedPixie();
                break;
            case GameEvent.GotGiant:
                break;
            case GameEvent.GotInvis:
                break;
            case GameEvent.GotMermaid:
                break;
            case GameEvent.SolvedClockPuzzle:
                break;
            case GameEvent.WateredPixieBed:
                EventQuestManager.instance.WateredBed();
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
