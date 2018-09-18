using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComputer : DialogueTrigger {

    public int id;

    public override void FireTrigger()
    {
        if (triggerOnce && triggered)
        {
            return;
        }
        triggered = true;

        GameObject.FindGameObjectWithTag("Computer").GetComponent<DialogueWithTrigger>().enabled = true;
        GameObject.FindGameObjectWithTag("Trigger2").GetComponent<DialogueEngine>().ChangeDialogueToID(id, true);
    }
}
