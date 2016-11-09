using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AboutDisplayer : MonoBehaviour {

    public GameObject credits;
    private Animator creditsAnimator;

	void Start () {
        creditsAnimator = credits.GetComponent<Animator>();
	}
	
    public void DisplayCredits()
    {
        creditsAnimator.SetBool("Display", true);
        credits.GetComponent<Canvas>().sortingOrder = 110;
    }

    public void UndisplayCredits()
    {
        creditsAnimator.SetBool("Display", false);
        StartCoroutine(WaitThenDoThings(creditsAnimator.GetCurrentAnimatorClipInfo(0).Length));
    }

    IEnumerator WaitThenDoThings(float time)
    {
        yield return new WaitForSeconds(time);
        credits.GetComponent<Canvas>().sortingOrder = 90;
    }
}
