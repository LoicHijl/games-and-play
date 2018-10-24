using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyOrb : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    private GameMaster gm;

    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }


    void OnTriggerEnter2D(Collider2D hitInfo)
    {


        timeStatesScript timeStateScript = hitInfo.GetComponent<timeStatesScript>();
        if (timeStateScript != null)
        {
            timeStateScript.TransferEnergy();
            Destroy(gameObject);
            Instantiate(impactEffect, transform.position, transform.rotation);
        }





    }



}
