using UnityEngine;

public class GameManager
{
    public static int collectableCount;

    public static bool gameOver
    {
        get {return collectableCount <= 0; }
    }

    public static void Init()
    {
        collectableCount = 4;
    }

    public static void Collect()
    {
        collectableCount--;
    }
    
}
