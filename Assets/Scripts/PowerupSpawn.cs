using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PowerupSpawn : MonoBehaviour
{
    public GameObject SizeDown;
    
    
    public float PowerUpSpeed;
    
   

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(SizeDown, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
