using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Colors
{
    Red,
    Orange,
    Green,
    Blue,
    Purple
}
public class WindChimeManager : MonoBehaviour {
    public DialogueTrigger diagTrig;
    public Colors[] colors;
    int currColorID = 0;
    public static WindChimeManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    // Use this for initialization
    public void EnterColor(Colors temp)
    {
        if(temp == colors[currColorID])
        {
            currColorID++;
            Debug.Log("correct!");
        }
        else
        {
            currColorID = 0;
            Debug.Log("false");
        }
        if(currColorID == colors.Length)
        {
            Debug.Log("you win!");
            diagTrig.TriggerDialogue();
            PlayerController.instance.hasPixie = true;
            EventQuestManager.instance.GotPixie();

        }
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
