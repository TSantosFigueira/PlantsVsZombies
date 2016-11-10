using UnityEngine;
using System.Collections;

public class SunSpawn : MonoBehaviour
{
    public GameObject prefab;
    public int spawnTime = 3;

    void Start()
    {
        // Spawn first Sun in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
