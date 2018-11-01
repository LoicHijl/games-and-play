using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnergyBar : MonoBehaviour
{
    Text energyText;
    Image energyBar;
    float maxEnergy = 50f;
    private GameMaster gm;

    // Use this for initialization
    void Start()
    {
        energyBar = GetComponent<Image>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();

    }

    // Update is called once per frame
    void Update()
    {
        energyBar.fillAmount = gm.energy / maxEnergy;
    }
}
