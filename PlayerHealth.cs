using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

	private static float playerHealthSystem;
	private static float playerSecondaryHealth;
	private static float maxSec;
	private static float maxHealth;
	public GameObject explosionOnDeath;
	public AudioClip audioClip;
	void Start () {
		playerHealthSystem = 100f;
		playerSecondaryHealth = 10f;
		maxSec = 10f;
		maxHealth = 100f;
	}

	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.tag == "enembullet") {
			UltimateStatusBar.UpdateStatus( "Player", "SecondaryHealth" ,getPlayerSecondaryHealth(), maxSec);
			incrementSecondary (4);
			if (getPlayerSecondaryHealth() <= 0.0f) {
				incrementPlayerHealth (50);
				playerSecondaryHealth = 10f;
			}
			Destroy (collision.gameObject);
			UltimateStatusBar.UpdateStatus( "Player", "Health",getPlayerHealthSystem(), maxHealth);
			if (getPlayerHealthSystem() <=0.0f) {
				ChangeLevel ();
				transform.gameObject.SetActive (false);
				if (explosionOnDeath != null) {
					Instantiate (explosionOnDeath, transform.position, transform.rotation);
					if (audioClip != null) {
						AudioSource audio = GetComponent<AudioSource> ();
						audio.clip = audioClip;
						audio.Play ();

					}
				}
				Destroy (this.gameObject);
				SceneManager.LoadScene (0);
			}


		}
	}

	public void incrementSecondary(float health)
	{
		playerSecondaryHealth -= health;
	}

	public void incrementPlayerHealth(float health)
	{
		playerHealthSystem -= health;
	}

	public static float getPlayerHealthSystem()
	{
		return playerHealthSystem;
	}

	public static float getPlayerSecondaryHealth()
	{
		return playerSecondaryHealth;
	}

	IEnumerator ChangeLevel()
	{
		float fadeTime = GameObject.Find ("levelFade").GetComponent<FadeOutSection> ().BeginFade (1);
		yield return new WaitForSeconds (fadeTime);
		SceneManager.LoadScene (0);
	}
}
