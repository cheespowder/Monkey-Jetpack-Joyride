using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public Rigidbody2D rb;
    public float upSpeed;
    public ParticleSystem ps;

    public Behaviour background;
    public Behaviour spawners;
    public Behaviour goScreen;
    public Behaviour score;

    private ParticleSystem.EmissionModule em;

    public int health = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        em = ps.emission;
        goScreen.enabled = false;
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

        if (health <= 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
            upSpeed = 0;
            score.enabled = false;
            ps.enableEmission = false;
            background.enabled = false;
            spawners.enabled = false;
            goScreen.enabled = true;
        }
    }
}
