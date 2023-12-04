using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/Shield")]

public class Shield : PowerupEffect
{
    [SerializeField] private int amount = 10;
    [SerializeField] private float speed;
    public Behaviour collsion;

    public override void Update(GameObject target)
    {
        if (target.GetComponent<Character>().health <= 0)
        {
            target.GetComponent<Character>().health = 1;
        }
        target.transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
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
