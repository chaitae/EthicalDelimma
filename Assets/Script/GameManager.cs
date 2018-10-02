using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static int day = 0;
    public static int hour = 8;
    public static GameManager instance;
    public delegate void timeChanged();
    public static event timeChanged OnTimeChangedHandler;
    // Use this for initialization
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    public void IncreaseHour()
    {

        hour++;
        if(hour > 24)
        {
            day++;
            hour = 0;
        }
        if (OnTimeChangedHandler != null)
        {
            OnTimeChangedHandler();
        }
    }
    public void IncreaseDay()
    {

        day++;
        if (OnTimeChangedHandler != null)
        {
            OnTimeChangedHandler();
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
