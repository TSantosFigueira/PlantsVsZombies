using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof (TowerManager))]
public class CharacterAvailability : MonoBehaviour {

    public Button[] characters;
    private TowerManager towerManger;

	void Start () {
        towerManger = GetComponent<TowerManager>();
	}

	void Update () {
        for (int i = 0; i < towerManger.tower_prices.Length; i++)
        {
            if(CashManager.cash >= towerManger.tower_prices[i])
                characters[i].interactable = true;
            else
                characters[i].interactable = false;
        }
	}
}
