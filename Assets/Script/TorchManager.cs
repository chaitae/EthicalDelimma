using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchManager : MonoBehaviour {
    int torchesLit = 0;
    public static TorchManager instance;
    public SpriteRenderer sprite;
    public Sprite giantCageOpen;
    public DialogueTrigger diagTrig;
    public void AddTorchesLit()
    {
        torchesLit++;
        if(torchesLit == 2)
        {
            sprite.sprite = giantCageOpen;
            diagTrig.interact();
            PlayerController.instance.hasGiant = true;
            EventQuestManager.instance.GotGiant();

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
