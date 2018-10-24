using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
<<<<<<< HEAD:CelebiProject/Assets/GameMaster.cs
=======
using UnityEngine.UI;

>>>>>>> Marnix2:CelebiProject/Assets/Scripts/GameMaster.cs

public class GameMaster : MonoBehaviour
{

    public static GameMaster gm;
<<<<<<< HEAD:CelebiProject/Assets/GameMaster.cs

    void Start()
    {
=======
    public int energy;
    public int deviceState;
    public Text energyText;
    void Start() {
>>>>>>> Marnix2:CelebiProject/Assets/Scripts/GameMaster.cs

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