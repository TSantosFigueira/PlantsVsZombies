using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonSelection : MonoBehaviour {

    public Button[] buttons;

    public void setButton(int num)
    {
        if(num <= buttons.Length)
        {
            PlayerPrefs.SetInt("difficulty", num);
            for (int i = 0; i < buttons.Length; i++)
            {
                if (i != (num - 1))
                {
                    var colors = buttons[i].GetComponent<Button>().colors;
                    colors.normalColor = Color.grey;
                    buttons[i].GetComponent<Button>().colors = colors;
                }   
            }
        }
    }
}
