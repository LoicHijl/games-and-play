using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip playerHitSound, jumpSound;

    static AudioSource audioSrc;

// Use this for initialization
	void Start () {
        playerHitSound = Resources.Load<AudioClip>("playerHit");
        jumpSound = Resources.Load<AudioClip>("jump");

        audioSrc = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip) {

        switch (clip) {

            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "playerHit":
                audioSrc.PlayOneShot(playerHitSound);
                break;












        }





    }
}
