using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

    // Use this for initialization
    public Text hour;
    public GameObject itemContainer;
    public GameObject itemPrefab;
    public GameObject[] items;
    public Sprite[] itemSprites;
    private void OnEnable()
    {
        GameManager.OnTimeChangedHandler += UpdateClock;
        PlayerController.OnUpdateInventoryHandler += FillInventory;
    }
    private void OnDisable()
    {
        GameManager.OnTimeChangedHandler -= UpdateClock;
        PlayerController.OnUpdateInventoryHandler -= FillInventory;

    }
    void UpdateClock()
    {
        hour.text = GameManager.hour + ":00";

    }
    void FillInventory()
    {
        foreach (Transform child in itemContainer.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        List<Item> items = PlayerController.instance.inventory;
        foreach(Item item in items)
        {
            GameObject temp = Instantiate(itemPrefab, itemContainer.transform);
            //Instantiate(itemPrefab, itemContainer.transform).GetComponent<ItemDrag>().item = item;
            temp.GetComponent<ItemDrag>().item = item;
            temp.GetComponent<Image>().sprite = itemSprites[(int)item];
        }
    }
    void Start () {
        FillInventory();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
