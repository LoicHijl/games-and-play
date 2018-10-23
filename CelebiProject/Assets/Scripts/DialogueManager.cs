using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    // Queue to store sentences
    private Queue<string> sentences;
    // Bool to keep track of dialogue
    private bool dialogueActive = false;

    // Next dialogue to be played
    private DialogueContinue next;

	// Use this for initialization
	void Start () {
        // Instantiate Queue when starting
        sentences = new Queue<string>();
	}

    void Update()
    {
        // Always check for space key when dialogue is active
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    // Start dialogue function
    public void StartDialogue (Dialogue dialogue, DialogueContinue cont)
    {
        // Set next to the given DialogueContinue
        next = cont;

        // Set the character name
        nameText.text = dialogue.name;

        // Maybe add fonts later
 //       nameText.font = dialogue.font;
 //       dialogueText.font = dialogue.font;

        // Play dialogue open animation if it's not already open
        animator.SetBool("isOpen", true);

        // Clear Queue
        sentences.Clear();

        // Enqueue each sentence
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        // Set dialogue active
        dialogueActive = true;

        // Display next (in this case first) sentence
        DisplayNextSentence();
    }

    // Method to display the sentences
    public void DisplayNextSentence()
    {
        // If no more sentences are left in the queue, end the dialogue
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        // Dequeue one sentence
        string sentence = sentences.Dequeue();

        // Stop coroutines and start the TypeSentence coroutine
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        //If we don't want to do it with coroutines: dialogueText.text = sentence;
    }

    // Coroutine to type each letter separately
    IEnumerator TypeSentence (string sentence)
    {
        // Clear text area
        dialogueText.text = "";

        // Type each letter, followed by a short wait
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return 3;
        }
    }

    // UI for whitescreen
    public GameObject completeUI;

    public void EndDialogue()
    {
        // Close the dialogue box
        animator.SetBool("isOpen", false);
        // Set dialogue inactive
        dialogueActive = false;

        // If there is more dialogue after this, trigger it
        // Else start playing the endcutscene whitescreen ui
        if (next != null)
        {
            next.TriggerDialogue();
        }
        else
        {
            completeUI.SetActive(true);
        }
    }
}
