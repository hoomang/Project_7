using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public AudioClip audioClip;
	public void load(int curr)
	{
		SceneManager.LoadScene (curr);
	}

	public void loadclip()
	{
		if (audioClip != null) {
			AudioSource audio = GetComponent<AudioSource> ();
			audio.clip = audioClip;
			audio.Play ();
		}
	}

	public void exit()
	{
		Application.Quit();
	}
}
