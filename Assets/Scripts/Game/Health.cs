using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    [SerializeField]
    int currentHealth = 100;

    public void DoDamage (int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
