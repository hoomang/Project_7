using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextLevel : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
    	if (other.tag == "Player")
    	{
        GamePlaySpawnners.counter = 0;
        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Drone_1")) 
        SceneManager.LoadScene ("Drone_2");
        else
        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Drone_2")) 
        SceneManager.LoadScene ("Drone_3");
        else
        if (SceneManager.GetActiveScene () == SceneManager.GetSceneByName ("Drone_3")) 
        SceneManager.LoadScene ("option");
    	}

    }
}
