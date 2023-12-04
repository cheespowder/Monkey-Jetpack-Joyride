using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/Shield")]

public class Shield : PowerupEffect
{
    [SerializeField] private int amount = 10;

    public override void Apply(GameObject target)
    {
        target.GetComponent<Character>().health += amount;
        target.GetComponent<SpriteRenderer>().color = Color.blue;
    }

    public override void Remove(GameObject target)
    {
        target.GetComponent<Character>().health -= amount;
        target.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
