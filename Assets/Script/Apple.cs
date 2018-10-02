using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Apple : MonoBehaviour,IInteractable,IDragHandler,IBeginDragHandler,IEndDragHandler {
    public void interact()
    {
        Debug.Log("pass time");
        GameManager.instance.IncreaseHour();
        //throw new System.NotImplementedException();
    }

    public void interact(KeyCode key)
    {
        throw new System.NotImplementedException();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begin drag");
        Instantiate(gameObject,transform.parent);
        //throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("bawah drag");
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("dead");
        Destroy(gameObject);
        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
