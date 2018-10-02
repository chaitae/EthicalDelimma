using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PlayerController : MonoBehaviour{

    public bool draggingItem = false;
    // Use this for initialization
    public static PlayerController instance;
    public delegate void UpdateInventory();
    public static event UpdateInventory OnUpdateInventoryHandler;
    public List<Item> inventory = new List<Item>();
    public bool hasMermaid = false;
    public bool hasGiant = false;
    public bool hasPixie = false;
    public bool hasInvis = false;
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
    void Start () {
		
	}
    public void AddItem(Item _item)
    {
        inventory.Add(_item);
        if (OnUpdateInventoryHandler != null)
            OnUpdateInventoryHandler();
    }
    public void RemoveItem(Item _item)
    {

        inventory.Remove(_item);
        if (OnUpdateInventoryHandler != null)
            OnUpdateInventoryHandler();
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
        if(hit.collider)
        {

            IInteractable[] interactables = hit.collider.GetComponents<IInteractable>();
            if(Input.GetMouseButtonDown(0))
            {
                foreach(IInteractable interactable in interactables)
                {
                    interactable.interact();
                }
            }
        }
    }
}
