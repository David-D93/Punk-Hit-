using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour {

    public Rigidbody rbProtagonista;
    public float jumpForce;
    private bool grounded;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        grounded = gameObject.GetComponent<GroundCheck>().isGrounded;
        if (Input.GetButtonDown("Jump") && grounded) {
                rbProtagonista.AddForce(transform.up * jumpForce, ForceMode.Impulse);
                Debug.Log("Jump");
        }
    }
}
