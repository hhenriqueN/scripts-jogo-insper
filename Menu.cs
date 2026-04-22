using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void IniciaJogo(){
        GameManager.Init();
        SceneManager.LoadScene(1);
    }

    public void MenuScreen(){
        SceneManager.LoadScene(0);
    }

}
