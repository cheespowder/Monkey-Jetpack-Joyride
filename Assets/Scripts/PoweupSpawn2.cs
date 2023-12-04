using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweupSpawn2 : MonoBehaviour
{
    public GameObject Sizeup;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Sizeup, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
