using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterCutscene : MonoBehaviour {
    // Class to play the white background fade when the last sentence of the cutscene is over

    // Simply load the next level
	public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
