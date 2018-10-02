using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChangeOnClick : MonoBehaviour,IInteractable {
    public SpriteRenderer sprite;
    public Sprite frontDisk;
    public Sprite backDisk;
    bool toggled = false;


    public void interact()
    {
        Debug.Log("pressed");
        if(toggled==false)
        {
            sprite.sprite = backDisk;
        }
        else
        {
            sprite.sprite = frontDisk;
        }
        toggled = !toggled;
        //sprite.sprite = ;
        //throw new System.NotImplementedException();
    }

    public void interact(KeyCode key)
    {
        throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
