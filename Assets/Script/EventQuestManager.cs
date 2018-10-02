using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameEvent
{
    GotGiant,
    GotMermaid,
    GotInvis,
    GotPixie,
    FedPixie,
    SolvedClockPuzzle,
    WateredPixieBed
}
public class EventQuestManager : MonoBehaviour {
    public delegate void OnGainedGiant();
    public static event OnGainedGiant OnGainedGiantHandler;
    public delegate void OnSolvedClock();
    public static event OnSolvedClock OnSolvedClockHandler;
    public static event OnSolvedClock OnGotPixieHandler;
    public static event OnSolvedClock OnWateredBedHandler;
    public static event OnSolvedClock OnFedPixieHandler;
    public static EventQuestManager instance;
    public void WateredBed()
    {
        if(OnWateredBedHandler != null)
        {
            OnWateredBedHandler();
        }
    }
    public void GotGiant()
    {
        Debug.Log("inside got giant");
        if (OnGainedGiantHandler != null)
            OnGainedGiantHandler();
    }
    public void FedPixie()
    {
        if(OnFedPixieHandler != null)
        {
            OnFedPixieHandler();
        }
    }
    public void GotPixie()
    {
        if(OnGotPixieHandler != null)
        {
            OnGotPixieHandler();
        }

    }
    public void SolvedClockPUzzle()
    {
        if(OnSolvedClockHandler != null)
        {
            OnSolvedClockHandler();
        }
    }
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
