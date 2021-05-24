using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupFan : PickupBase {

    public int index;

    protected override void Pick() {
        FindObjectOfType<VariableManager>().SetFan(index);
    }
}
