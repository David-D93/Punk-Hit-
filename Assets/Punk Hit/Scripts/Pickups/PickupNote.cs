using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupNote : PickupPoints {

    public int notes = 0;

    protected override void Pick() {
        FindObjectOfType<VariableManager>().AddNotes(notes);
        base.Pick();
    }
}
