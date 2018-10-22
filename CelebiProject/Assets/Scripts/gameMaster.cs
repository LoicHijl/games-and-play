using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{

    public int energy;
    public Text energyText;

    void Update()
    {
        energyText.text = ("Energy: " + energy);
    }
}