using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneGunScript : MonoBehaviour {

	public Transform gunTransform;
	public GameObject bulletPrefab;
	public float fireRate = 6;
	private float waitTillNextFire = 0.0f;
	public AudioSource ShootingSound;

    void Update()
    {
        ShootingBulletes();
    }

    
    void ShootingBulletes()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if(waitTillNextFire <= 0)
            {
                Instantiate(bulletPrefab, gunTransform.position, gunTransform.rotation);
                ShootingSound.Play();
                waitTillNextFire = 1;             
            }
        }
        waitTillNextFire -= fireRate * Time.deltaTime;
    }

}
