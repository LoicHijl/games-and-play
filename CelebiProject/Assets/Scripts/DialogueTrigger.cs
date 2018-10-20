using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public Animator animator;

	// Use this for initialization
	void Start () {
        animator.SetBool("inPocket", false);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
