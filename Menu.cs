using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Este método vai no botão "JOGAR" do Menu
    public void IniciaJogo(){
        GameManager.Init();
        SceneManager.LoadScene(1); // Carrega a SampleScene
    }

    // Este método vai no botão "MENU" da tela de Game Over
    public void MenuScreen(){
        SceneManager.LoadScene(0); // Volta para o MainMenu
    }

    // DICA: Método para o botão "REINICIAR" na tela de Game Over
    public void ReiniciarJogo(){
        GameManager.Init();
        SceneManager.LoadScene(1); // Carrega a fase de novo
    }
}
