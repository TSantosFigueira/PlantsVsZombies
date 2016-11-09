using UnityEngine;
using System.Collections;

public class SunSpawn : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        // Spawn first Sun in 10 seconds, repeat every 10 seconds
        InvokeRepeating("Spawn", 10, 10);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
