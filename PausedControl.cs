using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedControl : MonoBehaviour {


	public Transform canvas;
	void Update () {

		if(Input.GetKeyDown(KeyCode.Escape))
		pause();
	}


	public void pause () {
		if (canvas.gameObject.activeInHierarchy == false)
		{
		canvas.gameObject.SetActive(true);
		Time.timeScale = 0;
		}
		else
		{
		canvas.gameObject.SetActive(false);
		Time.timeScale = 1;
		}		
	}



	public void loadMenu() {
	SceneManager.LoadScene ("option");
	}


    public void restart() {
    	GamePlaySpawnners.counter = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    	}	


}
