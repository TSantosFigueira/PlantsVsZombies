﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public int speed;
    public int damage;
    public Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, startPosition) > 20)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "enemy")
        {
            other.GetComponent<Health>().DoDamage(damage);
            Destroy(gameObject);
        }
    }
}
