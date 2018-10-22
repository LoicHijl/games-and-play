using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDevice : MonoBehaviour
{

    public Transform firePoint;
    public GameObject energyOrb;
    private gameMaster gm;

    // Update is called once per frame
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && gm.energy > 0)
        {
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(energyOrb, firePoint.position, firePoint.rotation);
        gm.energy -= 1;
    }
}

