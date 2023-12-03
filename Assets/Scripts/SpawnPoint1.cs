using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnPoint1 : MonoBehaviour
{
    public GameObject obstacle;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
