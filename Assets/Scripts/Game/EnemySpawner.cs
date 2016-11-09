﻿using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

    public int number_out;
    public GameObject[] enemies;
    public float cooldown;
    private float cooldown_counter; 

	// Use this for initialization
	void Start () {
        cooldown_counter = cooldown * 2;
	}
	
	// Update is called once per frame
	void Update () {
	    if(cooldown_counter > 0)
            cooldown_counter -= Time.deltaTime;
        else
        {
            cooldown_counter = cooldown;
            Vector2 pos = new Vector2(8, Random.Range(-4, 5));
            int index = Random.Range(0, enemies.Length);
            Instantiate(enemies[index], pos, Quaternion.identity);
        }
	}
}
