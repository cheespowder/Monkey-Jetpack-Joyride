using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawn3 : MonoBehaviour
{
    public GameObject Shield;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Shield, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
