using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullEyeSocket : MonoBehaviour,IItemInteracterble {
    public GameObject eyeJewel;
    public Animator anim;
    //public SpriteRenderer spriteRend;
    //public Sprite splo
    private IEnumerator coroutine;
    public void interact(Item item)
    {
        if(item == Item.jewel)
        {
            //spriteRend
            eyeJewel.SetActive(true);
            PlayerController.instance.RemoveItem(item);
            coroutine = WaitAndPrint(.2f);
            StartCoroutine(coroutine);
            Debug.Log("exploded");
            PlayerController.instance.hasMermaid = true;

        }
        //throw new System.NotImplementedException();
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        //while (true)
        //{
        yield return new WaitForSeconds(waitTime);
        anim.SetBool("explode", true);
        //    print("WaitAndPrint " + Time.time);
        //}
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
