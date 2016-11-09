using UnityEngine;
using System.Collections;

public class SpawnTower : MonoBehaviour {

    public bool isTaken;
    public GameObject tower;

    void OnMouseDown()
    {
        if(CashManager.cash >= TowerManager.tower_price && !isTaken && TowerManager.tower)
        {
            CashManager.cash -= TowerManager.tower_price;
            tower = (GameObject)Instantiate(TowerManager.tower, new Vector2(transform.position.x, transform.position.y), Quaternion.identity, transform);
            isTaken = true;
            TowerManager.tower = null;
            TowerManager.tower_price = 0;
        }
    }
}
