using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public Rigidbody2D rb;
    public float upSpeed;
    public ParticleSystem ps;

    private ParticleSystem.EmissionModule em;

    public int health = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        em = ps.emission;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, upSpeed));
            em.enabled = true;
            
        }
        else
        {
            em.enabled = false;
        }
    }
}
