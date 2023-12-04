using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] PowerupPatten;

    private float BtwnSpawnTime;
    public float spawnTime;
    public float spawnDelay;
    public float spawnDelayMin;

    // Start is called before the first frame update
    void Update()
    {
        if (BtwnSpawnTime <= 0)
        {
            int rand = Random.Range(0, PowerupPatten.Length);
            Instantiate(PowerupPatten[rand], transform.position, Quaternion.identity);
            BtwnSpawnTime = spawnTime;

            if (spawnTime > spawnDelayMin)
            {
                spawnTime -= spawnDelay;
            }
        }
        else
        {
            BtwnSpawnTime -= Time.deltaTime;
        }
    }
}

    