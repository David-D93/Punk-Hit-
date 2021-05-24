using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWaves : MonoBehaviour {

    public GameObject soundWave;
    public float speed;

    void Start() {
        
    }

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            GameObject ondaSonora = Instantiate(soundWave, transform.position, transform.rotation);
            ondaSonora.GetComponent<Rigidbody>().AddRelativeForce(speed, 0, 0);
        }
    }
}
