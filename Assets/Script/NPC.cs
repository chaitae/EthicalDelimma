using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : DialogueTrigger, IItemInteracterble
{
    Dialogue dialogue;
    public Dialogue appleDialogue;
    public Dialogue genItemDialogue;
    public NPCStats stats = new NPCStats();
    public virtual void interact(Item item)
    {
        //if(item == Item.apple)
        //{
        //    string[] sentence = { "hello", "gold" };
        //    Dialogue bah = new Dialogue(sentence);
        //    DialogueManager.instance.StartDialogue(bah);
        //}
        //else
        //{
        //    DialogueManager.instance.StartDialogue(genItemDialogue);

        //}
        DialogueManager.instance.StartDialogue(genItemDialogue);

    }
}
