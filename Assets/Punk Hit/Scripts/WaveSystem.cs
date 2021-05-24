using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour {

    public GameObject ondaSonora;
    public float pushSpeed;
    public float fineOnda;


    private void Start() {
        StartCoroutine(DeleteThis());
    }

    // Probabilmente dovrò spostare tutto in script diversi da mettere ai singoli GameObject.
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Spingibile")) {
            other.attachedRigidbody.AddForce(transform.right * pushSpeed, ForceMode.Impulse);
        } else if (other.gameObject.CompareTag("Distruggibile")) {
            other.gameObject.SetActive(false);
        } 
    }

    IEnumerator DeleteThis() {
        Debug.Log("Cosa");
        yield return new WaitForSeconds(fineOnda);
        Debug.Log("Significa");
        Destroy(ondaSonora);
        Debug.Log("Questo");
    }
}
