using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyOrb : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    private gameMaster gm;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {


        Interactable interactable = hitInfo.GetComponent<Interactable>();
        if (interactable != null)
        {
            interactable.TransferEnergy();
            Destroy(gameObject);
            Instantiate(impactEffect, transform.position, transform.rotation);



        }
    }


}
