using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerupEffect : ScriptableObject
{
    public abstract void Update(GameObject target);

    public abstract void Apply(GameObject target);

    public abstract void Remove(GameObject target);
}
