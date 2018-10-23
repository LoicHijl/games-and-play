using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;

    public int energy;
    public Text energyText;

    

    void Start() {
        energy = 0;

        if (gm == null) {

            gm = this;

        }       
    }

    void Update()
    {
        energyText.text = ("Energy: " + energy);
    }


    //public Transform playerPrefab;
    // public Transform spawnPoint;

    /*public void RespawnPlayer() {
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        Debug.Log("TODO SPAWN PARTICLES");
    }*/

    public static void KillPlayer() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       /* Destroy(player.gameObject);
        gm.RespawnPlayer();*/
    }
}

