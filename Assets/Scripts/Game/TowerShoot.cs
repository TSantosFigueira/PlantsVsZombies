using UnityEngine;
using System.Collections;

public class TowerShoot : MonoBehaviour
{

    public float cooldown;
    private float cooldownCounter;
    public GameObject projectile;

    // Use this for initialization
    void Start()
    {
        cooldownCounter = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, Mathf.Infinity);
        //if (hit.collider.transform.tag == "enemy")
        //{
            if (cooldownCounter <= 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                cooldownCounter = cooldown;
            }
            else
                cooldownCounter -= Time.deltaTime;
            
        //}
    }
}
