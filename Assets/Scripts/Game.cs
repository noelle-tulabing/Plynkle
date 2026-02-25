using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup startMenuCanvasGroup;
    private static bool gameStarted = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanvasGroupDisplayer.Show(startMenuCanvasGroup);
    }

    public void OnStartButtonClick()
    {
        CanvasGroupDisplayer.Hide(startMenuCanvasGroup);
        gameStarted = true;
        
    }

    public static bool IsGameStarted()
    {
        return gameStarted;
    }
}
