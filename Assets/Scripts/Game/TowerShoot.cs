using UnityEngine;
using System.Collections;

public class TowerShoot : MonoBehaviour {

    public float cooldown;
    private float cooldownCounter;
    public GameObject projectile;

	// Use this for initialization
	void Start () {
        cooldownCounter = cooldown;
	}
	
	// Update is called once per frame
	void Update () {
        if (cooldownCounter > 0)
        {
            cooldownCounter -= Time.deltaTime;
        }     
        else
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 30);
            if (hit.collider.transform.tag == "enemy")
            {
                cooldownCounter = cooldown;
                Instantiate(projectile, transform.position, Quaternion.identity);
            }
           
        }
	}
}
