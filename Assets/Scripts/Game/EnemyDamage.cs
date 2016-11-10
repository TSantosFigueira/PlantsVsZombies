using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour
{

    private EnemyMove enemyMove;
    private Animator anim;
    public int damage;
    private bool inTheTrigger;
    private GameObject hitGameObject;

    void Start()
    {
        enemyMove = GetComponent<EnemyMove>();
        anim = GetComponent<Animator>();
        enemyMove.canMove = true;
    }

    void Update()
    {
        if (inTheTrigger)
        {
            if (hitGameObject != null)
            {
                Health health = hitGameObject.GetComponent<Health>();
                if (health && health.currentHealth >= 0)
                {
                    StartCoroutine(WaitThenDoThings(health, anim.GetCurrentAnimatorClipInfo(0).Length));
                    enemyMove.canMove = false;
                }
            }
            else
            {
                anim.SetBool("Attack", false);
                enemyMove.canMove = true;
                inTheTrigger = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "tower" && enemyMove.canMove)
        {
            anim.SetBool("Attack", true);
            inTheTrigger = true;
            hitGameObject = other.transform.gameObject;
        }
        else if (other.transform.tag == "tile")
            enemyMove.canMove = true;
        else if (other.transform.tag == "bounds")
        {
            Bounds.crossedBounds++;
            Destroy(gameObject);
        }
            
    }

    IEnumerator WaitThenDoThings(Health localHealth, float time)
    {
        yield return new WaitForSeconds(time);
        if (localHealth)
            localHealth.DoDamage(damage);
    }
}
