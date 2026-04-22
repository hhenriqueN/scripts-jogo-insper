using UnityEngine;

public class GameManager
{
    public static int collectableCount;
    public static float timer;
    public static bool isPlaying;
    public static bool enemyHit; // Nova variável para o dano

    public static bool gameOver
    {
        // O jogo acaba se: coletou tudo OU tempo acabou OU inimigo bateu
        get { return collectableCount <= 0 || timer >= 15f || enemyHit; }
    }

    public static void Init()
    {
        collectableCount = 4;
        timer = 0f;
        isPlaying = true;
        enemyHit = false; // Reseta o estado do inimigo
    }

    public static void Collect()
    {
        collectableCount--;
    }

    public static void SetEnemyHit()
    {
        enemyHit = true;
    }
}
