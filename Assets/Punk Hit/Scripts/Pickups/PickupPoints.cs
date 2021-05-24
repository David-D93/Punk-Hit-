using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPoints : PickupBase
{
    public int points = 0;

    protected override void Pick() {
        FindObjectOfType<VariableManager>().AddPoints(points);
        base.Pick();
    }
}
