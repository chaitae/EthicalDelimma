using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
public class ItemDrag : DialogueTrigger,IDragHandler, IBeginDragHandler, IEndDragHandler,IPointerEnterHandler,IPointerExitHandler,IPointerClickHandler
{
    public Item item;
    Vector3 orignalPosition;
    bool overItem = false;
	// Use this for initialization
	void Start () {
        orignalPosition = this.transform.position;
	}
	

    public void OnBeginDrag(PointerEventData eventData)
    {
        //PlayerController.instance.draggingItem = true;
        //throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        //PlayerController.instance.draggingItem = false;
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Instantiate(gameObject, orignalPosition, Quaternion.identity, transform.parent);
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider)
        {
            Debug.Log(hit.collider.name);
            IItemInteracterble interactable = hit.collider.GetComponent<IItemInteracterble>();
            if (interactable != null)
            {
                interactable.interact(item);
            }
        }
      
            //say things
        
        Destroy(gameObject);
    }
    void Combine(Item _item)
    {
        Instantiate(gameObject, orignalPosition, Quaternion.identity, transform.parent);

        //if (item == Item.apple && this.item == Item.apple)
        //{
        //    Debug.Log("bwaaah");
        //    Debug.Log("created cat apple");
        //    Instantiate(this, transform.parent).item = Item.present;
        //    Destroy(gameObject);
        //}
        //else
        //{
        //    Instantiate(gameObject, orignalPosition, Quaternion.identity, transform.parent);

        //}
    }



    public void OnPointerEnter(PointerEventData eventData)
    {
        if(eventData.pointerEnter.GetComponent<ItemDrag>() != null)
        overItem = true;
        //throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerEnter.GetComponent<ItemDrag>() != null)
            overItem = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        base.TriggerDialogue();
    }
}
