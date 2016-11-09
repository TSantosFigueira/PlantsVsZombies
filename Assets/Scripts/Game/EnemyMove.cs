using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

    public int speed = 5;
    public bool canMove;
	
	void Update () {
       if(canMove)
            transform.Translate(Vector3.left * Time.deltaTime * speed);
	}
}
