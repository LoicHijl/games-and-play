﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;

	// Use this for initialization
	void Start () {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
