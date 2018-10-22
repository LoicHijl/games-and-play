using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public int energy;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "player")
        {
            //add energy
            Destroy(gameObject);
        }
    }
}