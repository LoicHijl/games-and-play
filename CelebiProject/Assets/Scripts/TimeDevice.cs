using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDevice : MonoBehaviour
{
    public int deviceState;
    public Transform firePoint;
    public GameObject energyOrb;
    private GameMaster gm;

    // Update is called once per frame
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && gm.energy > 0)
        {
            deviceState = 0;
            shoot();
        }
        if (Input.GetButtonDown("Fire2") && gm.energy > 0)
        {
            gm.deviceState = 1;
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(energyOrb, firePoint.position, firePoint.rotation);
        gm.energy -= 1;
    }
}

