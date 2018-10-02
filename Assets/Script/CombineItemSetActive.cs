using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineItemSetActive : MonoBehaviour,IItemInteracterble {
    public Item neededItem;
    public GameObject target;
    public GameObject gameObjectGO;
    public void interact(Item item)
    {
        if(item == neededItem)
        {
            target.SetActive(true);
            PlayerController.instance.RemoveItem(item);
            //gameObjectGO.GetComponent<IActivatable>().Activate();
            IActivatable[] activatables = gameObjectGO.GetComponents<IActivatable>();
            foreach(IActivatable activatable in activatables)
            {
                activatable.Activate();
            }
        }
        //throw new System.NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
