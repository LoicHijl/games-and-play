using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D characterController2D;

    public CharacterController2D controller;
    public Animator animator;

    [SerializeField]
    public AudioSource jumpSound;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;


            animator.SetBool("IsJumping", true);
        }

        if (jump ==  true && characterController2D.m_Grounded == true) {

            jumpSound.Play();

        }

      

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

	}

     public void OnLanding() {

        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching (bool isCrouching) {

        animator.SetBool("IsCrouching", isCrouching);
    }

    private void FixedUpdate()
    {
        // Move character meow
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
