using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Collider))]
public class PickupBase : MonoBehaviour
{
    public string[] tags;

    public GameObject spawnedPrefab;
    
    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (var t in tags)
        {
            if (!other.gameObject.CompareTag(t)) continue;
            Pick();
            break;
        }
    }

    protected virtual void Pick()
    {
        // Estendere questa funzione per attivare il pickup
        if (spawnedPrefab != null)
        {
            Instantiate(spawnedPrefab, transform.position, transform.rotation);
        }
        Destroy(this.gameObject);
    }
}
