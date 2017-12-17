using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin_L : MonoBehaviour {

    public float speed = 2500f;
    void Update()
    {
        transform.Rotate(Vector3.back, speed * Time.deltaTime);
    }

}
