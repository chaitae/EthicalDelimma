using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum DialogueAction
{
    Nothing,
    ChooseCatApppearance,
    ChooseDogAppearance,
    NPCLeave

}
public class DialogueActions : MonoBehaviour {
    void SetCatAppearance()
    {
        Debug.Log("you are now a cat");
    }
    void SetDogAppearance()
    {
        Debug.Log("you are now dog");
    }
    void NPCLeave(NPC npc)
    {

        //set npc inactive
    }
    void ProgressDay()
    {

    }
    void ProgressHour()
    {

    }
    void AddAttraction(NPC npc)
    {
        npc.stats.LoveInterest++;
    }
    void SubtractAttraction(NPC npc)
    {
        npc.stats.LoveInterest--;

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
