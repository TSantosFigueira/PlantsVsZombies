using UnityEngine;
using System.Collections;

public class TileTaken : MonoBehaviour {

    public bool isTaken;
    public GameObject tower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        // Increase Score
        CashManager.cash += 20;

        // Destroy Sun
        Destroy(gameObject);
    }
}
