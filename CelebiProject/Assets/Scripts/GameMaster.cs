using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameMaster : MonoBehaviour
{

    public static GameMaster gm;
    public int energy;
    public int deviceState;
    public Text energyText;
    
    void Start()
    {
       

        if (gm == null)
        {

            gm = this;

        }
    }

    
    
    //public Transform playerPrefab;
    // public Transform spawnPoint;

    /*public void RespawnPlayer() {
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        Debug.Log("TODO SPAWN PARTICLES");
    }*/

    public static void KillPlayer()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        /* Destroy(player.gameObject);
         gm.RespawnPlayer();*/
    }

}
