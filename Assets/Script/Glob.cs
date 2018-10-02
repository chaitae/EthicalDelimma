using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glob : NPC {
    string[] tempSentence;
    Dialogue temp;

    public override void interact(Item item)
    {
        switch (item)
        {
            //should have look up table apple = ilove apples and just ake seperate sheets for dif characters
            //case Item.apple:
            //    tempSentence = new string[] { "Iloveapples" };
            //    this.temp = new Dialogue(tempSentence);
            //    base.stats.inventory.Add(item);
            //    PlayerController.instance.RemoveItem(item);
            //    DialogueManager.instance.StartDialogue(this.temp);
            //    break;
            //case Item.cat:
            //    tempSentence = new string[] { "I love cats!" };
            //    this.temp = new Dialogue(tempSentence);
            //    base.stats.inventory.Add(item);
            //    PlayerController.instance.RemoveItem(item);
            //    DialogueManager.instance.StartDialogue(this.temp);
            //    break;
            //case Item.present:
            //    break;
        }
    }


}
