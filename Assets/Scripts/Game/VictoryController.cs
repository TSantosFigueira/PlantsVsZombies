using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VictoryController : MonoBehaviour {

    public static int enemies_killed;
    public Image logo;
    public Sprite victoryLogo;
    public Sprite defeatLogo;
    public PauseController panel;
    public Button back;
    private int difficulty;
    private Animator anim;

    void Start () {
        enemies_killed = 0; 
        difficulty = PlayerPrefs.GetInt("difficulty", 2);
        anim = panel.GetComponent<Animator>();
    }

	void Update () {
        if (difficulty == 1 && enemies_killed >= 10) //easy
            Victory();
        else if (difficulty == 2 && enemies_killed >= 40) // normal
            Victory();
        else if (difficulty == 3 && enemies_killed >= 80) //hard
            Victory();

        if(difficulty == 1 && Bounds.crossedBounds >= 7) //easy
            Defeat();
        else if (difficulty == 2 && Bounds.crossedBounds >= 5) //normal
            Defeat();
        else if (difficulty == 3 && Bounds.crossedBounds >= 2) //hard
            Defeat();
    }

    private void Victory()
    {
        anim.SetBool("Display", true);
        logo.sprite = victoryLogo;
        back.interactable = false;
        StartCoroutine(WaitThenDoThings(anim.GetCurrentAnimatorClipInfo(0).Length));
    }

    IEnumerator WaitThenDoThings(float time)
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = 0;
    }

    private void Defeat()
    {
        anim.SetBool("Display", true);
        logo.sprite = defeatLogo;
        back.interactable = false;
        StartCoroutine(WaitThenDoThings(anim.GetCurrentAnimatorClipInfo(0).Length));
    }
}
