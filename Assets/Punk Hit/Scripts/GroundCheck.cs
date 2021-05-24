using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    private float distanceToGround;
    public bool isGrounded;
    void Start() {
        distanceToGround = GetComponent<Collider>().bounds.extents.y;
    }

    void FixedUpdate() {
        if (Physics.Raycast(transform.position, -Vector3.up, distanceToGround+0.1f)) {
            isGrounded = true;
        } else {
            isGrounded = false;
            // Debug.Log("air");
        }
    }
}
