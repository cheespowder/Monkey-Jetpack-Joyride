using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SizeUp")]

public class SizeUp : PowerupEffect
{
    [SerializeField] private float amount = 1.5f;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Character>().transform.localScale *= amount;
    }

    public override void Remove(GameObject target)
    {
        target.GetComponent<Character>().transform.localScale /= amount;
    }
}
