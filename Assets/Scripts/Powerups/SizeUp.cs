using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[CreateAssetMenu(menuName = "Powerups/SizeUp")]

public class SizeUp : PowerupEffect
{
    [SerializeField] private float amount = 1.5f;
    [SerializeField] private float speed;

    public override void Update(GameObject target)
    {
        target.transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    public override void Apply(GameObject target)
    {
        target.GetComponent<Character>().transform.localScale *= amount;
    }

    public override void Remove(GameObject target)
    {
        target.GetComponent<Character>().transform.localScale /= amount;
    }
}
