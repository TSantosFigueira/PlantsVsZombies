using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseController : MonoBehaviour {

    public GameObject pausePanel;
    public Sprite logo;
    public Image logoImage;
    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = pausePanel.GetComponent<Animator>();
	}
	
    public void SetPaused()
    {
        anim.SetBool("Display", true);
        logoImage.sprite = logo;
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
