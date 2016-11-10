using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour
{

    private EnemyMove enemyMove;
    private Animator anim;
    public int damage;
    public static int crossedBounds;

    void Start()
    {
        enemyMove = GetComponent<EnemyMove>();
        anim = GetComponent<Animator>();
        crossedBounds = 0;
        enemyMove.canMove = true;
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "tower" && enemyMove.canMove)
        {
            anim.SetBool("Attack", true);
        }
        else if (other.transform.tag == "tile")
        {
            enemyMove.canMove = true;
        }
        else if (other.transform.tag == "bounds")
            crossedBounds++;

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.tag == "tower")
        {
            Health health = other.transform.gameObject.GetComponent<Health>();
            if (health.currentHealth >= 0)
            {
                StartCoroutine(WaitThenDoThings(health, anim.GetCurrentAnimatorClipInfo(0).Length));
                enemyMove.canMove = false;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.transform.tag == "tower")
        {
            anim.SetBool("Attack", false);
            enemyMove.canMove = true;
        }
        
    }

    IEnumerator WaitThenDoThings(Health localHealth, float time)
    {
        yield return new WaitForSeconds(time);
        if (localHealth)
            localHealth.DoDamage(damage);
    }
}
