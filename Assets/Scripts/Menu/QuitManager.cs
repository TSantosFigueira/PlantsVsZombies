using UnityEngine;
using System.Collections;

public class QuitManager : MonoBehaviour {

    public GameObject quit;
    private Animator quitAnimator;

    void Start()
    {     
        quitAnimator = quit.GetComponent<Animator>();
    }

    public void DisableQuitAnimation()
    {
        quitAnimator.SetBool("Display", false);
        StartCoroutine(WaitThenDoThings(quitAnimator.GetCurrentAnimatorClipInfo(0).Length));
    }

    public void EnableQuitAnimation()
    {
        quitAnimator.SetBool("Display", true);
        quit.GetComponent<Canvas>().sortingOrder = 110;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EnableQuitAnimation();
        }
    }

    // Na confirmação de saída, o botão "Não" foi pressionado
    public void noPressed()
    {
        DisableQuitAnimation();
    }

    // Na confirmação de saída, o botão "Sim" foi pressionado
    public void GameQuit()
    {
        Application.Quit();
    }

    IEnumerator WaitThenDoThings(float time)
    {
        yield return new WaitForSeconds(time);
        quit.GetComponent<Canvas>().sortingOrder = 80;
    }
}
