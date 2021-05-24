using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractiveActivate : InteractiveBase {

    public GameObject[] toActivate;
    public GameObject[] toDisable;

    protected override void Interact() {
        foreach (var a in toActivate) {
            a.SetActive(true);
        }
        foreach (var d in toDisable) {
            d.SetActive(false);
        }
    }
}
