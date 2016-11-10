using UnityEngine;
using System.Collections;

public class SunCollect : MonoBehaviour {

    void OnMouseDown()
    {
        // Increase Score
        CashManager.cash += 50;

        // Destroy Sun
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bounds")
            Destroy(gameObject);
    }
}
