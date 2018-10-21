using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class DialogueTrigger : MonoBehaviour {

    // First dialogue script
    // Includes: Dialogue, Animator for timemachine, Next Dialoguetrigger
    public Dialogue dialogue;
    public Animator animator;
    public DialogueContinue cont;

	// Use this for initialization
	void Start () {
        // Play timemachine animation
        animator.SetBool("inPocket", false);
        // Basic dialogue behavior
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue, cont);
	}
	
}
