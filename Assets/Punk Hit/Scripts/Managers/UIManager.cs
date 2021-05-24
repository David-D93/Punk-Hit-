using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    private Variables sceneVariables;

    private int puntiUIInt;
    public Text puntiUI;

    private void Start() {
        sceneVariables = GetComponent<Variables>();
        // Tramite sceneVariables.declarations ho accesso alle variabili di Visual Scripting
    }
    public void UpdatePoints() {
        puntiUIInt = sceneVariables.declarations.Get<int>("punti");
        puntiUI.text = "Punti: " + puntiUIInt;
    }
}
