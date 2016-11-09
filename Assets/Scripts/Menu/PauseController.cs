using UnityEngine;
using System.Collections;

public class PauseController : MonoBehaviour {

    public GameObject pausePanel;
    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = pausePanel.GetComponent<Animator>();
	}
	
    public void SetPaused()
    {
        anim.SetBool("Display", true);
        StartCoroutine(WaitThenDoThings(anim.GetCurrentAnimatorClipInfo(0).Length));
    }

    public void Unpause()
    {
        anim.SetBool("Display", false);
        Time.timeScale = 1;
    }

    IEnumerator WaitThenDoThings(float time)
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = 0;
    }
}
