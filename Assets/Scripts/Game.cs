using UnityEngine;

public class Game : MonoBehaviour
{
    public UI UI;
    private static bool gameStarted = false;
    
    void Start()
    {
        UI.ShowStartScreen();
        UI.HideGUI();
    }

    public void OnStartButtonClick()
    {
        UI.HideStartScreen();
        UI.ShowGUI();
        gameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return gameStarted;
    }
}
