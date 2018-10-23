using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueContinue : MonoBehaviour {

    // Dialogue to be used
    public Dialogue dialogue;

    // Next dialoguescript
    public DialogueContinue cont;

    // Trigger the dialogue
    public void TriggerDialogue ()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, cont);
    }

}
