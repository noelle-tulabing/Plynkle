using UnityEngine;

public class Game : MonoBehaviour
{
    public UI UI;
    private static bool gameStarted = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UI.ShowStartScreen();
    }

    public void OnStartButtonClick()
    {
        UI.HideStartScreen();
        gameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return gameStarted;
    }
}
