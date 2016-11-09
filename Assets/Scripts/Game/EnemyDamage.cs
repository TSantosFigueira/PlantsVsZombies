using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour {

    private EnemyMove enemyMove;
    public int damage;

	void Start () {
        enemyMove = gameObject.GetComponent<EnemyMove>();
	}

	void Update () {

        Collider2D[] inside = Physics2D.OverlapCircleAll(transform.position, .5f);

        for (int i = 0; i < inside.Length; i++)
        {
            if (inside[i].transform.tag == "tower")
            {
                Health health = inside[i].transform.gameObject.GetComponent<Health>();
                health.DoDamage(damage);
                enemyMove.canMove = false;
            }
            else
            {
                enemyMove.canMove = true;
            }
        }        
    }
}
