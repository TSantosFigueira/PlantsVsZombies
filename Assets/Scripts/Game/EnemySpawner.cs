using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] spawnPositions;
    public float cooldown;
    private float cooldown_counter;
   
    void Start()
    {
        cooldown_counter = cooldown * 2;
    }

    void Update()
    {
        if (cooldown_counter > 0)
            cooldown_counter -= Time.deltaTime;
        else
        {
            cooldown_counter = cooldown;
            //Vector2 pos = new Vector2(8, Random.Range(-4, 5));
            int pos = Random.Range(0, spawnPositions.Length);
            int index = Random.Range(0, enemies.Length);
            Instantiate(enemies[index], spawnPositions[pos].transform.position, Quaternion.identity);
        }
    }
}
