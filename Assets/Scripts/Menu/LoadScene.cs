using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public string cenaParaCarregar;
    public string menuPrincipal;
    //Carrega a primeira fase

    public void goToScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(cenaParaCarregar);
    }

    public void goToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(menuPrincipal);
    }
}
