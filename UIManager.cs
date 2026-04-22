using UnityEngine;
using TMPro; // Adiciona isto para funcionar com o seu TempoText

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public TextMeshProUGUI timerText;      // Mudamos de Text para TextMeshProUGUI
    public TextMeshProUGUI finalTimeText;  // Mudamos de Text para TextMeshProUGUI

    void Update()
{
    // Verificamos se o timerText FOI arrastado para o slot antes de usar
    if (timerText == null) return; 

    if (GameManager.isPlaying && !GameManager.gameOver)
    {
        GameManager.timer += Time.deltaTime;
        timerText.text = "Tempo: " + GameManager.timer.ToString("F2");
    }

    if (GameManager.gameOver)
    {
        // Verificamos o painel e o texto final antes de usar
        if(endGamePanel != null) endGamePanel.SetActive(true);
        
        if(finalTimeText != null) 
            finalTimeText.text = "Tempo Final: " + GameManager.timer.ToString("F2") + "s";
            
        GameManager.isPlaying = false;
    }
}
}
