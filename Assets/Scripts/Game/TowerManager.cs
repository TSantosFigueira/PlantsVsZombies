using UnityEngine;
using System.Collections;

public class TowerManager : MonoBehaviour {

    public static GameObject tower;
    public static int tower_price;

    public GameObject[] towers;
    public int[] tower_prices;

    public void SetTower(int index)
    {
        switch (index)
        {
            case 1:
                tower = towers[0];
                tower_price = tower_prices[0];
                break;
            case 2:
                tower = towers[1];
                tower_price = tower_prices[1];
                break;
            case 3:
                tower = towers[2];
                tower_price = tower_prices[2];
                break;
            case 4:
                tower = towers[3];
                tower_price = tower_prices[3];
                break;
        }
    }
}
