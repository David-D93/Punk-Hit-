using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Variables))]
public class VariableManager : MonoBehaviour
{
    private Variables sceneVariables;
    // TODO: collegare l'UI a questo script
    // private Text uiManager;

    private void Start()
    {
        sceneVariables = GetComponent<Variables>();
        // uiManager = GetComponent<uiManager>();
        // Tramite sceneVariables.declarations ho accesso alle variabili di Visual Scripting
    }

    //Punti

    public int GetPoints()
    {
        return sceneVariables.declarations.Get<int>("punti");
    }

    public void SetPoints(int points)
    {
        sceneVariables.declarations.Set("punti", points);
        // uiManager.UpdatePoints();

    }

    public void AddPoints(int points)
    {
        SetPoints(GetPoints() + points);
    }

    // Note

    public int GetNotes() {
        return sceneVariables.declarations.Get<int>("note");
    }

    public void SetNotes(int notes) {
        sceneVariables.declarations.Set("note", notes);
    }

    public void AddNotes(int notes) {
        SetNotes(GetNotes() + notes);
    }

    //Fan

    public bool GetFan(int index)
    {
        return sceneVariables.declarations.Get<List<bool>>("listaFan")[index];
    }

    public void SetFan(int index, bool value = true)
    {
        sceneVariables.declarations.Get<List<bool>>("listaFan")[index] = value;
    }
}
