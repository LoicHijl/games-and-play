using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeStatesScript : MonoBehaviour
{
    public int timeState;
    public int maxtimeState;
    public int mintimeState;
    private GameMaster gm;
    Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeState > mintimeState)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                timeState--;
            }
        }
        if (timeState < maxtimeState)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                timeState++;
            }
        }

        //This only if it needs to die
        if (timeState == mintimeState || timeState == maxtimeState)
        {
            Destroy(gameObject);
        }
        animator.SetInteger("timeState", timeState);
    }
    public void TransferEnergy()
    {
        if (gm.deviceState == 1)
        {
            timeState--;
        }
        else if (gm.deviceState == 0)
        {
            timeState++;
        }

    }
}
