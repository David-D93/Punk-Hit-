using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Collider))]
public class InteractiveBase : MonoBehaviour {
    public string[] interactiveTags;

    public GameObject spawnedPrefab;

    void Start() {
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other) {
        foreach (var t in interactiveTags) {
            if (!other.gameObject.CompareTag(t)) continue;
            Interact();
            break;
        }
    }

    protected virtual void Interact() {
        // Estendere questa funzione per attivare l'interazione
        if (spawnedPrefab != null) {
            Instantiate(spawnedPrefab, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}