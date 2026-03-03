using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    public CanvasGroup startMenuCanvasGroup;

    public void ShowScore(int score)
    {
        ScoreText.text = score.ToString();
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(startMenuCanvasGroup);
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(startMenuCanvasGroup);
    }
}
