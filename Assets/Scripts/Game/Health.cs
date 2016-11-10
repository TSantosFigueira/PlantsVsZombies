using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int currentHealth = 100;
    private EnemyMove move;
    private Animator anim;

    public void DoDamage (int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            if (gameObject.tag == "enemy")
                VictoryController.enemies_killed++;
            if (gameObject.tag == "tower")
                gameObject.GetComponentInParent<SpawnTower>().isTaken = false;

            Destroy(gameObject);
        }
    }
}
