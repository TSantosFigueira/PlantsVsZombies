using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CashManager : MonoBehaviour {

    public static int cash = 300;
    public Text money_text;

    void Update()
    {
        money_text.text = cash.ToString();
    }

}
