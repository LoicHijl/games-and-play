using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogJump : MonoBehaviour {
    private bool FrogJumping = false;
    public float JumpingTime;
    Animator animator;
    // Use this for initialization
    void Awake()
    {
            InvokeRepeating("Switch", 0, JumpingTime);        
    }
 
    void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        animator.SetBool("FrogJumping", FrogJumping);
        if (FrogJumping == true)
        {
            FrogJumping = false;
        }
    }

    void Switch()
    {
        FrogJumping = true;
    }
}
